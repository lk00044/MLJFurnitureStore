/// <summary>
/// Small form for navigation
/// Programmer: Leslie
/// </summary>
namespace cs6232_g4.View
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  closes form
        /// </summary>
        private void CloseBbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
