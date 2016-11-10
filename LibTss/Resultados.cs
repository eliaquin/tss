using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTss
{

    public class Resultados
    {
        public RSFS SFS { get; set; }
        public RAFP AFP { get; set; }
        public RSRL SRL { get; set; }
    }

    public class RSFS
    {
        public decimal Empleador { get; set; }
        public decimal Empleado { get; set; }
    }

    public class RAFP
    {
        public decimal Empleador { get; set; }
        public decimal Empleado { get; set; }
    }

    public class RSRL
    {
        public decimal Empleador { get; set; }
        public decimal Empleado { get; set; }
    }
}
