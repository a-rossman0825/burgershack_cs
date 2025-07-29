

using System.Security.Cryptography.X509Certificates;

namespace burgershack_cs.Repositories;

public class BurgersRepository
{
  private readonly IDbConnection _db;

  public BurgersRepository(IDbConnection db)
  {
    _db = db;
  }
  public List<Burger> GetAllBurgers()
  {
    string sql = "SELECT * FROM burgers;";
    List<Burger> burgers = _db.Query<Burger>(sql).ToList();
    return burgers;
  }

  public Burger GetBurgerById(int burgerId)
  {
    string sql = $"SELECT * FROM burgers WHERE id = @BurgerId;";
    Burger burger = _db.Query<Burger>(sql, new { BurgerId = burgerId }).SingleOrDefault();
    return burger;
  }
}