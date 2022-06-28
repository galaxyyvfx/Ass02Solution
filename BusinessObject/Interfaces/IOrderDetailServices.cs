using DataAccess.Models;

namespace BusinessObject.Interfaces;

public interface IOrderDetailServices
{
    public void AddOrderDetail(OrderDetail orderDetail);
    public void UpdateOrderDetail(OrderDetail orderDetail);
    public void DeleteOrderDetail(OrderDetail orderDetail);
    public OrderDetail GetOrderDetail(int productId, int orderId);
    public IEnumerable<OrderDetail> GetOrderDetailList();
    public IEnumerable<OrderDetail> GetOrderDetailFromOrderId(int id);
    public decimal GetTotalPriceFromOrderId(int id);
}
