using LibTss;
using System;
using System.Windows.Forms;

namespace FrmTSS
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal sueldo;
            btnCalcular.Enabled = decimal.TryParse(txSueldo.Text, out sueldo);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LTSS tss = new LTSS(decimal.Parse(txSueldo.Text));
            var data = tss.Resultados;

            txSFSEmpleador.Text = data.SFS.Empleador.ToString("N2");
            txSFSEmpleado.Text = data.SFS.Empleado.ToString("N2");
            txAFPEmpleador.Text = data.AFP.Empleador.ToString("N2");
            txAFPEmpleado.Text = data.AFP.Empleado.ToString("N2");
            txSRLEmpleador.Text = data.SRL.Empleador.ToString("N2");
            txSRLEmpleado.Text = data.SRL.Empleado.ToString("N2");

        }
    }
}
