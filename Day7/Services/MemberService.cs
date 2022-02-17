using Day7.Models;
using Day7.Data;
namespace Day7.Services
{
    public class MemberService : IMemberService
    {
        public void CreateMember(MembeModel member)
        {
            int highestId = MemberData.Members.Max(m => m.id);
            member.id = highestId + 1;
            MemberData.Members.Add(member);
        }

        public void DeleteMember(MembeModel member)
        {
            MemberData.Members.Remove(member);
        }

        public void EditMember(MembeModel member)
        {
            var item = MemberData.Members.Where(m => m.id == member.id).FirstOrDefault();

            if (item != null)
            {
                item.FirstName = member.FirstName;
                item.LastName = member.LastName;
                item.Gender = member.Gender;
                item.DateOfBirth = member.DateOfBirth;
                item.BirthPlace = member.BirthPlace;
                item.PhoneNumber = member.PhoneNumber;
                item.IsGranduated = member.IsGranduated;
            }
        }

        public List<MembeModel> GetAllPeople()
        {
            return MemberData.Members;
        }

    }
}