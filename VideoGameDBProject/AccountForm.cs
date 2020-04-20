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
    public partial class AccountForm : Form
    {
        public SqlConnection DBConnection;
        public string email;

        public AccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            
            saveButton.Visible = false;
            deleteButton.Visible = false;
            SqlCommand cmdAccount = DBConnection.CreateCommand();
            cmdAccount.CommandText = "Select * from USERS Where Email = '" + email + "'";
            SqlDataReader reader = cmdAccount.ExecuteReader();

            if (reader.Read())
            {
                
                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                textBox4.Text = reader[3].ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
            reader.Close();

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void homeLabel_Click(object sender, EventArgs e)
        {
            MainForm objMain = new MainForm();
            this.Hide();
            objMain.DBConnection = DBConnection;
            objMain.email = email;
            objMain.ShowDialog();
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

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;
            saveButton.Visible = true;
            deleteButton.Visible = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox4.ReadOnly = false;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "Delete Account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand cmdDelete = DBConnection.CreateCommand();
                cmdDelete.CommandText = "Delete From USERS Where Email = @email";
                cmdDelete.Parameters.AddWithValue("@email", email);
                cmdDelete.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                

                SqlCommand cmdDeleteList = DBConnection.CreateCommand();
                cmdDeleteList.CommandText = "DELETE FROM LIST_ITEM WHERE LIST_ITEM.L_ID IN(SELECT LIST.List_ID FROM LIST WHERE LIST.User_Email = @email)";                
                cmdDeleteList.Parameters.AddWithValue("@email", email);
                cmdDeleteList.ExecuteNonQuery();

                cmdDeleteList.CommandText = "DELETE FROM LIST WHERE LIST.User_Email = @email1";                
                cmdDeleteList.Parameters.AddWithValue("@email1", email);
                cmdDeleteList.ExecuteNonQuery();

                MessageBox.Show("Account Deleted!");

                try
                {
                    LoginForm login = new LoginForm();            
                    this.Hide(); //hide form
                    login.ShowDialog(); //go to login form

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
                       
            SqlCommand cmdAddAccount = DBConnection.CreateCommand();
            cmdAddAccount.CommandText = "UPDATE USERS SET Fname = @fname, Lname = @lname, Password = @password " +
                                        "WHERE Email = @email"; 

            if (textBox1.Text.Trim().Length > 0 && textBox2.Text.Trim().Length > 0 && textBox4.Text.Trim().Length > 0)
            {

                //grab text values and update database
                cmdAddAccount.Parameters.AddWithValue("@fname", textBox1.Text.Trim());
                cmdAddAccount.Parameters.AddWithValue("@lname", textBox2.Text.Trim());
                cmdAddAccount.Parameters.AddWithValue("@email", email);
                cmdAddAccount.Parameters.AddWithValue("@password", textBox4.Text.Trim());

               
            }

            try
            {
                cmdAddAccount.ExecuteNonQuery();
                MessageBox.Show("Account Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            SqlCommand cmdAccount = DBConnection.CreateCommand();
            cmdAccount.CommandText = "Select * from USERS Where Email = @email1";
            cmdAccount.Parameters.AddWithValue("@email1", email);
            SqlDataReader reader = cmdAccount.ExecuteReader();

            if (reader.Read())
            {

                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                textBox4.Text = reader[3].ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
            reader.Close();

            //savebutton visibility, delete button visibility, textboxes as non editable
            editButton.Visible = true;
            saveButton.Visible = false;
            deleteButton.Visible = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide(); //hide from            
            login.ShowDialog(); //open login form
        }
    }
}
