using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Services;

public interface IFlightService
    {
    public List<Flight> GetFlights();
    public Flight? GetFlightById(int id);
    public Flight Createflight(Flight flight);
    public Flight Updateflight(Flight flight);
    public string? DeleteFlight(int id);
    }

