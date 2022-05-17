using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            TextBox textBox = new TextBox();
            textBox.Dock = DockStyle.Fill;
            textBox.Multiline = true;
            tabPage.Controls.Add(textBox);
            tabPage.Text = "new";
            this.tabControl1.Controls.Add(tabPage);
            this.tabControl1.SelectedTab = tabPage;
        }
    }


}
