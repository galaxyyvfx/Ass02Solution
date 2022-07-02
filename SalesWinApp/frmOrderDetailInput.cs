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
        OrderDetail orderDetail = null;
        try
        {
            orderDetail = new OrderDetail
            {
                OrderId = (int)numOrderID.Value,
                ProductId = (int)numProductID.Value,
                Quantity = (int)numQuantity.Value,
                UnitPrice = numUnitPrice.Value,
                Discount = (float)numDiscount.Value,
            };
            
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, this.Text);
        }
        return orderDetail;
    }
    public frmOrderDetailInput()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            OrderDetail orderDetail = GetOrderDetailInfo();
            if (IsUpdate == true)
            {
                orderDetailServices.UpdateOrderDetail(orderDetail);
            }
            else
            {
                orderDetailServices.AddOrderDetail(orderDetail);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, this.Text);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmOrderDetailInput_Load(object sender, EventArgs e)
    {
        try
        {
            if (IsUpdate == true)
            {
                numOrderID.Enabled = false;
                numProductID.Enabled = false;
                numOrderID.Value = (decimal)orderDetailInfo.OrderId;
                numProductID.Value = (decimal)orderDetailInfo.ProductId;
                numUnitPrice.Value = (decimal)orderDetailInfo.UnitPrice;
                numQuantity.Value = (decimal)orderDetailInfo.Quantity;
                numDiscount.Value = (decimal)orderDetailInfo.Discount;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Load OrderDetail Input");
        }
    }
}
