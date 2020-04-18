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
    public partial class PriceForm : Form
    {

        public SqlConnection DBConnection;
        public string email;

        public PriceForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmdLoadVG = DBConnection.CreateCommand();
            cmdLoadVG.CommandText = "SELECT DISTINCT VG.Title FROM VIDEO_GAME AS VG, PRICE as P WHERE VG.VideoGame_id = P.VG_ID";
            SqlDataReader reader = cmdLoadVG.ExecuteReader();

            while (reader.Read())
            {
                priceCB.Items.Add(reader[0].ToString());
            }
            reader.Close();

            priceCB.SelectedIndex = 0;

            SqlCommand cmdLoadPrice = DBConnection.CreateCommand();


            cmdLoadPrice.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, P.Store_Name, P.Price FROM VIDEO_GAME AS VG, PRICE AS P WHERE VG.VideoGame_id = P.VG_ID AND VG.Title = '" + priceCB.SelectedItem + "'";



            SqlDataReader reader2 = cmdLoadPrice.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader2);

            priceGrid.DataSource = table;

            reader2.Close();

        }

        private void priceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void priceCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmdLoadPrice = DBConnection.CreateCommand();

           
           cmdLoadPrice.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, P.Store_Name, P.Price FROM VIDEO_GAME AS VG, PRICE AS P WHERE VG.VideoGame_id = P.VG_ID AND VG.Title = '" + priceCB.SelectedItem + "'";
                   


            SqlDataReader reader2 = cmdLoadPrice.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader2);

            priceGrid.DataSource = table;

            reader2.Close();

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void listLabel_Click(object sender, EventArgs e)
        {

            ListForm lForm = new ListForm();
            this.Hide();
            lForm.DBConnection = DBConnection;
            lForm.email = email;
            lForm.ShowDialog();

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

        private void homeLabel_Click(object sender, EventArgs e)
        {
            MainForm objMain = new MainForm();
            this.Hide();
            objMain.DBConnection = DBConnection;
            objMain.email = email;
            objMain.ShowDialog();
        }

        private void PriceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void priceLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
