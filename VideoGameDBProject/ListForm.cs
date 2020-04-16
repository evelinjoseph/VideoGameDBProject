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

            cmdLoadGrid.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre FROM VIDEO_GAME AS VG, LIST AS L, LIST_ITEM AS LI WHERE VG.VideoGame_id = LI.V_ID AND L.List_ID = LI.L_ID AND L.List_Name = '" + comboBox1.SelectedItem + "'";

            SqlDataReader reader2 = cmdLoadGrid.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader2);

            listGrid.DataSource = table;

            reader2.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            SqlCommand cmdLoadGrid = DBConnection.CreateCommand();

            cmdLoadGrid.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre FROM VIDEO_GAME AS VG, LIST AS L, LIST_ITEM AS LI WHERE VG.VideoGame_id = LI.V_ID AND L.List_ID = LI.L_ID AND L.List_Name = '" + comboBox1.SelectedItem + "'";

            SqlDataReader reader2 = cmdLoadGrid.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader2);

            listGrid.DataSource = table;

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
            pForm.Show();
        }

        private void reviewLabel_Click(object sender, EventArgs e)
        {
            ReviewForm rForm = new ReviewForm();
            this.Hide();
            rForm.DBConnection = DBConnection;
            rForm.email = email;
            rForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccountForm accForm = new AccountForm();
            this.Hide();
            accForm.DBConnection = DBConnection;
            accForm.email = email;
            accForm.Show();
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
            objMain.Show();
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
