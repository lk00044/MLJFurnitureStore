using Furnitures.Model;
using Members.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs6232_g4.UserControls
{
    public partial class RentFurnitureUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        private readonly TransactionController _transactionController;
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this._transactionController = new TransactionController();
        }
        private void RentFurnitureUserControl_Load(object sender, EventArgs e)
        {
            this.PopulateAvailableFurniture();
           
        }
        private void PopulateAvailableFurniture()
        {
            List<Furniture> furnitureList = new List<Furniture>();
            furnitureList = this._furnitureController.GetAllFurniture();
            this.availableFurnitureGridView.DataSource = furnitureList;
        }

    }
}
