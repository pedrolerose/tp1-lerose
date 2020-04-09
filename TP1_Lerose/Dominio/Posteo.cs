using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Posteo : Base
    {
        public virtual string Mensaje { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual Adjunto Adjunto { get; set; }
    }
}
