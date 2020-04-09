using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lerose.Dominio
{
    class Notas : Base
    {
        public virtual short ParcialUno { get; set; }
        public virtual short ParcialDos { get; set; }
        public virtual short ParcialTres { get; set; }
        public virtual short RecuperatorioUno { get; set; }
        public virtual short RecoperatorioDos { get; set; }
        public virtual short FinalUno { get; set; }
        public virtual short FinalDos { get; set; }
        public virtual short FinalTres { get; set; }
    }
}
