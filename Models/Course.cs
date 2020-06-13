using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ListaCursos.Models
{
  public class Course
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es requerido")]
    [Display(Name = "Nombre")]
    public string Name { get; set; }
    [MaxLength(500, ErrorMessage = "El maximo de caracteres es 500")]
    [Display(Name = "Descripción")]
    public string Description { get; set; }
    [Display(Name = "Autor")]
    [Required(ErrorMessage = "El autor es requerido")]
    public string Author { get; set; }
    [Url(ErrorMessage = "URL Invalida")]
    [Display(Name = "URL")]
    public string Uri { get; set; }
  }
}
