using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OasisApplication_v1._0
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewClient Click = new NewClient();
            Click.Show();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NeedsAssessment Click = new NeedsAssessment();
            Click.Show();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Services Click = new Services();
            Click.Show();
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reports Click = new Reports();
            Click.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            OasisDashboard Click = new OasisDashboard();
            Click.Show();
        }
    }
}
