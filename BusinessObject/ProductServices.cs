using DataAccess.Models;

namespace BusinessObject.Interfaces;

public class ProductServices : IProductServices
{
    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public Product GetProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductByName(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductByPrice(int priceMin, int priceMax)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductByStock(int stockMin, int stockMax)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductList()
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}
