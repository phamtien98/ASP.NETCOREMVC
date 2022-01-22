using System.Data;
using Day5.Models;
namespace Day5.Services
{
    public interface IMemberService
    {
        List<Member> GetMaleMembers();
        Member OldestMember();
        Tuple<List<Member>, List<Member>, List<Member>> GetMemberByYear(int year);
        List<Member> GetAllPeople();
        List<string> FullNames();
        DataTable GetData();
    }
}