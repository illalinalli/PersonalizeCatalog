//using MySql.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp2
{
    public partial class CountDetails : Form
    {
        string login, pass;
        public CountDetails()
        {
            InitializeComponent();
            //Обрабатываем данные
            //Или записываем их в поле
            //this.login = login;
            //this.pass = pass;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //связываем окно с детальками с главным окном
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (ravnostronTriangle.Text.Trim() == "" && square.Text.Trim() == "" && ravnobedrTriangle.Text.Trim() == "" && pyatiygolnik.Text.Trim() == "" && trapetsia.Text.Trim() == "" && shestiygolnik.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                string query = "INSERT INTO Details (ravnostoronTriangle, square, ravnobedrTriangle, pyatiygolnik, trapetsia, shestiygolnik) VALUES (@ravnostoronTriangle, @square, @ravnobedrTriangle, @pyatiygolnik, @trapetsia, @shestiygolnik)";
                SQLiteConnection conn = new SQLiteConnection("Data Source=MyDataBase.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter dap = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                
                cmd.Parameters.AddWithValue("@ravnostoronTriangle", ravnostronTriangle.Text);
                cmd.Parameters.AddWithValue("@square", square.Text);

                cmd.Parameters.AddWithValue("@ravnobedrTriangle", ravnobedrTriangle.Text);
                cmd.Parameters.AddWithValue("@pyatiygolnik", pyatiygolnik.Text);

                cmd.Parameters.AddWithValue("@trapetsia", trapetsia.Text);
                cmd.Parameters.AddWithValue("@shestiygolnik", shestiygolnik.Text);

                dap.Fill(dt);
                MessageBox.Show("Пользователь зарегистрирован успешно.");
                this.Hide();
                LoginForm1 loginForm = new LoginForm1();
                loginForm.Show();
            }
        }

        private void ravnostronTriangle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void square_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
