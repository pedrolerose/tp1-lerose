using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Adjunto : Base
    {
        public virtual string Descripcion { get; set; }
        public virtual string Comentario { get; set; }
        public virtual string TipoArchivo { get; set; }
        public virtual string Archivo { get; set; }
    }
}
