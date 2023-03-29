using Microsoft.AspNetCore.Mvc;
using Fuel_Tracking_application.Models.Domain;
using Fuel_Tracking_application.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Fuel_Tracking_application.Data;
using Microsoft.EntityFrameworkCore;




namespace Fuel_Tracking_application.Controllers
{
    public class CalculateTableDataController : Controller
    {

        private readonly FuelDbContext fuelDbContext;

        public CalculateTableDataController(FuelDbContext fuelDbContext)
        {
            this.fuelDbContext = fuelDbContext;
        }

        /*

        private readonly FuelDbContext fuelDbContext;

        public CalculateTableDataController(FuelDbContext fuelDbContext)
        {
            this.fuelDbContext = fuelDbContext;
        }
        */


        public IActionResult Index()
        {
            return View();
        }



                /*
                dataId = Guid.NewGuid(),
                reportingEmployee = addFuelDataRequest.reportingEmployee,
                Date = addFuelDataRequest.Date,
                odometerTotal = addFuelDataRequest.odometerTotal,
                filled = addFuelDataRequest.filled,
                filledVolume = addFuelDataRequest.filledVolume,
                fuelPrice = addFuelDataRequest.fuelPrice,
                vehicleregistrationNumber = addFuelDataRequest.vehicleregistrationNumber,
                fillStationType = addFuelDataRequest.fillStationType,
                siteLocation = addFuelDataRequest.siteLocation,
                vehicleMake = addFuelDataRequest.vehicleMake,
                fuelType = addFuelDataRequest.fuelType
                */

            

         





        /*
        [HttpPost]
        public async Task<IActionResult> CalculateValues(FuelCalculationDataModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
               
        }
        */

    }
    
}
