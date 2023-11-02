using RazorPages.Modelos;

namespace RazorPages.Services
{
    public interface IAlumnoRepositorio
    {
        IEnumerable<Alumno> GetAllAlumnos();
        Alumno GetAlumno(int id);
        void Update(Alumno alumnoActualizado);
        Alumno Add(Alumno alumnoNuevo);
        Alumno Delete(int id);
        IEnumerable<CursoCuantos> AlumnosPorCurso(Curso? curso);
        IEnumerable<Alumno> Busqueda(String elemntoABuscar);
    }
}