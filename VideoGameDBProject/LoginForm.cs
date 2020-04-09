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
    public partial class LoginForm : Form
    {
        public LoginForm()
        { 
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { 

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {


            try
            {
                sqlConnection.Open();
                
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("The App cannot open the connection to the database");
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String Fname = "";
            String Lname = "";

            SqlCommand cmdLogin = sqlConnection.CreateCommand();
            cmdLogin.CommandText = "Select * from USERS Where Email = @email AND Password = @password";
            cmdLogin.Parameters.AddWithValue("@email", textEmail.Text.Trim());
            cmdLogin.Parameters.AddWithValue("@password", textPassword.Text.Trim());
            SqlDataReader reader = cmdLogin.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Welcome "+ reader[0].ToString() + " " + reader[1].ToString());
                Fname = reader[0].ToString();
                Lname = reader[1].ToString();
                MainForm objMain = new MainForm();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Email and/or Password");
            }
            reader.Close();
                       
            /*SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-G9RJF60;Initial Catalog=Video Game Database;Integrated Security=True");
            string query = "Select * from USERS Where Email = '" + textEmail.Text.Trim() + "' and Password = '" + textPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                MainForm objMain = new MainForm();
                this.Hide();
                objMain.Show();

            }
            else
            {

                MessageBox.Show("Check your Email and Password");
            }*/
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            this.Hide();
            frm.DBConnection = sqlConnection;
            frm.ShowDialog();
            
           
            

        }
    }
}
