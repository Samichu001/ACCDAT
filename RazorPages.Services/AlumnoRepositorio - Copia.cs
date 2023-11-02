using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RazorPages.Services
{
    public class AlumnoRepositorio : IAlumnoRepositorio
    {
        public List<Alumno> listaAlumnos;

        public AlumnoRepositorio()
        {
            listaAlumnos = new List<Alumno>()
            {
                new Alumno() {Id= 1, Nombre = "Alberto", CursoID = Cursos.H2, Email = "diego.blas@zaragosa.salesianos.edu", Foto = "Alberto.jpg"},
                new Alumno() {Id= 1, Nombre = "Isma1", CursoID = Cursos.H2, Email = "javier.burillo@zaragosa.salesianos.edu", Foto = "Isma1.jpg"},
                new Alumno() {Id= 1, Nombre = "Ismael2", CursoID = Cursos.H1, Email = "jon.fernandez@zaragosa.salesianos.edu", Foto = "Ismael2.jpg"},
                new Alumno() {Id= 1, Nombre = "Mikel Aramburu", CursoID = Cursos.H1, Email = "david.from@zaragosa.salesianos.edu", Foto = "Mikel.jpg"}
            };
        }

        public Alumno Add(Alumno alumnoNuevo)
        {
            alumnoNuevo.Id = listaAlumnos.Max(a => a.Id) + 1;
            listaAlumnos.Add(alumnoNuevo);
            return alumnoNuevo;
        }

        public IEnumerable<CursoCuantos> AlumnosPorCurso(Curso? curso)
        {
            IEnumerable<Alumno> consulta = listaAlumnos;
            if(curso.HasValue)
            {
                consulta.Where(a => a.CursoID == curso);
            }
            return listaAlumnos.GroupBy(a => a.CursoID)
                .Select(g => new CursoCuantos()
                {
                    Clase = g.Key.Value,
                    NumAlumnos = g.Count()
                }).ToList();
        }

        public IEnumerable<Alumno> Busqueda(String elementoABuscar)
        {
            if(string.IsNullOrEmpty(elementoABuscar))
            {
                return listaAlumnos;
            }
            return listaAlumnos.Where(a => a.Nombre.Contains(elementoABuscar) || a.Email.Contains(elementoABuscar));
        }

        public Alumno Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alumno> GetAllAlumnos()
        {
            return listaAlumnos;
        }

        public Alumno GetAlumno(int id)
        {
            return listaAlumnos.FirstOrDefault(a => a.Id == id);
        }

        public void Update(Alumno alumnoActualizado)
        {
            Alumno alumno = listaAlumnos.FirstOrDefault(a => a.Id == alumnoActualizado.Id);

        }
    }
}
