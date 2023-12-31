using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Services;
using RazorPages.Modelos;

namespace RazorPages1.Pages.Alumnos
{
    public class IndexModel : PageModel
    {
        private readonly IAlumnoRepositorio alumnoRepositorio;
        public IEnumerable<Alumno> Alumnos;

        public string elementoABuscar { get; set; }
        public IndexModel(IAlumnoRepositorio alumnoRepositorio)
        {
            this.alumnoRepositorio = alumnoRepositorio;
        }
        public void OnGet( string elementoABuscar = "")
        {
            Alumnos = alumnoRepositorio.Busqueda(elementoABuscar);
        }
    }
}
