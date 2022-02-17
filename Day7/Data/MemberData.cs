using Day7.Models;
namespace Day7.Data
{
    public class MemberData
    {
        public static List<MembeModel> Members = new List<MembeModel>() {
            new MembeModel {
                id = 1,
                FirstName = "Tien",
                LastName = "Pham",
                Gender = "male",
                DateOfBirth = new DateTime(1998,03,26),
                PhoneNumber = "0963164813",
                BirthPlace="TB",
                IsGranduated = "No",
            },
                new MembeModel {
                id = 2 ,
                FirstName = "Nam",
                LastName = "Pham",
                Gender = "female",
                DateOfBirth = new DateTime(2002,03,26),
                PhoneNumber = "0963164813",
                BirthPlace="TB",
                IsGranduated = "Yes",
            },
                new MembeModel {
                id = 3 ,
                FirstName = "Thu",
                LastName = "Pham",
                Gender = "other",
                DateOfBirth = new DateTime(2000,03,26),
                PhoneNumber = "0963164813",
                BirthPlace="TB",
                IsGranduated = "Yes",
            }
        };
    }
}