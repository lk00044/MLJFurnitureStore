using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logon
{
    public partial class DashboardForm : Form
    {

        string userName;
        string userID;

        public DashboardForm(string userID, string emplName)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = emplName;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.DisplayNameLabel.Text = this.userName;
            this.DisplayUserIDLabel.Text = this.userID;
        }
    }
}
