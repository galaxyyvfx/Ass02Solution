using BusinessObject;
using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmLogin : Form
{
    IMemberServices memberServices = new MemberServices();
    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string email    = txtEmail.Text;
        string password = txtPassword.Text;

        try
        {
            Member loginMember = memberServices.Login(email, password);
            this.Hide();
            frmMain frmMain = new frmMain(loginMember);
            frmMain.ShowDialog();
            this.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Login");
        }
    }
}
