using BusinessObject;
using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmMemberDetail : Form
{
    private IMemberServices memberServices = new MemberServices();

    public Member memberInfo { get; set; }
    public bool IsUpdate { get; set; }
    private Member GetMemberInfo()
    {
        Member member = new Member
        {
            MemberId = IsUpdate==true?int.Parse(txtMemberID.Text):0,
            City = txtCity.Text,
            CompanyName = txtCompanyName.Text,
            Country = txtCountry.Text,
            Email = txtEmail.Text,
            Password = txtPassword.Text,
        };
        return member;
    }
    public frmMemberDetail()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Member member = GetMemberInfo();
        if (IsUpdate == true)
        {
            memberServices.UpdateMember(member);
        }
        else
        {
            memberServices.AddMember(member);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
