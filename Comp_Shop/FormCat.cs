using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Shop
{
    public partial class FormCat : Form
    {
        public FormCat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form formComp = new FormComp();
            formComp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form formDet = new FormDet();
            formDet.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form formPer = new FormPer();
            formPer.Show();
        }
    }
}
