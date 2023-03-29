using Fuel_Tracking_application.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Fuel_Tracking_application.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Fuel_Tracking_application.Controllers
{
    public class GraphDataController : Controller
    {
        private readonly FuelDbContext fuelDbContext;

        public GraphDataController(FuelDbContext fuelDbContext)
        {
            this.fuelDbContext = fuelDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowGraphData() 
        {
            return View();
        }

        [HttpPost]
        public List<object> GetGrapData()
        {
            List<object> data = new List<object>();

            List<string?> vehicleRegistrations = fuelDbContext.FuelData.Select(p => p.vehicleregistrationNumber).ToList();

            data.Add(vehicleRegistrations);    

            List<double> refilCost = fuelDbContext.FuelData.Select(p => p.refillCost).ToList();

            data.Add(refilCost);

            List<double> odometerTotal = fuelDbContext.FuelData.Select(p => p.odometerTotal).ToList();

            data.Add(odometerTotal);

            List<double> filledVolume = fuelDbContext.FuelData.Select(p => p.filledVolume).ToList();

            data.Add(filledVolume);

            List<string?> fillStationType = fuelDbContext.FuelData.Select(p => p.vehicleregistrationNumber).ToList();

            data.Add(fillStationType);

            return data;
        }
    }
}
