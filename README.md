# Cálculo de aportes a la TSS
DLL que recibo un salario y devuelve un objeto que incluye los aportes que tienen que realizar tanto el empleador como el empleado a la Tesorería de la Seguridad Social (TSS).

# Uso:

LTSS tss = new LTSS(decimal.Parse(txSueldo.Text));
            var data = tss.Resultados;
            
            txSFSEmpleador.Text = data.SFS.Empleador.ToString("N2");
            txSFSEmpleado.Text = data.SFS.Empleado.ToString("N2");
            txAFPEmpleador.Text = data.AFP.Empleador.ToString("N2");
            txAFPEmpleado.Text = data.AFP.Empleado.ToString("N2");
            txSRLEmpleador.Text = data.SRL.Empleador.ToString("N2");
            txSRLEmpleado.Text = data.SRL.Empleado.ToString("N2");
            
