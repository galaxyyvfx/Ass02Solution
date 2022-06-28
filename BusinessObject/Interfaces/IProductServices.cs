using DataAccess.Models;

namespace BusinessObject.Interfaces;

public interface IProductServices
{
    public void AddProduct(Product product);
    public void UpdateProduct(Product product);
    public void DeleteProduct(Product product);
    public Product GetProduct(int id);
    public IEnumerable<Product> GetProductList();
    public IEnumerable<Product> GetProductByName(string name);
    public IEnumerable<Product> GetProductByPrice(int priceMin, int priceMax);
    public IEnumerable<Product> GetProductByStock(int stockMin, int stockMax);

}
