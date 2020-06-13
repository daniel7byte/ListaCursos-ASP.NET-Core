using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCursos.Interfaces
{
    interface ICoursesProvider
    {
        Task<ICollection<Course>> GetAllAsync();

        Task<Course> GetAsync(int id);
    }
}
