using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Services;

public interface IFlightService
    {
    public List<Flight> GetAllFlights();
    public Flight? GetFlightById(int id);
    public Flight CreateFlight(Flight flight);
    public Flight? UpdateFlight(int Id, Flight updatedFlight);
    public string? DeleteFlight(int Id);
    }

