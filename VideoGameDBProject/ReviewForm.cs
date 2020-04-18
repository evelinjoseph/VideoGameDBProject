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
    public partial class ReviewForm : Form
    {
        
        public SqlConnection DBConnection;
        public string email;

        public ReviewForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void listLabel_Click(object sender, EventArgs e)
        {
            ListForm lForm = new ListForm();
            this.Hide();
            lForm.DBConnection = DBConnection;
            lForm.email = email;
            lForm.ShowDialog();
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

        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reviewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reviewCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {

            
            SqlCommand cmdLoadVG = DBConnection.CreateCommand();
            cmdLoadVG.CommandText = "SELECT DISTINCT VG.Title FROM VIDEO_GAME AS VG, REVIEW as R WHERE VG.VideoGame_id = R.Game_ID";
            SqlDataReader reader = cmdLoadVG.ExecuteReader();

            while (reader.Read())
            {
                reviewCB.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
    }
}
