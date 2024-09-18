using GameDB.DAL.Entities;

namespace GameDB.DAL.Repositories
{
    public class StaffMemberRepository
    {
        private AirConditionerShop2024DbContext _context = new();

        public List<StaffMember> getAllStaffMembers()
        {
            return _context.StaffMembers.ToList();
        }

        public StaffMember getStaffMember(string emailAddress, string password)
        {
            return _context.StaffMembers.FirstOrDefault(e => e.EmailAddress == emailAddress && e.Password == password);
        }

    }
}
