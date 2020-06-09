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
    public partial class FormPer : Form
    {
        public FormPer()
        {
            InitializeComponent();
            ShowItem();
        }

        private void listViewItemsPer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ShowItem()
        {
            listViewItemsPer.Items.Clear();
            foreach (ItemPer items in Program.shopdb.ItemPer)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    items.Name, items.Desk,
                    items.Pres, items.Price
                });
                item.Tag = items;
                listViewItemsPer.Items.Add(item);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за заказ! Вам скоро перезвонят для уточнения деталей.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
