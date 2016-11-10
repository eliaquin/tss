namespace LibTss
{

    public class Resultados
    {
        public RSFS SFS { get; set; } //Seguro familiar de salud
        public RAFP AFP { get; set; } //Administradora de fondos de pensiones
        public RSRL SRL { get; set; } //Seguro de Riesgos Laborales
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
