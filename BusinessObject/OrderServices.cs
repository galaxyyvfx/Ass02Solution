using DataAccess.Models;

namespace BusinessObject.Interfaces;

public class OrderServices : IOrderServices
{
    public void AddOrder(Order order)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteOrder(Order order)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            var ord =
                dbContext.Orders
                .SingleOrDefault
                (o => o.OrderId == order.OrderId);
            dbContext.Orders.Remove(ord);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Order GetOrder(int id)
    {
        Order order = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            order = dbContext.Orders.Single(o => o.OrderId == id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return order;
    }

    public IEnumerable<object> GetOrder(DateTime startTime, DateTime endTime)
    {
        IEnumerable<Order> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.Orders
                    .Where(o => o.OrderDate >= startTime)
                    .Where(o => o.OrderDate <= endTime)
                    .ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public IEnumerable<Order> GetOrderList()
    {
        IEnumerable<Order> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.Orders.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public void UpdateOrder(Order order)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.Entry<Order>(order).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
