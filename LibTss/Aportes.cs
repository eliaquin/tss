namespace LibTss
{
    public class Aportes
    {
        public decimal SalarioMinimoPromedio { get; set; }
        public SFS SFS { get; set; }
        public AFP AFP { get; set; }
        public SRL SRL { get; set; }
    }

    public class SFS
    {
        public decimal Tope { get; set; }
        public decimal Empleador { get; set; }
        public decimal Empleado { get; set; }
    }

    public class AFP
    {
        public decimal Tope { get; set; }
        public decimal Empleador { get; set; }
        public decimal Empleado { get; set; }
    }

    public class SRL
    {
        public decimal Tope { get; set; }
        public decimal Empleador { get; set; }
        public decimal Empleado { get; set; }
    }
}
