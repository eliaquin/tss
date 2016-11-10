using Newtonsoft.Json;
using System;
using System.IO;

namespace LibTss
{
    public class LTSS
    {
        decimal Sueldo;
        Aportes Aportes;

        public Resultados Resultados { get; private set; }

        public LTSS(decimal sueldo)
        {
            Sueldo = sueldo;

            if (File.Exists("config.json"))
            {
                try
                {
                    var json = File.ReadAllText("config.json");
                    Aportes = JsonConvert.DeserializeObject<Aportes>(json);
                    Resultados = CalcularResultados();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentException("Archivo de configuración no encontrado.");
            }
        }

        private Resultados CalcularResultados()
        {
            decimal topeCotizableSFS = Aportes.SalarioMinimoPromedio * Aportes.SFS.Tope;
            decimal topeCotizableAFP = Aportes.SalarioMinimoPromedio * Aportes.AFP.Tope;
            decimal topeCotizableSRL = Aportes.SalarioMinimoPromedio * Aportes.SRL.Tope;

            decimal salarioCotizableSFS = topeCotizableSFS > Sueldo ? Sueldo : topeCotizableSFS;
            decimal salarioCotizableAFP = topeCotizableAFP > Sueldo ? Sueldo : topeCotizableAFP;
            decimal salarioCotizableSRL = topeCotizableSRL > Sueldo ? Sueldo : topeCotizableSRL;

            Resultados resultados = new Resultados();

            resultados.SFS = new RSFS();
            resultados.SFS.Empleado = salarioCotizableSFS * Aportes.SFS.Empleado;
            resultados.SFS.Empleador = salarioCotizableSFS * Aportes.SFS.Empleador;

            resultados.AFP = new RAFP();
            resultados.AFP.Empleado = salarioCotizableAFP * Aportes.AFP.Empleado;
            resultados.AFP.Empleador = salarioCotizableAFP * Aportes.AFP.Empleador;

            resultados.SRL = new RSRL();
            resultados.SRL.Empleado = salarioCotizableSRL * Aportes.SRL.Empleado;
            resultados.SRL.Empleador = salarioCotizableSRL * Aportes.SRL.Empleador;

            return resultados;
        }
    }
}
