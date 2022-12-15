using MySql.Data.MySqlClient;
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
    public partial class LoginForm1 : Form
    {
        public static object id;

        public LoginForm1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text.Trim() == "" && passField.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                string query = "SELECT * FROM Users WHERE login=@login AND password=@password";
                SQLiteConnection conn = new SQLiteConnection("Data Source=MyDataBase.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", loginField.Text);
                cmd.Parameters.AddWithValue("@password", passField.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = cmd.ExecuteScalar();
                MainForm mainForm = new MainForm();
                if (dt.Rows.Count > 0)
                {
                    this.Hide();  
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Error");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void LoginForm1_Load(object sender, EventArgs e)
        {
           
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegisterLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void RegisterLable_Click(object sender, EventArgs e)
        {
            this.Hide();//прячем окно авторизации
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();//переходим в другое окно(окно регистрации)
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
