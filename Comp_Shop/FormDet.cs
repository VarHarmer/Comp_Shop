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
            foreach (ItemDet items in Program.shopdb.ItemDet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    items.Name, items.Desk,
                    items.Pres, items.Price
                });
                item.Tag = items;
                listViewItemsDet.Items.Add(item);
            }
        }

        private void listViewItemsDet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }
    }
}
