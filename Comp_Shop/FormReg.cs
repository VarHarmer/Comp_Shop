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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }


    private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text.Length > 0)
            {
                if (textBoxPass.Text.Length > 0)
                {
                    if (textBoxPassCopy.Text.Length > 0)
                    {
                        Users user = new Users();
                        user.FirstName = textBoxFirstName.Text;
                        user.MiddleName = textBoxMiddleName.Text;
                        user.LastName = textBoxLastName.Text;
                        user.Login = textBoxLog.Text;
                        user.Password = textBoxPass.Text;
                        Program.shopdb.Users.Add(user);
                        Program.shopdb.SaveChanges();
                        try { }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        Close();
                        if (textBoxPass.Text == textBoxPassCopy.Text)
                        {
                            MessageBox.Show("Пользователь зарегистрирован");
                        }
                        else MessageBox.Show("Пароли не совподают");
                    }
                    else MessageBox.Show("Повторите пароль");
                }
                else MessageBox.Show("Укажите пароль");
            }
            else MessageBox.Show("Укажите логин");
        }
    }
}
