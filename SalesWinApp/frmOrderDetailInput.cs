using BusinessObject;
using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmOrderDetailInput : Form
{
    private IOrderDetailServices orderDetailServices = new OrderDetailServices();

    public OrderDetail orderDetailInfo { get; set; }
    public bool IsUpdate { get; set; }
    private OrderDetail GetOrderDetailInfo()
    {
        OrderDetail orderDetail = new OrderDetail
        {
            OrderId = IsUpdate == true ? (int)numOrderID.Value : 0,
            ProductId = IsUpdate == true ? (int)numProductID.Value : 0,
            Quantity = (int)numQuantity.Value,
            UnitPrice = numUnitPrice.Value,
            Discount = (float)numDiscount.Value,
        };
        return orderDetail;
    }
    public frmOrderDetailInput()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        OrderDetail orderDetail = GetOrderDetailInfo();
        if (IsUpdate == true)
        {
            orderDetailServices.UpdateOrderDetail(orderDetail);
        }
        else
        {
            orderServices.AddOrder(order);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
