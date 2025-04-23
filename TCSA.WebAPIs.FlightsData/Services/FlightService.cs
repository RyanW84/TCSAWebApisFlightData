using TCSA.WebAPIs.FlightsData.Data;
using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Services;



public class FlightService : IFlightService
{
    private readonly FlightsDbContext _context;

    public FlightService(FlightsDbContext context)
    {
        _context = context;
    }

    public Flight Createflight(Flight flight)
    {
        var savedFlight = _context.Flights.Add(flight);
        _context.SaveChanges();
        return savedFlight.Entity;
    }

    public string? DeleteFlight(int id)
    {
        var savedFlight = _context.Flights.Find(id);

        if (savedFlight == null)
        {
            return null;
        }

        _context.Flights.Remove(savedFlight);
        _context.SaveChanges();

        return $"Successfully deleted flight with id: {id}";
    }

    public Flight? GetFlightById(int id)
    {
        var result = _context.Flights.Find(id);

        if (result == null)
        {
            return null;
        }

        return result;
    }

    public List<Flight> GetFlights()
    {
        return _context.Flights.ToList();
    }

    public Flight? Updateflight(int id, Flight updatedFlight)
    {
        var savedFlight = _context.Flights.Find(id);

        if (savedFlight == null)
        {
            return null;
        }

        _context.Entry(savedFlight).CurrentValues.SetValues(updatedFlight);
        _context.SaveChanges();

        return savedFlight;
    }

    public Flight Updateflight(Flight flight)
    {
        var savedFlight = _context.Flights.Find(flight.Id);

        if (savedFlight == null)
        {
            throw new ArgumentException($"Flight with id {flight.Id} not found.");
        }

        _context.Entry(savedFlight).CurrentValues.SetValues(flight);
        _context.SaveChanges();

        return savedFlight;
    }
}
