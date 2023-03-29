using Microsoft.AspNetCore.Mvc;
using Fuel_Tracking_application.Models.Domain;
using Fuel_Tracking_application.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Fuel_Tracking_application.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace Fuel_Tracking_application.Controllers
{
    public class FuelDataController : Controller
    {
        private readonly FuelDbContext fuelDbContext;

        public FuelDataController(FuelDbContext fuelDbContext)
        {
            this.fuelDbContext = fuelDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var fuel = await fuelDbContext.FuelData.ToListAsync();
            return View(fuel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddFuelDataModel addFuelDataRequest)
        {
            var fuel = new Fuel()
            {
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
                fuelType = addFuelDataRequest.fuelType,

                refillCost = (addFuelDataRequest.fuelPrice * addFuelDataRequest.filledVolume)


                /*

                    //do
                    accKilometeres = fuelDbContext.FuelData.Select(p => p.odometerTotal).Sum(),

                    //working as planned does not account for the current value in the adjacent column 
                    accLitres = fuelDbContext.FuelData.Select(i => i.filledVolume).Sum(),

                    //working as planned does not account for the current value in the adjacent column 


                    //working as planned does not account for the current value in the adjacent column 
                    accLitresTotal = fuelDbContext.FuelData.Select(p => p.accLitres).Sum(),

                   // consumptionKm =  (addFuelDataRequest.accKilometeres * 1/addFuelDataRequest.accLitres),

                 consumptionKmTotal = fuelDbContext.FuelData.Select(p => p.consumptionKm).Sum(),

                    consumptionlitresTotal = await fuelDbContext.FuelData.Select(p => p.consumptionLitres).SumAsync()

                    costOfTheKm = Convert.ToDouble(1 / addFuelDataRequest.fuelPrice * addFuelDataRequest.consumptionKm),

                    consumptionLitres = Convert.ToDouble(addFuelDataRequest.accLitres / addFuelDataRequest.accKilometeres)

                    */



            };

            //   await Calculate(fuel);

              
            await fuelDbContext.FuelData.AddAsync(fuel);
            await fuelDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var fueldata = await fuelDbContext.FuelData.FirstOrDefaultAsync(x => x.dataId == id);


            if (fueldata != null)
            {
                var viewModel = new UpdateFuelDataModel()
                {
                    dataId = fueldata.dataId,
                    reportingEmployee = fueldata.reportingEmployee,
                    Date = fueldata.Date,
                    odometerTotal = fueldata.odometerTotal,
                    filled = fueldata.filled,
                    filledVolume = fueldata.filledVolume,
                    fuelPrice = fueldata.fuelPrice,
                    vehicleregistrationNumber = fueldata.vehicleregistrationNumber,
                    fillStationType = fueldata.fillStationType,
                    siteLocation = fueldata.siteLocation,
                    vehicleMake = fueldata.vehicleMake,
                    fuelType = fueldata.fuelType,



                };

                return await Task.Run(() => View("View", viewModel));
            }

            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> View(UpdateFuelDataModel model)
        {
            var fuel = await fuelDbContext.FuelData.FindAsync(model.dataId);

            if (fuel != null)
            {
                fuel.reportingEmployee = model.reportingEmployee;
                fuel.Date = model.Date;
                fuel.odometerTotal = model.odometerTotal;
                fuel.filled = model.filled;
                fuel.filledVolume = model.filledVolume;
                fuel.vehicleregistrationNumber = model.vehicleregistrationNumber;
                fuel.vehicleMake = model.vehicleMake;
                fuel.fuelPrice = model.fuelPrice;
                fuel.fillStationType = model.fillStationType;
                fuel.siteLocation = model.siteLocation;
                fuel.fuelType = model.fuelType;

                /*
                if (fuel.vehicleregistrationNumber != null)
                {
                    fuel.accKilometeres = fuelDbContext.FuelData.Select(p => p.odometerTotal).Sum();
                    fuel.accLitres = fuelDbContext.FuelData.Select(p => p.filledVolume).Sum();

                    //if registration number is not negetive, then the refill cost is fuel price multiplied by the filled volume
                    fuel.refillCost = fuel.fuelPrice * fuel.filledVolume;

                    fuel.consumptionKm = fuel.accKilometeres / fuel.accLitres;
                    fuel.consumptionLitres = fuel.accLitres / fuel.accKilometeres;

                    fuel.costOfTheKm = (1 / fuel.fuelPrice * fuel.consumptionKm);
                    fuel.accLitresTotal = fuelDbContext.FuelData.Select(p => p.accLitres).Sum();
                    fuel.consumptionKmTotal = fuelDbContext.FuelData.Select(p => p.consumptionKm).Sum();
                    fuel.consumptionlitresTotal = await fuelDbContext.FuelData.Select(p => p.consumptionLitres).SumAsync();

                }
                */

                await fuelDbContext.SaveChangesAsync();

                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateFuelDataModel model)
        {
            var fuel = fuelDbContext.FuelData.Find(model.dataId);

            if (fuel != null)
            {
                fuelDbContext.FuelData.Remove(fuel);
                await fuelDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        /*calculate the the rest of the data point and enter them into the db
         */

        //Don't think this method works. 

        /*
        [HttpPost]
        public async Task<IActionResult> Calculate(FuelCalculationDataModel calcFuelDataRequest)
        {

            // Validate input data
            if (calcFuelDataRequest == null)
            {
                return BadRequest("Input data cannot be null");
            }

            // Get the fuel data for the specified vehicle registration number
            var fuel = fuelDbContext.FuelData.FirstOrDefault(p => p.vehicleregistrationNumber == calcFuelDataRequest.vehicleregistrationNumber);

            if (fuel != null)
            {
                // Calculate accumulated kilometers and liters
                fuel.accKilometeres = fuelDbContext.FuelData.Where(p => p.vehicleregistrationNumber == calcFuelDataRequest.vehicleregistrationNumber).Select(p => p.odometerTotal).Sum();
                fuel.accLitres = fuelDbContext.FuelData.Where(p => p.vehicleregistrationNumber == calcFuelDataRequest.vehicleregistrationNumber).Select(p => p.filledVolume).Sum();

                // Calculate refill cost
                fuel.refillCost = fuel.fuelPrice * fuel.filledVolume;

                // Calculate consumption metrics
                if (fuel.accLitres != 0)
                {
                    fuel.consumptionKm = fuel.accKilometeres / fuel.accLitres;
                    fuel.consumptionLitres = fuel.accLitres / fuel.accKilometeres;
                }

                if (fuel.fuelPrice != 0)
                {
                    fuel.costOfTheKm = 1 / fuel.fuelPrice * fuel.consumptionKm;
                }

                // Calculate accumulated liters and kilometers
                fuel.accLitresTotal = fuelDbContext.FuelData.Where(p => p.vehicleregistrationNumber == calcFuelDataRequest.vehicleregistrationNumber).Select(p => p.accLitres).Sum();
                fuel.accKilometerTotal = fuelDbContext.FuelData.Where(p => p.vehicleregistrationNumber == calcFuelDataRequest.vehicleregistrationNumber).Select(p => p.accKilometeres).Sum();

                // Calculate total consumption metrics
                fuel.consumptionKmTotal = fuelDbContext.FuelData.Where(p => p.vehicleregistrationNumber == calcFuelDataRequest.vehicleregistrationNumber).Select(p => p.consumptionKm).Sum();
                fuel.consumptionlitresTotal = fuelDbContext.FuelData.Where(p => p.vehicleregistrationNumber == calcFuelDataRequest.vehicleregistrationNumber).Select(p => p.consumptionlitresTotal).Sum();

              


                
                //sets the registration number as the variable 
                var fuel = fuelDbContext.FuelData.Find(calcFuelDataRequest.vehicleregistrationNumber);

                if (fuel.accKilometeres != 0)
                {
                    fuel.accKilometeres = fuelDbContext.FuelData.Select(p => p.odometerTotal).Sum();
                }
                else
                {
                    fuel.accKilometeres = 0;    
                }
                if (fuel.accLitres != 0)
                {
                    fuel.accLitres = fuelDbContext.FuelData.Select(p => p.filledVolume).Sum();
                }
                if (fuel.accLitres != 0)
                {
                    fuel.consumptionKm = fuel.accKilometeres / fuel.accLitres;
                }
                if (fuel.accKilometeres != 0)
                {
                    fuel.consumptionLitres = fuel.accLitres / fuel.accKilometeres;
                }
                if (fuel.accLitresTotal != 0)
                {
                    fuel.accLitresTotal = fuelDbContext.FuelData.Select(p => p.accLitres).Sum();
                }
                if (fuel.fuelPrice != 0 && fuel.consumptionKm != 0)
                {
                    fuel.costOfTheKm = (1 / fuel.fuelPrice * fuel.consumptionKm);
                }
                else
                {
                    fuel.costOfTheKm = 0;
                }
                if (fuel.accKilometerTotal != 0)
                {
                    fuel.accKilometerTotal = fuelDbContext.FuelData.Select(p => p.accKilometeres).Sum();
                }
                if (fuel.consumptionKmTotal != 0)
                {
                    fuel.consumptionKmTotal = fuelDbContext.FuelData.Select(p => p.consumptionKm).Sum();
                }
                if (fuel.consumptionlitresTotal != 0)
                {
                    fuel.consumptionlitresTotal = await fuelDbContext.FuelData.Select(p => p.consumptionLitres).SumAsync();
                }



                await fuelDbContext.FuelData.AddAsync(fuel);
                await fuelDbContext.SaveChangesAsync();
                return RedirectToAction("Index");

                //if registration number is not negetive, then individual accumulated kilometeres is odometer total
                // fuel.accKilometeres = fuelDbContext.FuelData.Select(p => p.odometerTotal).Sum();


                //if registration number is not negetive, then the refill cost is fuel price multiplied by the filled volume
                // fuel.refillCost = fuel.fuelPrice * fuel.filledVolume;



                // fuel.accLitresTotal = fuelDbContext.FuelData.Select(p => p.accLitres).Sum();

                //  List<object> data = new List<object>();
                //  List<string> labels = fuelDbContext.FuelData.Select(p => p.vehicleregistrationNumber).ToList();

                

                
            }
  

    


        }
        */
    }
}

