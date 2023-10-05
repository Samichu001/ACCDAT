using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPages1.Pages.Alumnos
{
    public class EditModel : PageModel
    {
        private readonly IAlumnoRepositorio AlumnoRepositorio;
        public Alumno alumno { get; set; }
        public EditModel(IAlumnoRepositorio alumnorepositorio, IWebHostEnvironment webHostEnvironment)
        {
            this.AlumnoRepositorio = alumnorepositorio;
            WebHostEnvironment = webHostEnvironment;
        }
        public void OnGet(int? id)
        {
            if (id.HasValue)  //misma sintaxis que (id == null) da un booleano si es cierto o no
            {
                alumno = AlumnoRepositorio.GetAlumno(id.Value);
            }
            else
            {
                alumno = new Alumno();
            }
        }
        public IActionResult OnPost(Alumno alumno)
        {
            if(Photo != null)
            {
                if(alumno.Photo != null)
                {

                }
            }
        }
    }
}
