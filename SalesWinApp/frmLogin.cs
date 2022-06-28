using BusinessObject;
using BusinessObject.Interfaces;

namespace SalesWinApp;

public partial class frmLogin : Form
{
    IMemberServices memberServices = new MemberServices();
    public frmLogin()
    {
        InitializeComponent();
    }
}
