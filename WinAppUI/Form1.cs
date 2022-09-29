using DelegateDemoLibrary;
using System.Security.Policy;

namespace WinAppUI
{
    public partial class Form1 : Form
    {
        StockModule2 stockModule2 = new StockModule2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModel product = new ProductModel();
            product.Name = txtName.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
            stockModule2.Items.Add(product);

            dgvShow.DataSource = null;
            dgvShow.DataSource = stockModule2.Items;

        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal afterdisc = stockModule2.TotalCalc(NoofItem, AfterDiscoutTotal);
            txtTotal.Text = afterdisc.ToString();
        }
        public  void NoofItem(List<ProductModel> productModels)
        {
            int NoofItem = productModels.Count();
            txtCount.Text = NoofItem.ToString();
        }
        public  decimal AfterDiscoutTotal(decimal Total)
        {
            if (Total > 250)
                return Total * 0.80M;
            else if (Total > 200)
                return Total * 0.85M;
            else if (Total > 100)
                return Total * 0.90M;
            return Total;
        }

        
    }
}