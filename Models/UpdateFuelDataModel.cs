using Fuel_Tracking_application.Models.Domain;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace Fuel_Tracking_application.Models
{
    public class UpdateFuelDataModel
    {
        
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

      //  [Column(TypeName = "nvarchar(24)")]
        public string? fuelType { get; set; }


       // [Column(TypeName = "nvarchar(24)")]
        public string? filled { get; set; }


    }
}
