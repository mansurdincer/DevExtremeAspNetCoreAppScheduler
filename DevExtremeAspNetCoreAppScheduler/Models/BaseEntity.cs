namespace DevExtremeAspNetCoreAppScheduler.Models
{
    public abstract class BaseEntity
    {        
        public Guid Id { get; set; }

        [DisplayName("Kaydeden")]
        public Guid CreatedById { get; set; }    

        [DisplayName("Kayit Tarihi")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Güncelleyen")]
        public Guid? UpdatedById { get; set; }

        [DisplayName("Güncelleme Tarihi")]
        public DateTime? UpdatedAt { get; set; }
       
    }
}
