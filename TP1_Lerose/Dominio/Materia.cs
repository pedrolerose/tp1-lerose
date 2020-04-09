using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Materia : Base
    {
        public virtual string Nombre { get; set; }
        public virtual string Carrera { get; set; }
    }
}
