using Microsoft.AspNetCore.Mvc;

using TCSA.WebAPIs.FlightsData.Models;
using TCSA.WebAPIs.FlightsData.Services;

namespace TCSA.WebAPIs.FlightsData.Controllers;

[Route("api/[controller]")]
//Example: http:localhost:5609/api/flights
public class FlightsController(IFlightService flightService) : Controller
{
    private readonly IFlightService _flightService = flightService;

    [HttpGet]
    public ActionResult<List<Flight>> GetAllFlights()
    {
        return Ok(_flightService.GetFlights());
    }

    [HttpGet("{id}")]
    public ActionResult<Flight> GetFlightById(int id)
    {
        var result = _flightService.GetFlightById(id));

        if (result == null)
        {
            return NotFound(); // Equivalent to 404
        }

        return Ok(result); // Equivalent to 200
    }

    [HttpPost]
    public ActionResult<Flight> CreateFlight(Flight flight)
    {
        return Ok(_flightService.Createflight(flight)); // Equivalent to 201
    }

    [HttpPut]
    public ActionResult<Flight> UpdateFlight(Flight flight)
    {
        var result = _flightService.Updateflight(flight));

        if (result == null)
        {
            return NotFound(); // Equivalent to 404
        }

        return Ok(result); // Equivalent to 200

        [HttpPut("{id}")]
        public ActionResult<Flight> DeleteFlight(int id)
        {
            var result = _flightService.DeleteFlight(id));

            if (result == null)
            {
                return NotFound(); // Equivalent to 404
            }

            return Ok(result); // Equivalent to 200
        }
    }
}