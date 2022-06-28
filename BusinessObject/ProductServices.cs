using DataAccess.Models;

namespace BusinessObject.Interfaces;

public class ProductServices : IProductServices
{
    public void AddProduct(Product product)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteProduct(Product product)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            var prod =
                dbContext.Products
                .SingleOrDefault
                (c => c.ProductId == product.ProductId);
            dbContext.Products.Remove(prod);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Product GetProduct(int id)
    {
        Product product = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            product = dbContext.Products.Single(p => p.ProductId == id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return product;
    }

    public IEnumerable<Product> GetProductByName(string name)
    {
        IEnumerable<Product> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.Products
                    .Where(p => p.ProductName.Contains(name))
                    .ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public IEnumerable<Product> GetProductByPrice(int priceMin, int priceMax)
    {
        IEnumerable<Product> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.Products
                    .Where(p => p.UnitPrice >= priceMin)
                    .Where(p => p.UnitPrice <= priceMax)
                    .ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public IEnumerable<Product> GetProductByStock(int stockMin, int stockMax)
    {
        IEnumerable<Product> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.Products
                    .Where(p => p.UnitsInStock >= stockMin)
                    .Where(p => p.UnitsInStock <= stockMax)
                    .ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public IEnumerable<Product> GetProductList()
    {
        IEnumerable<Product> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.Products.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public void UpdateProduct(Product product)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.Entry<Product>(product).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
