using GameDB.DAL.Entities;
using GameDB.DAL.Repositories;

namespace GameDB.BLL.Services
{
    public class StaffMemberService
    {
        private StaffMemberRepository _repository = new();

        public List<StaffMember> getAllStaffMembers()
        {
            return _repository.getAllStaffMembers();
        }

        public StaffMember getStaffMember(string emailAddress, string password)
        {
            return _repository.getStaffMember(emailAddress, password);
        }
    }
}
