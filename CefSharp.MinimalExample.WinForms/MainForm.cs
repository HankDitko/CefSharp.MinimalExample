using System;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var browser = new BrowserForm();

            browser.Show(dockPanel1);
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var browser = new BrowserForm();

            browser.Show(dockPanel1);
        }
    }
}
