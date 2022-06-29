using BusinessObject;
using BusinessObject.Interfaces;
using DataAccess.Models;

namespace SalesWinApp;

public partial class frmMembers : Form
{
    private BindingSource source;

    private IMemberServices memberServices = new MemberServices();
    private void LoadMemberList(IEnumerable<Member> list)
    {
        try
        {
            source.DataSource = list;

            dgvMembers.DataSource = null;
            dgvMembers.DataSource = source;

            if (list.Count() == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
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
    }

    private void frmMembers_Load(object sender, EventArgs e)
    {
        var list = memberServices.GetMemberList();
        LoadMemberList(list);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            Member member = GetCurrentMember();
            memberServices.DeleteMember(member);
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
            IsUpdate = false,
        };
        frmMemberDetail.ShowDialog();
        if (frmMemberDetail.DialogResult == DialogResult.OK)
        {
            var list = memberServices.GetMemberList();
            LoadMemberList(list);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        frmMemberDetail frmMemberDetail = new frmMemberDetail
        {
            IsUpdate = true,
            memberInfo = GetCurrentMember(),
        };
        frmMemberDetail.ShowDialog();
        if (frmMemberDetail.DialogResult == DialogResult.OK)
        {
            var list = memberServices.GetMemberList();
            LoadMemberList(list);
        }
    }
}
