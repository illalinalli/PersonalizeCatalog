using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PersonalKabinet : Form
    {

        public PersonalKabinet()
        {
            InitializeComponent();
            object ID = LoginForm1.id;
            string query = "SELECT * FROM Users WHERE id=" + Convert.ToInt32(ID);
            SQLiteConnection conn = new SQLiteConnection("Data Source=MyDataBase.db;Version=3;");
            conn.Open();
            var cmd = new SQLiteCommand(query, conn);
            using (SQLiteDataReader dataReader = cmd.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    var NAME = dataReader["username"].ToString();
                    username_label.Text = NAME;
                }
            }
        }

        private void personalKab_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Оишбка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Show(string v)
        {
            throw new NotImplementedException();
        }

        private void PersonalKabinet_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void change_amount_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update = new Update();
            update.Show();
        }
    }
}
