using DataAccess.Models;

namespace BusinessObject.Interfaces;

public interface IOrderServices
{
    public void AddOrder(Order order);
    public void UpdateOrder(Order order);
    public void DeleteOrder(Order order);
    public IEnumerable<Order> GetOrderList();
    public Order GetOrder(int id);
    public IEnumerable<Order> GetOrder(DateTime startTime, DateTime endTime);
    public IEnumerable<Order> GetOrderListByMemberID(int id);
}
