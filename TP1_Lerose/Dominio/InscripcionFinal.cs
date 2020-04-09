using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class InscripcionFinal : Base
    {
        public virtual bool EnCondicion { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual Materia Materia { get; set; }
    }
}
