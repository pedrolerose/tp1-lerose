using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    public abstract class Persona : Base
    {
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual long Documento { get; set; }
        public virtual long Telefono { get; set; }
    }
}
