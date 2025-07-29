
namespace burgershack_cs.Controllers;

[ApiController]
[Route("api/burgers")]
public class BurgersController : ControllerBase
{
  private readonly BurgersService _burgersService;

  public BurgersController(BurgersService burgersService)
  {
    _burgersService = burgersService;
  }

  [HttpGet]
  public ActionResult<List<Burger>> GetAllBurgers()
  {
    try
    {
      List<Burger> burgers = _burgersService.GetAllBurgers();
      return Ok(burgers);
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }
}