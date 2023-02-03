using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;

public class PersonRepository
{
  private readonly DatabaseContext _context;
  
  public PersonRepository(DatabaseContext context)
  {
    this._context = context;
  }

  public Person FindById(int id)
  {
    return _context.People
      .Include(p => p.Contracts)
      .AsNoTracking()
      .SingleOrDefault(p => p.Id == id);
  }

  public List<Person> FindAll()
  {
    return _context.People
      .Include(p => p.Contracts)
      .ToList();
  }

  public void Add(Person person)
  {
    _context.People.Add(person);
    _context.SaveChanges();
  }

  public void Update(Person person)
  {
    _context.People.Update(person);
    _context.SaveChanges();
  }

  public void Remove(Person person)
  {
    _context.People.Remove(person);
    _context.SaveChanges();
  }
}