using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Shop
{
    public struct User
    {
        public string login;
        public string password;
        public string type;
        public string FirstName;
        public string LastName;
        public string MiddleName;
    }
    public partial class FormLog : Form
    {
        public static User users = new User();
        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "" && textBoxPass.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.shopdb.Users)
                {
                    if (textBoxLog.Text == user.Login && textBoxPass.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                        users.FirstName = user.FirstName;
                        users.LastName = user.LastName;
                        users.MiddleName = user.MiddleName;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLog.Text = "";
                    textBoxPass.Text = "";
                }

                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
        }
    }
}
