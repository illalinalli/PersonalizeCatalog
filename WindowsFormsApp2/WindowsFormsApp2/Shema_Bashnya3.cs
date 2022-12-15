using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Shema_Bashnya3 : Form
    {
        public Shema_Bashnya3()
        {
            InitializeComponent();
        }

        private void Sh_next_bashnya3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Фигура собрана успешно.");
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Sh_nazad_bashnya3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shema_Bashnya2 bashnya2 = new Shema_Bashnya2();
            bashnya2.Show();
        }
    }
}
