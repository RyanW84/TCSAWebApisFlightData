
using TCSA.WebAPIs.FlightsData.Data;
using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Services;

public class FlightService : IFlightService
    {
    private readonly FlightsDbContext dbContext;

    public FlightService(FlightsDbContext dbContext)
        {
        this.dbContext = dbContext;
        }
    public Flight CreateFlight(Flight flight)
        {
        throw new NotImplementedException();
        }

    public string? DeleteFlight(int Id)
        {
        throw new NotImplementedException();
        }

    public List<Flight> GetAllFlights()
        {
        return dbContext.Flights.ToList();
        }

    public Flight? GetFlightById(int id)
        {
        return dbContext.Flights.Find(id);
        }

    public Flight? UpdateFlight(int Id, Flight updatedFlight)
        {
        throw new NotImplementedException();
        }
    }

