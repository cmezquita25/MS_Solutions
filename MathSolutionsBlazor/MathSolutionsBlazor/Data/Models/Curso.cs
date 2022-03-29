namespace MathSolutionsBlazor.Data.Models
{
    public class Curso
    {
        public Curso()
        {
            Inscripcions = new HashSet<Inscripcion>();
            IdProfesor = -1;
        }

        public int IdCurso { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaCierre { get; set; } = DateTime.Now;
        public string LinkReunion { get; set; }
        public string Material { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
        public int IdProfesor { get; set; }

        public virtual Profesor IdProfesorNavigation { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
        public string ProfNombre(IList<Profesor> profesores)
        {
            string nombre = profesores.Where(Prof => Prof.IdProfesor == IdProfesor).Select(Prof => Prof.NombreCompleto).FirstOrDefault();
            return nombre;
        }
    }

}
