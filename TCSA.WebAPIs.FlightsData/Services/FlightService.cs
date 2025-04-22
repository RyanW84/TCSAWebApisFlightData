
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
        var savedFlight = dbContext.Flights.Add(flight);

        dbContext.SaveChanges();

        return savedFlight.Entity;
        }

    public string? DeleteFlight(int Id)
        {
        Flight? savedFlight = dbContext.Flights.Find(Id);

        if (savedFlight != null)
            {
            return null;
            }

        dbContext.Flights.Remove(savedFlight);

        dbContext.SaveChanges();

        return $"Successfully flight with ID:{Id}";
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
        Flight savedFlight = dbContext.Flights.Find(Id);

        if (savedFlight != null)
            {
            return null;
            }
        savedFlight.Id = updatedFlight.Id;
        savedFlight.AirlineName = updatedFlight.AirlineName;
        savedFlight.DepartureAirportCode = updatedFlight.DepartureAirportCode;
        savedFlight.DepartureDateTime = updatedFlight.DepartureDateTime;
        savedFlight.ArrivalDateTime = updatedFlight.ArrivalDateTime;
        savedFlight.PassengerCapacity = updatedFlight.PassengerCapacity;

        dbContext.SaveChanges();

        return savedFlight;
        }
    }

