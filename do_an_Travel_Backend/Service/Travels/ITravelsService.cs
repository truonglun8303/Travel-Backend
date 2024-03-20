using do_an_Travel_Backend.Models;

namespace do_an_Travel_Backend.Service.Travels
{
    public interface ITravelsService
    {
        List<Travel> GetTravels();
        Boolean AddTravels(Travel travel);
        Boolean RemoveTravels(Travel travel);
        Boolean UpdateTravels(Travel travel);
    }
}
