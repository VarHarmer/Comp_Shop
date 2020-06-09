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
    public partial class FormComp : Form
    {
        public FormComp()
        {
            InitializeComponent();
            ShowItem();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ShowItem()
        {
            listViewItems.Items.Clear();
            foreach (Item items in Program.shopdb.Item)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    items.Name, items.Desk,
                    items.Pres, items.Price
                });
                item.Tag = items;
                listViewItems.Items.Add(item);
            }
        }
    }
}
