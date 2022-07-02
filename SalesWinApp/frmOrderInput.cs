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
        Order order = null;
        try
        {
            order = new Order
            {
                OrderId = IsUpdate == true ? (int)numOrderID.Value : 0,
                MemberId = (int)numMemberID.Value,
                Freight = (int)numFreight.Value,
                OrderDate = dtpOrderDate.Value,
                RequiredDate = dtpRequiredDate.Value,
                ShippedDate = dtpShippedDate.Value,
            };
            return order;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get Order");
        }
        return order;
    }
    public frmOrderInput()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Order order = GetOrderInfo();
        try
        {
            if (IsUpdate == true)
            {
                orderServices.UpdateOrder(order);
            }
            else
            {
                orderServices.AddOrder(order);
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

    private void frmOrderInput_Load(object sender, EventArgs e)
    {
        try
        {
            if (IsUpdate == true)
            {
                numOrderID.Value = orderInfo.OrderId;
                numMemberID.Value = (decimal)orderInfo.MemberId;
                dtpOrderDate.Value = (DateTime)orderInfo.OrderDate;
                dtpRequiredDate.Value = (DateTime)orderInfo.RequiredDate;
                dtpShippedDate.Value = (DateTime)orderInfo.ShippedDate;
                numFreight.Value = (decimal)orderInfo.Freight;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Load Order Input");
        }
    }
}
