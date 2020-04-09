using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Actividad : Base
    {
        public virtual string Descripcion { get; set; }
        public virtual short Nota { get; set; }
        public virtual DateTime FechaInicio { get; set; }
        public virtual DateTime FechaFin { get; set; }
        public virtual Adjunto Adjunto { get; set; }
    }
}
