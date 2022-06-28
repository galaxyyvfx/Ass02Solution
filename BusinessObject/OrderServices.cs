using DataAccess.Models;

namespace BusinessObject.Interfaces;

public class OrderServices : IOrderServices
{
    public void AddOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public void DeleteOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Order GetOrder(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<object> GetOrder(DateTime startTime, DateTime endTime)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetOrderList()
    {
        throw new NotImplementedException();
    }

    public void UpdateOrder(Order order)
    {
        throw new NotImplementedException();
    }
}
