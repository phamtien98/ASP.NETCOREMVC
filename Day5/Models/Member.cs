using Day5.Enum;

namespace Day5.Models
{
    public partial class Member
    {
   
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PhoneNum { get; set; }
        public String BirthPlace { get; set; }
        public bool IsGranduated { get; set; }

         public string FullName
        {
            get
            {
                return String.Format("Full Name: {0} {1} ", FirstName, LastName);
            }
        }
    }
}