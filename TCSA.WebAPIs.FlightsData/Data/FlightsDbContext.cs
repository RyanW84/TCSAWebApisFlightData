using Microsoft.EntityFrameworkCore;

using TCSA.WebAPIs.FlightsData.Models;

namespace TCSA.WebAPIs.FlightsData.Data; //00:23 resolving migration issues

public class FlightsDbContext : DbContext
    {
    public FlightsDbContext(DbContextOptions  options) : base (options)
        {
            
        }

    public DbSet <Flight> Flights { get; set; }
    }
