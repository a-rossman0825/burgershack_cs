



namespace burgershack_cs.Services;

public class BurgersService
{
  private readonly BurgersRepository _repository;
  public BurgersService(BurgersRepository repository)
  {
    _repository = repository;
  }

  public List<Burger> GetAllBurgers()
  {
    List<Burger> burgers = _repository.GetAllBurgers();
    return burgers;
  }

  public Burger GetBurgerById(int burgerId)
  {
    Burger burger = _repository.GetBurgerById(burgerId);
    if (burger == null)
    {
      throw new Exception($"Invalid id: {burgerId}");
    }
    return burger;
  }

  public Burger CreateNewBurger(Burger burgerData)
  {
    Burger burger = _repository.CreateNewBurger(burgerData);
    return burger;
  }

  internal void DeleteBurger(int burgerId)
  {
    _repository.DeleteBurger(burgerId);
  }
}