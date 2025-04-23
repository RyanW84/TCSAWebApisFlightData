using Microsoft.EntityFrameworkCore;

using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Data; 

public class FlightsDbContext(DbContextOptions options) : DbContext(options)
    {
    public DbSet <Flight> Flights { get; set; }
    }
