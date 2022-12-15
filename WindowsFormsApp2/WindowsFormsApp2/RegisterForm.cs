using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
       
        public RegisterForm()
        {
            
            InitializeComponent();
            

            userNameField.Text = "Введите имя и фамилию";
            userNameField.ForeColor = Color.Gray;

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;

            repeatPasswordField.Text = "Повторите пароль";
            repeatPasswordField.ForeColor = Color.Gray;

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введите имя и фамилию")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
           
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя и фамилию";

                userNameField.ForeColor = Color.Gray;
            }
        }

      

        private void buttonRegister_Click(object sender, EventArgs e)//связываем с окном CountDetails
        {
            if (userNameField.Text.Trim() == "" && loginField.Text.Trim() == "" && passField.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                string query = "INSERT INTO Users (username, login, password) VALUES (@username, @login, @password)";
                SQLiteConnection conn = new SQLiteConnection("Data Source=MyDataBase.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                if (passField.Text == repeatPasswordField.Text)
                {
                    cmd.Parameters.AddWithValue("@username", userNameField.Text);
                    cmd.Parameters.AddWithValue("@login", loginField.Text);
                    cmd.Parameters.AddWithValue("@password", passField.Text);
                }
                da.Fill(dt);
                this.Hide();
                CountDetails countDetails = new CountDetails();
                countDetails.Show();
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {

        }
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            { 
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
                
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void repeatPasswordField_Enter(object sender, EventArgs e)
        {
            if (repeatPasswordField.Text == "Повторите пароль")
            {
                repeatPasswordField.Text = "";
                repeatPasswordField.ForeColor = Color.Black;
            }
        }

        private void repeatPasswordField_Leave(object sender, EventArgs e)
        {
            if (repeatPasswordField.Text == "")
            {
                repeatPasswordField.Text = "Повторите пароль";
                repeatPasswordField.ForeColor = Color.Gray;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Avtorizatia_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 loginForm = new LoginForm1();
            loginForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void listUsersListBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
