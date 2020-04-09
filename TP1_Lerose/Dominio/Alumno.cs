using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Alumno : Persona
    {
        public virtual InscripcionFinal InscripcionFinal { get; set; }
        public virtual Notas Notas { get; set; }
    }
}
