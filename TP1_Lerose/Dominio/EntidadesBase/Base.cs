using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    public abstract class Base
    {
        public virtual long Id { get; set; }
        public virtual bool Activo { get; set; }
    }
}
