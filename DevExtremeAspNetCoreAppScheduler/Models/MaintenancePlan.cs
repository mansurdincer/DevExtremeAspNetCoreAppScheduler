namespace DevExtremeAspNetCoreAppScheduler.Models
{
    public class MaintenancePlan : BaseEntity
    {
        [DisplayName("Başlık")]
        public string? Text { get; set; }

        [DisplayName("Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        [DisplayName("Açıklama")]
        public string? Description { get; set; }

        [DisplayName("Ekipman")]
        public Guid? EquipmentId { get; set; }

        [DisplayName("Ekipman")]
        public virtual Equipment? Equipment { get; set; }

        [DisplayName("Tam Gün")]
        public bool? AllDay { get; set; }

        [DisplayName("Tekrar")]
        public string? RecurrenceRule { get; set; }

        [DisplayName("Tekrarlama İstisnası")]
        public string? RecurrenceException { get; set; }

    }
}
