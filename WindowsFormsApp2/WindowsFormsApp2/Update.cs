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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (ravnostoronTriangle.Text.Trim() == "" && square.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                using (var conn = new SQLiteConnection("Data Source=MyDataBase.db;Version=3;"))
                {
                    conn.Open();
                    object ID = LoginForm1.id;
                    string query = "UPDATE Details SET ravnostoronTriangle="+Convert.ToInt32(ravnostoronTriangle.Text)+
                        ", square="+ Convert.ToInt32(square.Text) + ", ravnobedrTriangle="+ Convert.ToInt32(ravnobedrTriangle.Text) + 
                        ", pyatiygolnik="+ Convert.ToInt32(pyatiygolnik.Text) + ", trapetsia="+ Convert.ToInt32(trapetsia.Text) + 
                        ", shestiygolnik="+ Convert.ToInt32(shestiygolnik.Text) + " WHERE id_user=" + Convert.ToInt32(ID);
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void ravnostronTriangle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
