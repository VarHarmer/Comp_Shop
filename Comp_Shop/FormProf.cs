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
    public partial class FormProf : Form
    {
        public FormProf()
        {
            InitializeComponent();
        }
        Users user = new Users();

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            user.FirstName = textBoxFirstName.Text;
            user.MiddleName = textBoxMiddleName.Text;
            user.LastName = textBoxLastName.Text;
            user.Login = textBoxLog.Text;
            user.Password = textBoxPass.Text;
            Program.shopdb.Users.Add(user);
            Program.shopdb.SaveChanges();
            bool key = false;
            key = true;
            if (!key)
            {

            }
            else
            {
                MessageBox.Show("Данные изменены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormProf_Load(object sender, EventArgs e)
        {
            textBoxLog.Text = FormLog.users.login;
            textBoxPass.Text = FormLog.users.password;
            textBoxFirstName.Text = FormLog.users.FirstName;
            textBoxLastName.Text = FormLog.users.LastName;
            textBoxMiddleName.Text = FormLog.users.MiddleName;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
