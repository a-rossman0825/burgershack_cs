
using Microsoft.AspNetCore.Http.HttpResults;

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

  [HttpGet("{burgerId}")]

  public ActionResult<Burger> GetBurgerById(int burgerId)
  {
    try
    {
      Burger burger = _burgersService.GetBurgerById(burgerId);
      return Ok(burger);
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }

  [HttpPost]
  public ActionResult<Burger> CreateNewBurger([FromBody] Burger burgerData)
  {
    try
    {
      Burger burger = _burgersService.CreateNewBurger(burgerData);
      return Ok(burger);
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }

  [HttpDelete]
  public ActionResult<string> DeleteFrog(int burgerId)
  {
    try
    {
      _burgersService.DeleteBurger(burgerId);
      return Ok("Burger was deleted!");
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }
}