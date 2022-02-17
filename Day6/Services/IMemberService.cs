using Day6.Models;
namespace Day6.Services
{
    public interface IMemberService
    {
        List<MembeModel> GetAllPeople();
        void CreateMember(MembeModel member);
        void DeleteMember(MembeModel member);
        void EditMember(MembeModel member);
    }
}