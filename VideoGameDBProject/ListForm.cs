using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoGameDBProject
{
    public partial class ListForm : Form
    {
        public SqlConnection DBConnection;
        public string email;

        public ListForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmdLoadList = DBConnection.CreateCommand();
            cmdLoadList.CommandText = "SELECT L.List_Name FROM LIST as L WHERE L.User_Email = '" + this.email + "'";
            SqlDataReader reader = cmdLoadList.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();

            comboBox1.SelectedIndex = 0;

            SqlCommand cmdLoadGrid = DBConnection.CreateCommand();

            cmdLoadGrid.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, D.Developer_Name, P.Publisher_Name FROM VIDEO_GAME AS VG, PUBLISHER AS P, DEVELOPER AS D, LIST AS L, LIST_ITEM AS LI WHERE VG.Dev_id = D.Developer_ID AND VG.Pub_id = P.Publisher_ID AND VG.VideoGame_id = LI.V_ID AND L.List_ID = LI.L_ID AND L.List_Name = '" + comboBox1.SelectedItem + "'";

            SqlDataReader reader2 = cmdLoadGrid.ExecuteReader();

            List_ListView.Items.Clear();

            while (reader2.Read())
            {
                ListViewItem lv = new ListViewItem(reader2[0].ToString());
                lv.SubItems.Add(reader2[1].ToString());
                lv.SubItems.Add(reader2[2].ToString());
                lv.SubItems.Add(reader2[3].ToString());
                lv.SubItems.Add(reader2[4].ToString());

                List_ListView.Items.Add(lv);

            }

            reader2.Close();

            SqlCommand cmdLoadVideoGames = DBConnection.CreateCommand();
            cmdLoadVideoGames.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, D.Developer_Name, P.Publisher_Name FROM VIDEO_GAME AS VG, PUBLISHER AS P, DEVELOPER AS D WHERE VG.Dev_id = D.Developer_ID AND VG.Pub_id = P.Publisher_ID";

            SqlDataReader reader3 = cmdLoadVideoGames.ExecuteReader();

            VG_ListView.Items.Clear();
            while (reader3.Read())
            {
                ListViewItem lv = new ListViewItem(reader3[0].ToString());
                lv.SubItems.Add(reader3[1].ToString());
                lv.SubItems.Add(reader3[2].ToString());
                lv.SubItems.Add(reader3[3].ToString());
                lv.SubItems.Add(reader3[4].ToString());

                VG_ListView.Items.Add(lv);

            }
          
           

            reader3.Close();




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmdLoadGrid = DBConnection.CreateCommand();

            cmdLoadGrid.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, D.Developer_Name, P.Publisher_Name FROM VIDEO_GAME AS VG, PUBLISHER AS P, DEVELOPER AS D, LIST AS L, LIST_ITEM AS LI WHERE VG.Dev_id = D.Developer_ID AND VG.Pub_id = P.Publisher_ID AND VG.VideoGame_id = LI.V_ID AND L.List_ID = LI.L_ID AND L.List_Name = '" + comboBox1.SelectedItem + "'";

            SqlDataReader reader2 = cmdLoadGrid.ExecuteReader();


            List_ListView.Items.Clear();
            while (reader2.Read())
            {
                ListViewItem lv = new ListViewItem(reader2[0].ToString());
                lv.SubItems.Add(reader2[1].ToString());
                lv.SubItems.Add(reader2[2].ToString());
                lv.SubItems.Add(reader2[3].ToString());
                lv.SubItems.Add(reader2[4].ToString());

                List_ListView.Items.Add(lv);

            }

            reader2.Close();



        }

        private void listGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {
            PriceForm pForm = new PriceForm();
            this.Hide();
            pForm.DBConnection = DBConnection;
            pForm.email = email;
            pForm.ShowDialog();
        }

        private void reviewLabel_Click(object sender, EventArgs e)
        {
            ReviewForm rForm = new ReviewForm();
            this.Hide();
            rForm.DBConnection = DBConnection;
            rForm.email = email;
            rForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccountForm accForm = new AccountForm();
            this.Hide();
            accForm.DBConnection = DBConnection;
            accForm.email = email;
            accForm.ShowDialog();
        }

        private void listLabel_Click(object sender, EventArgs e)
        {

        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            MainForm objMain = new MainForm();
            this.Hide();
            objMain.DBConnection = DBConnection;
            objMain.email = email;
            objMain.ShowDialog();
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void List_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection games = VG_ListView.SelectedItems;


            SqlCommand cmdAddVG = DBConnection.CreateCommand();

            try
            {

                foreach (ListViewItem item in games)
                {

                    cmdAddVG.CommandText = "INSERT INTO LIST_ITEM SELECT LIST.List_ID, VIDEO_GAME.VideoGame_id FROM LIST, VIDEO_GAME WHERE LIST.List_Name = '" + comboBox1.SelectedItem + "' AND VIDEO_GAME.Title = '" + item.SubItems[0].Text + "' AND LIST.User_Email = '" + email + "'";
                    cmdAddVG.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            SqlCommand cmdLoadGrid = DBConnection.CreateCommand();

            cmdLoadGrid.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, D.Developer_Name, P.Publisher_Name FROM VIDEO_GAME AS VG, PUBLISHER AS P, DEVELOPER AS D, LIST AS L, LIST_ITEM AS LI WHERE VG.Dev_id = D.Developer_ID AND VG.Pub_id = P.Publisher_ID AND VG.VideoGame_id = LI.V_ID AND L.List_ID = LI.L_ID AND L.List_Name = '" + comboBox1.SelectedItem + "'";

            SqlDataReader reader2 = cmdLoadGrid.ExecuteReader();


            List_ListView.Items.Clear();
            while (reader2.Read())
            {
                ListViewItem lv = new ListViewItem(reader2[0].ToString());
                lv.SubItems.Add(reader2[1].ToString());
                lv.SubItems.Add(reader2[2].ToString());
                lv.SubItems.Add(reader2[3].ToString());
                lv.SubItems.Add(reader2[4].ToString());

                List_ListView.Items.Add(lv);

            }

            reader2.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this Video Game", "Delete Video Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ListView.SelectedListViewItemCollection games = List_ListView.SelectedItems;              


                SqlCommand cmdDeleteVG = DBConnection.CreateCommand();

                try
                {

                    foreach (ListViewItem item in games)
                    {
                       

                        cmdDeleteVG.CommandText = "DELETE FROM LIST_ITEM WHERE LIST_ITEM.L_ID IN(SELECT LIST.List_ID FROM LIST, VIDEO_GAME WHERE LIST.List_Name = '" + comboBox1.SelectedItem + "' AND VIDEO_GAME.Title = '" + item.SubItems[0].Text + "' AND LIST.User_Email = '" + email + "') AND LIST_ITEM.V_ID IN(SELECT VIDEO_GAME.VideoGame_id FROM LIST, VIDEO_GAME WHERE LIST.List_Name = '" + comboBox1.SelectedItem + "' AND VIDEO_GAME.Title = '" + item.SubItems[0].Text + "' AND LIST.User_Email = '" + email +"')";
                        cmdDeleteVG.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                SqlCommand cmdLoadGrid = DBConnection.CreateCommand();

                cmdLoadGrid.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, D.Developer_Name, P.Publisher_Name FROM VIDEO_GAME AS VG, PUBLISHER AS P, DEVELOPER AS D, LIST AS L, LIST_ITEM AS LI WHERE VG.Dev_id = D.Developer_ID AND VG.Pub_id = P.Publisher_ID AND VG.VideoGame_id = LI.V_ID AND L.List_ID = LI.L_ID AND L.List_Name = '" + comboBox1.SelectedItem + "'";

                SqlDataReader reader2 = cmdLoadGrid.ExecuteReader();


                List_ListView.Items.Clear();
                while (reader2.Read())
                {
                    ListViewItem lv = new ListViewItem(reader2[0].ToString());
                    lv.SubItems.Add(reader2[1].ToString());
                    lv.SubItems.Add(reader2[2].ToString());
                    lv.SubItems.Add(reader2[3].ToString());
                    lv.SubItems.Add(reader2[4].ToString());

                    List_ListView.Items.Add(lv);

                }

                reader2.Close();

            }
           
        }
    }
}
