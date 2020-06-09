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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            labelHello.Text = "Добро пожаловать " + FormLog.users.login + "!";
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Form formCat = new FormCat();
            formCat.Show();
        }

        private void buttonProf_Click(object sender, EventArgs e)
        {
            Form formProf = new FormProf();
            formProf.Show();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Form formLog = new FormLog();
            formLog.Show();
            this.Hide();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Form formReg = new FormReg();
            formReg.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

    }
}
