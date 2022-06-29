using BusinessObject;
using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmOrderInput : Form
{
    private IOrderServices orderServices = new OrderServices();

    public Order orderInfo { get; set; }
    public bool IsUpdate { get; set; }
    private Order GetOrderInfo()
    {
        Order order = new Order
        {
            OrderId = IsUpdate==true? (int)numOrderID.Value : 0,
            MemberId = (int)numMemberID.Value,
            Freight = (int)numFreight.Value,
            OrderDate = dtpOrderDate.Value,
            RequiredDate = dtpRequiredDate.Value,
            ShippedDate = dtpShippedDate.Value,
        };
        return order;
    }
    public frmOrderInput()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Order order = GetOrderInfo();
        if (IsUpdate == true)
        {
            orderServices.UpdateOrder(order);
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
