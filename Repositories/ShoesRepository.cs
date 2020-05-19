using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using store.Models;

namespace store.Repositories
{
  public class ShoesRepository
  {
    private readonly IDbConnection _db;

    public ShoesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Shoe> GetAll()
    {
      string sql = "SELECT * FROM books";
      return _db.Query<Shoe>(sql);
    }

    internal Shoe Create(Shoe newShoe)
    {
      string sql = @"
      INSERT INTO shoes
      (Title, Desc, Style, Color, Size, Supply)
      VALUES
      (@Title, @Desc, @Style, @Color, @Size, @Supply);
      SELECT LAST_INSERT_ID()";
      newShoe.Id = _db.ExecuteScalar<int>(sql, newShoe);
      return newShoe;
    }

    internal Shoe GetById(int id)
    {
      string sql = "SELECT * FROM shoes WHERE id = @Id";
      return _db.QueryFirstOrDefault<Shoe>(sql, new { id });
    }

    internal bool Delete(int id)
    {
      string sql = "DELETE FROM shoes WHERE id = @Id LIMIT 1";
      int affectedRows = _db.Execute(sql, new { id });
      return affectedRows == 1;
    }
  }
}