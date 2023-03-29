using System.ComponentModel.DataAnnotations;

namespace Fuel_Tracking_application.Models
{
    public class GraphModel
    {
        [Key]
        public Guid dataId { get; set; }

        public double odometerTotal { get; set; }

        public string? reportingEmployee { get; set; }

        public double filledVolume { get; set; }

        public double fuelPrice { get; set; }

        public string? vehicleregistrationNumber { get; set; }

        public string? fillStationType { get; set; }

        public string? fuelType { get; set; }

        public double refillCost { get; set; }

        public string? filled { get; set; }

    }
}
