using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioShop2._0
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();

            FormClosed += Shop_FormClosed;

            int x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            this.MaximumSize = new System.Drawing.Size(x, y);
            this.MinimumSize = new System.Drawing.Size(x, y);

            SortPanel.Visible = false;
            searchGroupe.Width = toppanel.Width / 2;
        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Shop_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void SarchLine_Enter(object sender, EventArgs e)
        {
            SearchLine.Text = string.Empty;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            if (SortPanel.Visible == false)
            {
                SortPanel.Visible = true;
            }
            else
            {
                SortPanel.Visible = false;
            }
        }
    }
}

