using GameDB.DAL.Entities;

namespace GameDB.DAL.Repositories
{
    public class AirConditionerRepository
    {
        private AirConditionerShop2024DbContext _context = new();


        public List<AirConditioner> getAirConditioners()
        {
            return _context.AirConditioners.ToList();
        }

        public void AddAirCon(AirConditioner airConditioner)
        {
            _context.Add(airConditioner);
            _context.SaveChanges();
        }

        public void UpdateAirCon(AirConditioner airConditioner)
        {
            _context.Update(airConditioner);
            _context.SaveChanges();
        }

        public void DeleteAirCon(AirConditioner airConditioner)
        {
            _context.Remove(airConditioner);
            _context.SaveChanges();
        }
    }
}
