namespace DevExtremeAspNetCoreAppScheduler.Controllers;

public class EquipmentsController : Controller
{
    private readonly ApplicationDbContext _context;

    public EquipmentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> GetAll()
    {
        var equipments = await _context.Equipments
            .Select(e => new
            {
                e.Id,
                e.Location
            })
            .OrderBy(e => e.Location)
            .ToListAsync();

        //return equipments in json format;
        return Json(equipments);

    }
}
