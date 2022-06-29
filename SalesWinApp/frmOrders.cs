using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmOrders : Form
{
    private IOrderServices orderServices = new OrderServices();
    private IOrderDetailServices orderDetailServices = new OrderDetailServices();
    
    private BindingSource source;
    public frmOrders()
    {
        InitializeComponent();
    }
    private void LoadOrderList(IEnumerable<Order> list)
    {
        try
        {
            dgvOrderDetail.DataSource = null;
            source.DataSource = list;

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = list;
            
            if (list.Count() == 0)
            {
                btnDeleteOrder.Enabled = false;
            }
            else
            {
                btnDeleteOrder.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void LoadOrderDetailList(IEnumerable<OrderDetail> list)
    {
        try
        {
            source.DataSource = list;

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = list;

            if (list.Count() == 0)
            {
                btnDeleteOrderDetails.Enabled = false;
            }
            else
            {
                btnDeleteOrderDetails.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private Order GetCurrentOrder()
    {
        Order order = null;
        try
        {
            order = dgvOrders.CurrentRow.DataBoundItem as Order;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get Order");
        }
        return order;
    }
    private OrderDetail GetCurrentOrderDetail()
    {
        OrderDetail orderDetail = null;
        try
        {
            orderDetail = dgvOrderDetail.CurrentRow.DataBoundItem as OrderDetail;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get Order Detail");
        }
        return orderDetail;
    }
    private void frmOrders_Load(object sender, EventArgs e)
    {
        var orderList = orderServices.GetOrderList();
        dgvOrders.CellClick += DgvOrders_CellClick;
    }

    private void DgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var currentOrder = GetCurrentOrder();
        var orderDetailList = orderDetailServices
                        .GetOrderDetailFromOrderId(currentOrder.OrderId);

        LoadOrderDetailList(orderDetailList);
    }

    private void btnInsertOrder_Click(object sender, EventArgs e)
    {
        frmOrderInput frmOrderInput = new frmOrderInput
        {
            IsUpdate = false,
        };
        frmOrderInput.ShowDialog();
        if (frmOrderInput.DialogResult == DialogResult.OK)
        {
            var list = orderServices.GetOrderList();
            LoadOrderList(list);
        }
    }

    private void btnUpdateOrder_Click(object sender, EventArgs e)
    {
        frmOrderInput frmOrderInput = new frmOrderInput
        {
            IsUpdate = true,
            orderInfo = GetCurrentOrder(),
        };
        frmOrderInput.ShowDialog();
        if (frmOrderInput.DialogResult == DialogResult.OK)
        {
            var list = orderServices.GetOrderList();
            LoadOrderList(list);
        }
    }

    private void btnDeleteOrder_Click(object sender, EventArgs e)
    {
        try
        {
            Order order = GetCurrentOrder();
            orderServices.DeleteOrder(order);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            var StartDate = dtpStartDate.Value;
            var EndDate = dtpEndDate.Value;
            var list = orderServices.GetOrder(StartDate, EndDate);
            LoadOrderList(list);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnInsertOrderDetail_Click(object sender, EventArgs e)
    {
        try
        {
            var currentOrder = GetCurrentOrder();
            frmOrderDetailInput frmOrderDetailInput = new frmOrderDetailInput
            {
                IsUpdate = false,
            };
            frmOrderDetailInput.ShowDialog();
            if (frmOrderDetailInput.DialogResult == DialogResult.OK)
            {
                var list = orderDetailServices
                    .GetOrderDetailFromOrderId(
                    currentOrder.OrderId
                    );
                LoadOrderDetailList(list);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
    {
        try
        {
            var currentOrderDetail = GetCurrentOrderDetail();
            frmOrderDetailInput frmOrderDetailInput = new frmOrderDetailInput
            {
                IsUpdate = true,
                orderDetailInfo = GetCurrentOrderDetail(),
            };
            frmOrderDetailInput.ShowDialog();
            if (frmOrderDetailInput.DialogResult == DialogResult.OK)
            {
                var list = orderDetailServices
                    .GetOrderDetailFromOrderId(
                    (int)currentOrderDetail.OrderId
                    );
                LoadOrderDetailList(list);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnDeleteOrderDetails_Click(object sender, EventArgs e)
    {
        try
        {
            OrderDetail orderDetail = GetCurrentOrderDetail();
            orderDetailServices.DeleteOrderDetail(orderDetail);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

}
