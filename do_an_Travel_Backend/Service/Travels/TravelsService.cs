using do_an_Travel_Backend.Data;
using do_an_Travel_Backend.Models;

namespace do_an_Travel_Backend.Service.Travels
{
    public class TravelsService : ITravelsService
    {

        private readonly TravelDbContext _travelDbContext;
        public TravelsService(TravelDbContext travelDbContext)
        {
            _travelDbContext = travelDbContext;
        }
        public bool AddTravels(Travel travel)
        {
            throw new NotImplementedException();
        }

        public List<Travel> GetTravels()
        {
            return _travelDbContext.Travels.OrderByDescending(x => x.Id).ToList();
        }

        public bool RemoveTravels(Travel travel)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTravels(Travel travel)
        {
            throw new NotImplementedException();
        }
    }
}
