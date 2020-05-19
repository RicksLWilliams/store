using System;
using System.Collections.Generic;
using store.Models;
using store.Repositories;

namespace store.Services
{
  public class ShoesService
  {
    private readonly ShoesRepository _repo;

    public ShoesService(ShoesRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Shoe> GetAll()
    {
      return _repo.GetAll();
    }

    internal Shoe Create(Shoe newShoe)
    {
      Shoe createdShoe = _repo.Create(newShoe);
      return createdShoe;
    }

    internal Shoe GetById(int id)
    {
      Shoe foundShoe = _repo.GetById(id);
      if (foundShoe == null)
      {
        throw new Exception("Invalid id.");
      }
      return foundShoe;
    }

    internal Shoe Delete(int id)
    {
      Shoe foundShoe = GetById(id);
      if (_repo.Delete(id))
      {
        return foundShoe;
      }
      throw new Exception("Something bad happened...");
    }
  }
}