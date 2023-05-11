namespace DevExtremeAspNetCoreAppScheduler.Data;

public static class DbInitializer
{
    //private readonly ModelBuilder modelBuilder;

    //public DbInitializer(ModelBuilder modelBuilder)
    //{
    //    this.modelBuilder = modelBuilder;
    //}
    public static void Seed(ApplicationDbContext context)
    {

        var equipment1 = new Equipment { Id = Guid.NewGuid(), Location = "E101", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment2 = new Equipment { Id = Guid.NewGuid(), Location = "E102", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment3 = new Equipment { Id = Guid.NewGuid(), Location = "E103", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment4 = new Equipment { Id = Guid.NewGuid(), Location = "E104", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment5 = new Equipment { Id = Guid.NewGuid(), Location = "E105", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment6 = new Equipment { Id = Guid.NewGuid(), Location = "E106", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment7 = new Equipment { Id = Guid.NewGuid(), Location = "E107", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment8 = new Equipment { Id = Guid.NewGuid(), Location = "E108", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment9 = new Equipment { Id = Guid.NewGuid(), Location = "E109", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment10 = new Equipment { Id = Guid.NewGuid(), Location = "E110", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment11 = new Equipment { Id = Guid.NewGuid(), Location = "E201", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment12 = new Equipment { Id = Guid.NewGuid(), Location = "E202", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment13 = new Equipment { Id = Guid.NewGuid(), Location = "E203", SerialNumber = "", Year = 1900, Description = "", Active = false };
        var equipment14 = new Equipment { Id = Guid.NewGuid(), Location = "E204", SerialNumber = "", Year = 1900, Description = "", Active = false };

        if (!context.Equipments.Any())
            context.Equipments.AddRange(equipment1, equipment2, equipment3, equipment4, equipment5, equipment6, equipment7, equipment8, equipment9, equipment10, equipment11, equipment12, equipment13, equipment14);

        
        var maintenancePlan1 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E101 3000 Hour",  StartDate = DateTime.UtcNow.AddDays(-5), EndDate = DateTime.UtcNow.AddDays(-4), EquipmentId = equipment1.Id, Description = "E101 3000 Hour" };
        var maintenancePlan2 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E101 6000 Hour",  StartDate = DateTime.UtcNow.AddDays(-4), EndDate = DateTime.UtcNow.AddDays(-3), EquipmentId = equipment1.Id, Description = "E101 6000 Hour" };
        var maintenancePlan3 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E101 12000 Hour", StartDate = DateTime.UtcNow.AddDays(-3), EndDate = DateTime.UtcNow.AddDays(-2), EquipmentId = equipment1.Id, Description = "E101 12000 Hour" };
        var maintenancePlan4 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E102 3000 Hour",  StartDate = DateTime.UtcNow.AddDays(-2), EndDate = DateTime.UtcNow.AddDays(-1), EquipmentId = equipment2.Id, Description = "E102 3000 Hour" };
        var maintenancePlan5 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E102 6000 Hour",  StartDate = DateTime.UtcNow.AddDays(-1), EndDate = DateTime.UtcNow.AddDays(0),  EquipmentId = equipment2.Id, Description = "E102 6000 Hour" };
        var maintenancePlan6 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E102 12000 Hour", StartDate = DateTime.UtcNow.AddDays(0),  EndDate = DateTime.UtcNow.AddDays(1),  EquipmentId = equipment2.Id, Description = "E102 12000 Hour" };
        var maintenancePlan7 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E103 3000 Hour",  StartDate = DateTime.UtcNow.AddDays(1),  EndDate = DateTime.UtcNow.AddDays(2),  EquipmentId = equipment3.Id, Description = "E103 3000 Hour" };
        var maintenancePlan8 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E103 6000 Hour",  StartDate = DateTime.UtcNow.AddDays(2),  EndDate = DateTime.UtcNow.AddDays(3),  EquipmentId = equipment3.Id, Description = "E103 6000 Hour" };
        var maintenancePlan9 = new MaintenancePlan { Id = Guid.NewGuid(), Text = "E103 12000 Hour", StartDate = DateTime.UtcNow.AddDays(3),  EndDate = DateTime.UtcNow.AddDays(4),  EquipmentId = equipment3.Id, Description = "E103 12000 Hour" };
        

        if (!context.MaintenancePlans.Any())
            context.MaintenancePlans.AddRange( maintenancePlan1, maintenancePlan2, maintenancePlan3, maintenancePlan4, maintenancePlan5, maintenancePlan6, maintenancePlan7, maintenancePlan8, maintenancePlan9);

        context.SaveChanges();
    }

}

