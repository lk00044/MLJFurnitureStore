using cs6232_g4.Controller;
using cs6232_g4.Model;

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
           // Start = DateTime.Now;
           // End = DateTime.Now;
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
                this.Start = this.StartDateTimePicker.Value.Date;
                this.End = this.EndDateTimePicker.Value.Date;              

                this.DisplayReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void DisplayReport()
        {
            this.ReportDataGridView.DataSource = null;
            this.ReportData = this._adminReportController.GetAdminReportData(this.Start, this.End);
            this.ReportDataGridView.DataSource = this.ReportData;
            this.InfoLabel.ForeColor = Color.Black;
            this.InfoLabel.Text = "Report as of " + this.Current.ToString();
        }

        /// <summary>
        /// Clears the grid.
        /// </summary>
        public void ClearGrid()
        {
            this.ReportDataGridView.Columns.Clear();
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.Start = this.StartDateTimePicker.Value.Date;
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.End = this.EndDateTimePicker.Value.Date;
        }
    }
}
