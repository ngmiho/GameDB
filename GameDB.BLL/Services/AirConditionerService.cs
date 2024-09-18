using GameDB.DAL.Entities;
using GameDB.DAL.Repositories;

namespace GameDB.BLL.Services
{
    public class AirConditionerService
    {
        private AirConditionerRepository _repository = new();

        public List<AirConditioner>? getAirConditionersByName(string airConName)
        {
            List<AirConditioner> airConditioners = _repository.getAirConditioners();

            return airConditioners.Where(e => e.AirConditionerName.ToLower().Contains(airConName.ToLower())).ToList();
        }

        public List<AirConditioner> getAllAirConditioners()
        {
            return _repository.getAirConditioners();
        }

        public void AddAirCon(AirConditioner airConditioner)
        {
            _repository.AddAirCon(airConditioner);
        }

        public void UpdateAirCon(AirConditioner airConditioner)
        {
            _repository.UpdateAirCon(airConditioner);
        }

        public void DeleteAirCon(AirConditioner airConditioner)
        {
            _repository.DeleteAirCon(airConditioner);
        }
    }
}
