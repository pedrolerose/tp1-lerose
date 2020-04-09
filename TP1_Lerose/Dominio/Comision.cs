using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Comision : Base
    {
        public virtual Materia Materia { get; set; }
        public virtual Horario Horario { get; set; }
        public virtual int Aula { get; set; }
        public virtual Docente Docente { get; set; }
        public virtual Ayudante Ayudante { get; set; }
        public virtual IList<Alumno> Alumnos { get; set; }
        public virtual IList<Actividad> Actividades { get; set; }
        public virtual IList<Posteo> Posteo { get; set; }
    }
}
