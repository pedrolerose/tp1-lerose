using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Horario : Base
    {
        public virtual string Turno { get; set; }
        public virtual string Dia { get; set; }
        public virtual DateTime Hora { get; set; }
    }
}
