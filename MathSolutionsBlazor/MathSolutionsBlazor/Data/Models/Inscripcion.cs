namespace MathSolutionsBlazor.Data.Models
{
    public class Inscripcion
    {
        public Inscripcion()
        {
            IdEstudiante = -1;
            IdCurso = -1;
        }

        public int IdInscripcion { get; set; }
        public int IdEstudiante { get; set; }
        public int IdCurso { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Estudiante IdEstudianteNavigation { get; set; }

        public string EstNombre(IList<Estudiante> estudiantes)
        {
            string nombreE = estudiantes.Where(Est => Est.IdEstudiante == IdEstudiante).Select(Est => Est.NombreCompleto).FirstOrDefault();
            return nombreE;
        }
        public string CursNombre(IList<Curso> cursos)
        {
            string nombreC = cursos.Where(Curs => Curs.IdCurso == IdCurso).Select(Curs => Curs.Titulo).FirstOrDefault();
            return nombreC;
        }
    }
}
