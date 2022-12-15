using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            
            //this.pass = pass;
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bashya_Click(object sender, EventArgs e)
        {
            //  User u = new User();
            //  var id = u.GetId.Pop();//удаляем текущий id пользователя и присваиваем его переменной
            //соединение с таблицей Details
            //SELECT * FROM Users WHERE login=@login AND password=@password
            //SELECT ravnostoronTriangle=@ravnostoronTriangle FROM Details WHERE id_user=@id_user


            //SELECT ravnostoronTriangle FROM Details работает
            //ПРОДУМАТЬ, КАК МНЕ ОБРАЩАТЬСЯ К ОДНОЙ СТРОКЕ ГДЕ АЙДИ = ТЕКУЩЕМУ АЙДИ, ТО ЕСТЬ ВХОД У ПОЛЬЗОВАТЕЛЯ
            object ID = LoginForm1.id;
            //int id = Convert.ToInt32(ID);
            string query = "SELECT * FROM Details WHERE id_user="+Convert.ToInt32(ID);
            SQLiteConnection conn = new SQLiteConnection("Data Source=MyDataBase.db;Version=3;");
            conn.Open();
            var cmd = new SQLiteCommand(query, conn);
            using (SQLiteDataReader dataReader = cmd.ExecuteReader())
            {
                if (dataReader.Read()) // если есть данные
                {
                    var ravnostoronTriangle_count = dataReader["ravnostoronTriangle"].ToString();
                    var square_count = dataReader["square"].ToString();
                    if (int.Parse(ravnostoronTriangle_count) >= 3 && int.Parse(square_count) >= 6)
                    {
                        //MessageBox.Show("Вы можете собрать эту фигуру");
                        this.Hide(); //кароч осуществляем перезод к сборке смехы ЙОУ
                        Shema_Bashnya1 bashnya1 = new Shema_Bashnya1();
                        bashnya1.Show();
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно деталей.");
                    }
                }
            }
               
            // var ravnostoronTriangle = dataReader.GetInt32(1);
            //if (id == id_user)
            //{
            //    object ravnostoronTriangle = cmd.ExecuteScalar();
            //    object square = cmd.ExecuteScalar();

            //if ((int)ravnostoronTriangle >= 3)
            //{
            //    MessageBox.Show("Вы можете собрать эту фигуру");
            //}
            //else
            //{
            //    MessageBox.Show("Вы не можете собрать эту фигуру");
            //}
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalKabinet kabinet = new PersonalKabinet();
            kabinet.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        //object id_user = cmd.ExecuteScalar();

    }
}

