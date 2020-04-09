using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Docente : Persona
    {
        public virtual Materia Materia { get; set; }
    }
}
