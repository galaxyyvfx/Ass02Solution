using BusinessObject.Interfaces;
using DataAccess.Models;

using Microsoft.Extensions.Configuration;

namespace BusinessObject;

public class MemberServices : IMemberServices
{
    public void AddMember(Member member)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.Members.Add(member);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteMember(Member member)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            var mem =
                dbContext.Members
                .SingleOrDefault
                (c => c.MemberId == member.MemberId);
            dbContext.Members.Remove(mem);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Member GetMember(int id)
    {
        Member member = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            member = dbContext.Members.Single(m => m.MemberId == id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return member;
    }

    public IEnumerable<Member> GetMemberList()
    {
        IEnumerable<Member> list = null;
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            list = dbContext.Members.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }

    public Member Login(string email, string password)
    {
        Member loginMember = null;
        try
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json", true, true)
                .Build();
            string adminEmail = config["DefaultAccounts:Email"];
            string adminPass = config["DefaultAccounts:Password"];
            if (adminEmail == email && adminPass == password)
            {
                loginMember = new Member
                {
                    MemberId = 0,
                    Email = email,
                    Password = password,
                    City = "",
                    Country = "",
                    CompanyName = "",
                };
            }
            else
            {
                using FStoreDBContext dbContext = new FStoreDBContext();
                loginMember = dbContext.Members.Single(c => c.Email == email);
                if (loginMember == null)
                {
                    throw new Exception("User not found!");
                }
                else if (loginMember.Password != password)
                {
                    throw new Exception("Incorrect password!");
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return loginMember;
    }

    public void UpdateMember(Member member)
    {
        try
        {
            using FStoreDBContext dbContext = new FStoreDBContext();
            dbContext.Entry<Member>(member).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
