using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingPool
{
    public partial class MainWindow : Form
    {
        private Dictionary<string, Object> data;

        public MainWindow(Dictionary<string, Object> data) : this()
        {
            this.data = data;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //var account = (Member)data["username"];
            //welcomeToolStripMenuItem.Text = "Welcome " + account.MemberID;
            var userControlMember = new UserControlMemberList(); 
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlMember);
        }

        private void filterEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userControlEntryFilter = new UserControlEntryFilter();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlEntryFilter);
        }

        private void memberManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userControlMember = new UserControlMemberList();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlMember);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
