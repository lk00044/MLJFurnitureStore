using cs6232_g4.Controller;
using cs6232_g4.Model;

/// <summary>
/// Handles the view for the view tab
/// Programmer: Leslie
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
            //Start = DateTime.Now;
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

        /// <summary>
        /// Displays the report.
        /// </summary>
        private void DisplayReport()
        {

            this.ReportDataGridView.DataSource = null;
            this.ReportData = this._adminReportController.GetAdminReportData(this.Start, this.End);
            this.ReportDataGridView.DataSource = this.ReportData;
            this.SetUpGrid();
            this.InfoLabel.ForeColor = Color.Black;
            this.InfoLabel.Text = "Report as of " + this.Current.ToString() + "\nfor period " + this.Start.ToShortDateString() + " to " + this.End.ToShortDateString();
        }

        /// <summary>
        /// Sets up grid headers.
        /// </summary>
        private void SetUpGrid()
        {
            this.ReportDataGridView.AutoGenerateColumns = false;
            this.ReportDataGridView.AutoSize = true;
            this.ReportDataGridView.Columns[0].HeaderText = "Furniture ID";
            this.ReportDataGridView.Columns[1].HeaderText = "Furniture Name";
            this.ReportDataGridView.Columns[2].HeaderText = "Category";
            this.ReportDataGridView.Columns[3].HeaderText = "Total Qualifying ";
            this.ReportDataGridView.Columns[4].HeaderText = "Total Transactions";
            this.ReportDataGridView.Columns[5].HeaderText = "Pct. Qualifying";
            this.ReportDataGridView.Columns[6].HeaderText = "Pct. Qualifying Ages 18 - 29";
            this.ReportDataGridView.Columns[7].HeaderText = "Pct. Qualifying Ages Over 29 ";
        }


        /// <summary>
        /// Handles the ValueChanged event of the StartDateTimePicker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.Start = this.StartDateTimePicker.Value.Date;
        }


        /// <summary>
        /// Handles the ValueChanged event of the EndDateTimePicker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.End = this.EndDateTimePicker.Value.Date;
        }
    }
}
