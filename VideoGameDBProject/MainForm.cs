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
    public partial class MainForm : Form
    {
        public SqlConnection DBConnection;
        public string email;        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmdLoadVideoGames = DBConnection.CreateCommand();
            cmdLoadVideoGames.CommandText = "SELECT VG.Title, VG.ReleaseDate, VG.Genre, D.Developer_Name, P.Publisher_Name FROM VIDEO_GAME AS VG, PUBLISHER AS P, DEVELOPER AS D WHERE VG.Dev_id = D.Developer_ID AND VG.Pub_id = P.Publisher_ID";
            
            SqlDataReader reader2 = cmdLoadVideoGames.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader2);

            dataGridView1.DataSource = table;

            reader2.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccountForm accForm = new AccountForm();
            this.Hide();
            accForm.DBConnection = DBConnection;
            accForm.email = email;
            accForm.Show();
        }
    }
}
