using Microsoft.AspNetCore.Mvc;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPages1.Components
{
    public class AlumnoCursoViewComponent : ViewComponent
    {
        public IAlumnoRepositorio AlumnoRepositorio { get; }

        public AlumnoCursoViewComponent(IAlumnoRepositorio alumnoRepositorio)
        {
            AlumnoRepositorio = alumnoRepositorio;
        }

        public IViewComponentResult Invoke(Curso? curso = null) //El = es para asignar al parametro el valor que queramos en caso de que no reciba nada
        {
            var resultado = AlumnoRepositorio.AlumnosPorCurso(curso);
            return View(resultado);
        }
    }
}
