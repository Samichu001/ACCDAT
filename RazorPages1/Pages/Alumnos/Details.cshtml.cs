using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPages1.Pages.Alumnos
{
    public class DetailsModel : PageModel
    {
        private readonly IAlumnoRepositorio AlumnoRepositorio;
        public Alumno alumno { get; set; }
        public DetailsModel(IAlumnoRepositorio alumnorepositorio)
        {
            this.AlumnoRepositorio = alumnorepositorio;
        }
        public void OnGet(int id)
        {
            alumno = AlumnoRepositorio.GetAlumno(id);
        }
    }
}