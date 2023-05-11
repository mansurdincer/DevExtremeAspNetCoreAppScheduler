namespace DevExtremeAspNetCoreAppScheduler.Controllers;
public class MaintenancePlansController : Controller
{
    private ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public MaintenancePlansController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public object Get(DataSourceLoadOptions loadOptions)
    {
        var query = _context.MaintenancePlans;
        return DataSourceLoader.Load(query, loadOptions);
    }


    [HttpPost]
    public IActionResult Post(string values)
    {
        var maintenancePlanViewModel = new MaintenancePlanViewModel();
        JsonConvert.PopulateObject(values, maintenancePlanViewModel);

        //map maintenancePlanViewModel to maintenancePlan
        var maintenancePlan = _mapper.Map<MaintenancePlan>(maintenancePlanViewModel);

        //if (!TryValidateModel(maintenancePlan))
        //    return BadRequest();

        _context.MaintenancePlans.Add(maintenancePlan);
        _context.SaveChanges();

        return Ok();
    }

    [HttpPut]
    public IActionResult Put(Guid key, string values)
    {
        var maintenancePlan = _context.MaintenancePlans.First(a => a.Id == key);
        JsonConvert.PopulateObject(values, maintenancePlan);

        if (!TryValidateModel(maintenancePlan))
            return BadRequest();

        _context.SaveChanges();

        return Ok();
    }

    [HttpDelete]
    public void Delete(Guid key)
    {
        var appointment = _context.MaintenancePlans.First(a => a.Id == key);
        _context.MaintenancePlans.Remove(appointment);
        _context.SaveChanges();
    }
}

