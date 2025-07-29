

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

  public Burger CreateNewBurger(Burger burgerData)
  {
    string sql = @"
  INSERT INTO
    burgers (name, price, toppings, is_lettuce_wrap, sauce, description)
    VALUES(@name, @price, @toppings, @is_lettuce_wrap, @sauce, @description);
    
    SELECT * FROM burgers WHERE id = LAST_INSERT_ID();";

    Burger burger = _db.Query<Burger>(sql, burgerData).SingleOrDefault();
    return burger;
  }

  internal void DeleteBurger(int burgerId)
  {
    string sql = "DELETE FROM burgers WHERE id = @BurgerId Limit 1;";

    int rowsAffected = _db.Execute(sql, new { BurgerId = burgerId });

    if (rowsAffected == 0)
    {
      throw new Exception($"Invalid Id: {burgerId}");
    }
    if (rowsAffected > 1)
    {
      throw new Exception($"{rowsAffected} rows have been deleted!!!!!");
    }

  }
}