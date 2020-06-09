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
    public partial class FormDet : Form
    {
        public FormDet()
        {
            InitializeComponent();
            ShowItem();
        }

        void ShowItem()
        {
            listViewItemsDet.Items.Clear();
            foreach (ItemDet itemsDet in Program.shopdb.ItemDet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    itemsDet.Name, itemsDet.Desk,
                    itemsDet.Pres, itemsDet.Price
                });
                item.Tag = itemsDet;
                listViewItemsDet.Items.Add(item);
            }
        }

        private void listViewItemsDet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за заказ! Вам скоро перезвонят для уточнения деталей.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
