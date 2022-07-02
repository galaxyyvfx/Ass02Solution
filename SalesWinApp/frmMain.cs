using DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace SalesWinApp;

public partial class frmMain : Form
{
    private Member loginUser;
    public frmMain(Member loginUser)
    {
        InitializeComponent();

        this.loginUser = loginUser;

        IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json", true, true)
                .Build();
        string adminEmail = config["DefaultAccounts:Email"];
        
        if (adminEmail != loginUser.Email)
        {
            productsToolStripMenuItem.Enabled = false;
        }
    }

    private void membersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmMembers frmMembers = new frmMembers(loginUser);
        frmMembers.MdiParent = this;

        frmMembers.Show();
    }

    private void productsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmProducts frmProducts = new frmProducts();
        frmProducts.MdiParent = this;
        
        frmProducts.Show();
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmOrders frmOrders = new frmOrders(loginUser);
        frmOrders.MdiParent = this;

        frmOrders.Show();
    }
}
