/// <summary>
/// Dashboard for the Rent Me Furniture Co.
/// Author:         Leslie Keller
/// Modified by:    Jonathan
/// Modification:   Added MainDBTabControl_SelectedIndexChanged 
///                 to handle reseting data for registration form
/// Modified by:    Leslie
/// Modified Date:  27 Mar 2024
/// Modification:   Updated to show name and id on form
///                 Updated to add logout link
/// </summary>

namespace cs6232_g4
{
    public partial class DashboardForm : Form
    {
        string userID;
        string userName;

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardForm"/> class.
        /// </summary>
        /// <param name="userID">The user identifier.</param>
        /// <param name="userName">Name of the user.</param>
        public DashboardForm(string userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the DashboardForm control to set the name and user id
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.DisplayUserNameLabel.Text = userID;
            this.DisplayNameLabel.Text = userName;
        }

        /// <summary>
        /// tabs changing event handler
        /// </summary>
        private void MainDBTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MainDBTabControl.SelectedIndex == 0)
            {
                this.memberRegistrationUserControl.ResetFields();
                this.memberRegistrationUserControl.ClearAllErrors();
            }
            if(this.MainDBTabControl.SelectedIndex == 1)
            {
                this.search4Member.ClearTextBoxes();
                this.search4Member.ClearGrid();
            }
            if (this.MainDBTabControl.SelectedIndex == 2)
            {
                this.rentFurnitureUserControl.ResetFields();
            }
        }

        /// <summary>
        /// Handles the LinkClicked event of the LogOutLinkLabel control to close the application
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
