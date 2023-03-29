using Fuel_Tracking_application.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Fuel_Tracking_application.Models;

namespace Fuel_Tracking_application.Data
{
    public class FuelDbContext : DbContext
    {
        public FuelDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet <Fuel> FuelData { get; set; }

       // public DbSet<ConsumptionModel> ConsumptionModels { get; set; }
    }
} 
