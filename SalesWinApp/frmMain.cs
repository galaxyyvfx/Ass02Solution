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
}
