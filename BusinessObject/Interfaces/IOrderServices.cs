using DataAccess.Models;

namespace BusinessObject.Interfaces;

public interface IOrderServices
{
    public void AddOrder(Order order);
    public void UpdateOrder(Order order);
    public void DeleteOrder(Order order);
    public IEnumerable<Order> GetOrderList();
    public Order GetOrder(int id);
    public IEnumerable<object> GetOrder(DateTime startTime, DateTime endTime);
}
