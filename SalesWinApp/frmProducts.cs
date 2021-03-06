using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmProducts : Form
{
    private BindingSource source;
    public frmProducts()
    {
        InitializeComponent();
    }

    private void LoadProductList(IEnumerable<Product> list)
    {
        try
        {
            source = new BindingSource();
            source.DataSource = list;

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = source;

            if (list.Count() > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private Product GetCurrentProduct()
    {
        Product product = null;
        try
        {
            product = dgvProducts.CurrentRow.DataBoundItem as Product;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get product");
        }
        return product;
    }
    private void frmProducts_Load(object sender, EventArgs e)
    {
        IProductServices productServices = new ProductServices();
        var list = productServices.GetProductList();
        LoadProductList(list);
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtProductID.Text))
        {
            try
            {
                IProductServices productServices = new ProductServices();
                Product searchProduct = productServices.GetProduct(
                    int.Parse(txtProductID.Text));
                LoadProductList(new[] { searchProduct });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search by ID");
            }
        }
        else
        {
            try
            {
                IProductServices productServices = new ProductServices();
                int minPrice = (int)numUnitPriceMin.Value;
                int maxPrice = (int)numUnitPriceMax.Value;

                int minStock = (int)numUnitsInStockMin.Value;
                int maxStock = (int)numUnitsInStockMax.Value;

                var searchNames = productServices.GetProductByName(txtProductName.Text);
                var searchPrice = productServices.GetProductByPrice(minPrice, maxPrice);
                var searchStock = productServices.GetProductByStock(minStock, maxStock);
                var resultSet = from names in searchNames
                                join prices in searchPrice
                                    on names.ProductId equals prices.ProductId
                                join stock in searchStock
                                    on names.ProductId equals stock.ProductId
                                select new Product
                                {
                                    ProductId = names.ProductId,
                                    ProductName = names.ProductName,
                                    UnitPrice = names.UnitPrice,
                                    CategoryId = names.CategoryId,
                                    UnitsInStock = names.UnitsInStock,
                                    Weight = names.Weight,
                                };
                LoadProductList(resultSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error");
            }
        }
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
        frmProductDetail frmProductDetail = new frmProductDetail
        {
            Text = "Add Product",
            IsUpdate = false,
        };
        frmProductDetail.ShowDialog();
        if (frmProductDetail.DialogResult == DialogResult.OK)
        {
            IProductServices productServices = new ProductServices();
            var list = productServices.GetProductList();
            LoadProductList(list);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        frmProductDetail frmProductDetail = new frmProductDetail
        {
            Text = "Update Product",
            IsUpdate = true,
            productInfo = GetCurrentProduct(),
        };
        frmProductDetail.ShowDialog();
        if (frmProductDetail.DialogResult == DialogResult.OK)
        {
            IProductServices productServices = new ProductServices();
            var list = productServices.GetProductList();
            LoadProductList(list);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            IProductServices productServices = new ProductServices();
            Product product = GetCurrentProduct();
            productServices.DeleteProduct(product);

            var list = productServices.GetProductList();
            LoadProductList(list);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Delete member");
        }
    }
}
