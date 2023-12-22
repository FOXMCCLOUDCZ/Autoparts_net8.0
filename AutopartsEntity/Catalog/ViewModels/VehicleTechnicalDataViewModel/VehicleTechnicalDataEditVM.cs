using System.ComponentModel.DataAnnotations;

namespace AutopartsEntity.Catalog.ViewModels.VehicleTechnicalDataViewModel
{
    public class VehicleTechnicalDataEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int PowerKW { get; set; }
        public int PowerHP { get; set; }
        public int EngineCapacity { get; set; }
        public int NumberOfCylinders { get; set; }
        public FuelType VehicleFuelType { get; set; }
        public enum FuelType
        {
            [Display(Name = "Benzín")]
            Petrol,
            [Display(Name = "Nafta")]
            Diesel,
            [Display(Name = "Benzín + zemní plyn")]
            CNG,
            [Display(Name = "Elektřina")]
            Electric,
            [Display(Name = "Benzín + elektro")]
            Hybrid,
        }
        public DriveType VehicleDriveType { get; set; }
        public enum DriveType
        {
            [Display(Name = "Pohon předních kol")]
            FrontWheelDrive,
            [Display(Name = "Pohon zadních kol")]
            RearWheelDrive,
            [Display(Name = "Pohon všech kol")]
            AllWheelDrive
        }
        public BodyConfiguration VehicleBodyConfiguration { get; set; }
        public enum BodyConfiguration
        {
            Test
        }
        public int? Tonnage { get; set; }
    }
}