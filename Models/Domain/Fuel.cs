using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fuel_Tracking_application.Models.Domain
{
    /*
    public enum FuelType
    {
        
        ULP93 = 1,
        LRP95 = 2,
        ULP95 = 3,
        Diesel = 0
    }

    public enum Filled
    {
        Yes = 1,
        No = 0
    }

    public enum FillStationType
    {
        Inland = 1,
        Costal = 0
    }

    */



    public class Fuel
    {
        [Key]
        public Guid dataId { get; set; }

        public string? reportingEmployee { get; set; }

        public DateTime Date { get; set; }

        public double odometerTotal { get; set; }

        public double filledVolume { get; set; }

        public double fuelPrice { get; set; }


       //remember not to make the strings required 
        public string? vehicleregistrationNumber { get; set; }

       // [Column(TypeName = "nvarchar(24)")]
        public string? fillStationType { get; set; }

        
        public string? siteLocation { get; set; }

        public string? vehicleMake { get; set; }


       // [Column(TypeName = "nvarchar(24)")]
        public string? fuelType { get; set; }

        //[Column(TypeName = "nvarchar(24)")]
        public string? filled { get; set; }

        //Refill Cost variables 
        public double refillCost { get; set; }

        //calculation cons


        
        //Kilometeres variables 
        public double accKilometeres { get; set; }
        public double accKilometerTotal { get; set; }

        //Litres variables 
        public double accLitres { get; set; }
        public double accLitresTotal { get; set; }

        
        public double refilCostTotal { get; set; }

        //Consumption variables 
        public double consumptionKm { get; set; }
        public double consumptionKmTotal { get; set; }


        //Consumption variables 
        public double consumptionLitres { get; set; }
        public double consumptionlitresTotal { get; set; }

        public double costOfTheKm { get; set; }
        

    }
}
