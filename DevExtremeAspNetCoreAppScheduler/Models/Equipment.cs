namespace DevExtremeAspNetCoreAppScheduler.Models
{
    public class Equipment : BaseEntity
    {        
        [DisplayName("Lokasyon")]
        public string Location { get; set; }

        [DisplayName("Ad")]
        public string? Name { get; set; }

        [DisplayName("Açıklama")]
        public string? Description { get; set; }

        [DisplayName("Yıl")]
        public int Year { get; set; }

        [DisplayName("Model")]
        public Guid EquipmentModelId { get; set; }        

        [DisplayName("Seri No")]
        public string? SerialNumber { get; set; }

        [DisplayName("Çalışma Saati")]
        public int? MachineHour { get; set; }

        [DisplayName("Son Bakım Saati")]
        public int? LastMaintenanceHour { get; set; }
        
        [DisplayName("Kurulum Tarihi")]
        public DateTime? DateOfInstallation { get; set; }

        [DisplayName("Bağlı Olduğu Trafo")]
        public string? TransformerNumber { get; set; }

        [DisplayName("Aktif")]
        public bool Active { get; set; } = true;
        public virtual ICollection<MaintenancePlan> MaintenancePlans { get; set; }
    }
}
