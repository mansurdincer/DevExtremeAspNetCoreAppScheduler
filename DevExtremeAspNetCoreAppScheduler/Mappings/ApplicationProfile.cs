namespace DevExtremeAspNetCoreAppScheduler.Mappings
{
    public class ApplicationProfile :Profile
    {
        public ApplicationProfile()
        {
            CreateMap<MaintenancePlan, MaintenancePlanViewModel>().ReverseMap();
        }
    }
}
