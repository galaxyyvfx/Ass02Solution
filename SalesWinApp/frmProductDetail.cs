using BusinessObject;
using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmProductDetail : Form
{
    private IProductServices productServices = new ProductServices();

    public Product productInfo { get; set; }
    public bool IsUpdate { get; set; }
    private Product GetProductInfo()
    {
        Product product = new Product
        {
            ProductId = IsUpdate == true ? int.Parse(txtProductID.Text) : 0,
            ProductName = txtProductName.Text,
            Weight = txtWeight.Text,
            CategoryId = (int)numCategoryID.Value,
            UnitPrice = (int)numUnitPrice.Value,
            UnitsInStock = (int)numUnitsInStock.Value,
        };
        return product;
    }
    public frmProductDetail()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Product product = GetProductInfo();
        if (IsUpdate == true)
        {
            productServices.UpdateProduct(product);
        }
        else
        {
            productServices.AddProduct(product);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
