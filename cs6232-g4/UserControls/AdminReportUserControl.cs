using cs6232_g4.Controller;
using cs6232_g4.Model;
using System.Windows.Forms;

/// <summary>
/// 
/// 
/// </summary>
/// 
namespace cs6232_g4.UserControls
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class AdminReportUserControl : UserControl
    {
        private DateTime Start;
        private DateTime End;
        private DateTime Current;
        List<AdminReport> ReportData;
        private readonly AdminReportController _adminReportController;

        public AdminReportUserControl()
        {
            InitializeComponent();
            Start = DateTime.Now;
            End = DateTime.Now;
            Current = DateTime.Now;
            ReportData = new List<AdminReport>();
            _adminReportController = new AdminReportController();
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.StartDateTimePicker.Value.ToShortDateString()))
                {
                    this.StartDateErrorLabel.Text = "Please select a start date. ";
                }
                else
                {
                    this.Start = this.StartDateTimePicker.Value.Date;
                }
                if (!String.IsNullOrEmpty(this.EndDateTimePicker.Value.ToShortDateString()))
                {
                    this.EndDateErrorLabel.Text = "Please select a end date. ";
                }
                else
                {
                    this.End = this.EndDateTimePicker.Value.Date;
                }

                this.DisplayReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void DisplayReport()
        {
            this.ReportData = this._adminReportController.GetAdminReportData(this.Start, this.End);
            this.ReportDataGridView.DataSource = null;
            this.ReportDataGridView.DataSource = this.ReportData;
            this.InfoLabel.Text = "Data as of " + this.Current.ToString();
        }

        /// <summary>
        /// Clears the grid.
        /// </summary>
        public void ClearGrid()
        {
            this.ReportDataGridView.Columns.Clear();
        }
    }
}
