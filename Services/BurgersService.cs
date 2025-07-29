


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
}