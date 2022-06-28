using DataAccess.Models;

namespace BusinessObject.Interfaces;

public class OrderDetailServices : IOrderDetailServices
{
    public void AddOrderDetail(OrderDetail orderDetail)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.OrderDetails.Add(orderDetail);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteOrderDetail(OrderDetail orderDetail)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            var od =
                dbContext.OrderDetails
                .SingleOrDefault
                (c => c.OrderId == orderDetail.OrderId 
                && c.ProductId == orderDetail.ProductId);
            dbContext.OrderDetails.Remove(od);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public OrderDetail GetOrderDetail(int productId, int orderId)
    {
        OrderDetail orderDetail = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            orderDetail = dbContext.OrderDetails
                .Single(c => c.OrderId == orderDetail.OrderId
                && c.ProductId == orderDetail.ProductId);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return orderDetail;
    }

    public IEnumerable<OrderDetail> GetOrderDetailFromOrderId(int id)
    {
        IEnumerable<OrderDetail> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.OrderDetails
                .Where(o => o.OrderId == id)
                .ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public IEnumerable<OrderDetail> GetOrderDetailList()
    {
        IEnumerable<OrderDetail> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.OrderDetails
                .ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public decimal GetTotalPriceFromOrderId(int id)
    {
        decimal result = 0;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            result = (decimal)dbContext.OrderDetails
                .Where(o => o.OrderId == id)
                .Sum(p => p.Quantity * p.UnitPrice);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }

    public void UpdateOrderDetail(OrderDetail orderDetail)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.Entry<OrderDetail>(orderDetail).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
