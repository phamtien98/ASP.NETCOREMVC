using Day7.Models;
namespace Day7.Services
{
    public interface IMemberService
    {
        List<MembeModel> GetAllPeople();
        void CreateMember(MembeModel member);
        void DeleteMember(MembeModel member);
        void EditMember(MembeModel member);
    }
}