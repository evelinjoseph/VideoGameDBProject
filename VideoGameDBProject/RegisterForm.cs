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
    public partial class RegisterForm : Form
    {
        public SqlConnection DBConnection;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.Show(); 
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmdAddAccount = DBConnection.CreateCommand();
            cmdAddAccount.CommandText = "INSERT INTO USERS VALUES(@Fname ,@Lname, @email, @password)";

            if(txtFname.Text.Trim().Length > 0 && txtLname.Text.Trim().Length > 0 && txtEmail.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                
                cmdAddAccount.Parameters.AddWithValue("@Fname", txtFname.Text.Trim());
                cmdAddAccount.Parameters.AddWithValue("@Lname", txtLname.Text.Trim());
                cmdAddAccount.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmdAddAccount.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

            }
            

            try
            {

                cmdAddAccount.ExecuteNonQuery();
                MessageBox.Show("1 User has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

                
        }
    }
}
