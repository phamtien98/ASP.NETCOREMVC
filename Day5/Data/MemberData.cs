using Day5.Models;
using Day5.Enum;
namespace Day5.Data
{
    public static class MemberData
    {
        public static List<Member> Members = new List<Member>() {
            new Member {
                FirstName = "Tien",
                LastName = "Pham",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1998,03,26),
                PhoneNum = "0963164813",
                BirthPlace="TB",
                IsGranduated = false,
            },
                new Member {
                FirstName = "Nam",
                LastName = "Pham",
                Gender = Gender.Other,
                DateOfBirth = new DateTime(2002,03,26),
                PhoneNum = "0963164813",
                BirthPlace="TB",
                IsGranduated = true,
            },
                new Member {
                FirstName = "Thu",
                LastName = "Pham",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(2000,03,26),
                PhoneNum = "0963164813",
                BirthPlace="TB",
                IsGranduated = false,
            }
        };
    }
}