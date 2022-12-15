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
    public partial class Shema_Bashnya2 : Form
    {
        public Shema_Bashnya2()
        {
            InitializeComponent();
        }

        private void Sh_nazad_bashnya2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shema_Bashnya1 bashnya1 = new Shema_Bashnya1();
            bashnya1.Show();
        }

        private void Sh_next_bashnya2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shema_Bashnya3 bashnya3 = new Shema_Bashnya3();
            bashnya3.Show();
        }
    }
}
