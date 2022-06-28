using DataAccess.Models;

namespace BusinessObject.Interfaces;

public interface IMemberServices
{
    public Member Login(string email, string password);
    public IEnumerable<Member> GetMemberList();
    public Member GetMember(int id);
    public void AddMember(Member member);
    public void UpdateMember(Member member);
    public void DeleteMember(Member member);
}
