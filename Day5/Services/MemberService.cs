using Day5.Models;
using Day5.Data;
using System.Data;

namespace Day5.Services
{
    public class MemberService : IMemberService
    {
        public List<string> FullNames()
        {
            return MemberData.Members.Select(mem => mem.FullName).ToList();
        }

        public List<Member> GetAllPeople()
        {
            return MemberData.Members.ToList();
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("First name"), new DataColumn("Last Name"), new DataColumn("Gender"), new DataColumn("Date Of Birth"), new DataColumn("Phone Number"), new DataColumn("Place"), new DataColumn("Granduated"), });
            foreach (var item in GetAllPeople())
            {
                table.Rows.Add(item.FirstName, item.LastName, item.Gender, item.DateOfBirth, item.PhoneNum, item.BirthPlace, item.IsGranduated);
            }
            return table;
        }

        public List<Member> GetMaleMembers()
        {
            return MemberData.Members.Where(m => m.Gender == Enum.Gender.Male).ToList();
        }

        public Tuple<List<Member>, List<Member>, List<Member>> GetMemberByYear(int year)
        {
            var member2k = MemberData.Members.Where(x => x.DateOfBirth.Year == year).ToList();
            var memberGreater2k = MemberData.Members.Where(x => x.DateOfBirth.Year < year).ToList();
            var memberLess2k = MemberData.Members.Where(x => x.DateOfBirth.Year > year).ToList();

            return Tuple.Create(member2k, memberGreater2k, memberLess2k);
        }

        public Member OldestMember()
        {
            return MemberData.Members.MinBy(m => m.DateOfBirth.Year);
        }
    }
}