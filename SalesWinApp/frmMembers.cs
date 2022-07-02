using BusinessObject;
using BusinessObject.Interfaces;
using DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace SalesWinApp;

public partial class frmMembers : Form
{
    private Member loginMember;
    private bool IsAdmin = true;
    private BindingSource source;

    private void LoadMemberList(IEnumerable<Member> list)
    {
        try
        {
            btnDelete.Enabled = true;
            if (IsAdmin == false)
            {
                list = new Member[] { loginMember };
                btnDelete.Enabled = false;
            }
            else if (list.Count() == 0)
            {
                btnDelete.Enabled = false;
            }
            source = new BindingSource();
            source.DataSource = list;

            dgvMembers.DataSource = null;
            dgvMembers.DataSource = source;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private Member GetCurrentMember()
    {
        Member member = null;
        try
        {
            member = dgvMembers.CurrentRow.DataBoundItem as Member;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get member");
        }
        return member;
    }
    public frmMembers(Member loginMember)
    {
        InitializeComponent();

        this.loginMember = loginMember;
    }

    private void frmMembers_Load(object sender, EventArgs e)
    {
        IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json", true, true)
                .Build();
        string adminEmail = config["DefaultAccounts:Email"];

        if (adminEmail != loginMember.Email)
        {
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            IsAdmin = false;
        }
        IMemberServices memberServices = new MemberServices();
        var list = memberServices.GetMemberList();
        LoadMemberList(list);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            IMemberServices memberServices = new MemberServices();
            Member member = GetCurrentMember();
            memberServices.DeleteMember(member);

            var list = memberServices.GetMemberList();
            LoadMemberList(list);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Delete member");
        }
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
        frmMemberDetail frmMemberDetail = new frmMemberDetail
        {
            Text = "InsertMember",
            IsUpdate = false,
        };
        frmMemberDetail.ShowDialog();
        if (frmMemberDetail.DialogResult == DialogResult.OK)
        {
            IMemberServices memberServices = new MemberServices();
            var list = memberServices.GetMemberList();
            LoadMemberList(list);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        frmMemberDetail frmMemberDetail = new frmMemberDetail
        {
            Text = "Update Member",
            IsUpdate = true,
            memberInfo = GetCurrentMember(),
        };
        frmMemberDetail.ShowDialog();
        if (frmMemberDetail.DialogResult == DialogResult.OK)
        {
            IMemberServices memberServices = new MemberServices();
            var list = memberServices.GetMemberList();
            LoadMemberList(list);
        }
    }
}
