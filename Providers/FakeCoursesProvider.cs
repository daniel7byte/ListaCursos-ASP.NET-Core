using ListaCursos.Interfaces;
using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Providers
{
  public class FakeCoursesProvider : ICoursesProvider
  {
    private readonly List<Course> repo = new List<Course>();
    public FakeCoursesProvider()
    {
      repo.Add(new Course()
      {
        Id = 1,
        Name = "Curso de ASP.NET Escencial",
        Author = "José Daniel Posso García",
        Description = "El mejor curso del mundo",
        Uri = "http://linkedin.com/learning"
      });
      repo.Add(new Course()
      {
        Id = 2,
        Name = "Curso de Python Profesional",
        Author = "José Daniel Posso García",
        Description = "El mejor curso del mundo",
        Uri = "http://linkedin.com/learning"
      });
      repo.Add(new Course()
      {
        Id = 3,
        Name = "Curso de Javascriot Profesional",
        Author = "José Daniel Posso García",
        Description = "El mejor curso del mundo",
        Uri = "http://linkedin.com/learning"
      });
    }

    public Task<ICollection<Course>> GetAllAsync()
    {
      return Task.FromResult((ICollection<Course>)repo.ToList());
    }

    public Task<Course> GetAsync(int id)
    {
      return Task.FromResult(repo.FirstOrDefault(c => c.Id == id));
    }

    public Task<ICollection<Course>> SearchAsync(string search)
    {
      return Task.FromResult((ICollection<Course>)repo.Where(c => c.Name.ToLowerInvariant().Contains(search.ToLowerInvariant())).ToList());
    }

    public Task<bool> UpdateAsync(int id, Course course)
    {
      var courseToUpdate = repo.FirstOrDefault(c => c.Id == id);
      if (courseToUpdate != null)
      {
        courseToUpdate.Name = course.Name;
        courseToUpdate.Description = course.Description;
        courseToUpdate.Author = course.Author;
        courseToUpdate.Uri = course.Uri;

        return Task.FromResult(true);
      }

      return Task.FromResult(false);
    }
  }
}
