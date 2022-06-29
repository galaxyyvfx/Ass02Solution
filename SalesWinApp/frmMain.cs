using DataAccess.Models;

namespace SalesWinApp;

public partial class frmMain : Form
{
    private Member loginUser;
    public frmMain(Member loginUser)
    {
        InitializeComponent();

        this.loginUser = loginUser;
    }

    private void membersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmMembers frmMembers = new frmMembers();
        frmMembers.MdiParent = this;

        frmMembers.ShowDialog();
    }

    private void productsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmProducts frmProducts = new frmProducts();
        frmProducts.MdiParent = this;
        
        frmProducts.ShowDialog();
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmOrders frmOrders = new frmOrders();
        frmOrders.MdiParent = this;

        frmOrders.ShowDialog();
    }
}
