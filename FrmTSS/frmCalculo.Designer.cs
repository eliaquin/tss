namespace FrmTSS
{
    partial class frmCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txSueldo = new System.Windows.Forms.TextBox();
            this.txSFSEmpleado = new System.Windows.Forms.TextBox();
            this.txSFSEmpleador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txAFPEmpleador = new System.Windows.Forms.TextBox();
            this.txAFPEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txSRLEmpleador = new System.Windows.Forms.TextBox();
            this.txSRLEmpleado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(172, 7);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txSueldo
            // 
            this.txSueldo.Location = new System.Drawing.Point(11, 9);
            this.txSueldo.Name = "txSueldo";
            this.txSueldo.Size = new System.Drawing.Size(157, 20);
            this.txSueldo.TabIndex = 1;
            this.txSueldo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txSFSEmpleado
            // 
            this.txSFSEmpleado.Location = new System.Drawing.Point(147, 53);
            this.txSFSEmpleado.Name = "txSFSEmpleado";
            this.txSFSEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txSFSEmpleado.TabIndex = 2;
            // 
            // txSFSEmpleador
            // 
            this.txSFSEmpleador.Location = new System.Drawing.Point(41, 53);
            this.txSFSEmpleador.Name = "txSFSEmpleador";
            this.txSFSEmpleador.Size = new System.Drawing.Size(100, 20);
            this.txSFSEmpleador.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SFS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empleador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "AFP";
            // 
            // txAFPEmpleador
            // 
            this.txAFPEmpleador.Location = new System.Drawing.Point(41, 79);
            this.txAFPEmpleador.Name = "txAFPEmpleador";
            this.txAFPEmpleador.Size = new System.Drawing.Size(100, 20);
            this.txAFPEmpleador.TabIndex = 8;
            // 
            // txAFPEmpleado
            // 
            this.txAFPEmpleado.Location = new System.Drawing.Point(147, 79);
            this.txAFPEmpleado.Name = "txAFPEmpleado";
            this.txAFPEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txAFPEmpleado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SRL";
            // 
            // txSRLEmpleador
            // 
            this.txSRLEmpleador.Location = new System.Drawing.Point(41, 105);
            this.txSRLEmpleador.Name = "txSRLEmpleador";
            this.txSRLEmpleador.Size = new System.Drawing.Size(100, 20);
            this.txSRLEmpleador.TabIndex = 11;
            // 
            // txSRLEmpleado
            // 
            this.txSRLEmpleado.Location = new System.Drawing.Point(147, 105);
            this.txSRLEmpleado.Name = "txSRLEmpleado";
            this.txSRLEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txSRLEmpleado.TabIndex = 10;
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 134);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txSRLEmpleador);
            this.Controls.Add(this.txSRLEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txAFPEmpleador);
            this.Controls.Add(this.txAFPEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txSFSEmpleador);
            this.Controls.Add(this.txSFSEmpleado);
            this.Controls.Add(this.txSueldo);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmCalculo";
            this.Text = "Cálculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txSueldo;
        private System.Windows.Forms.TextBox txSFSEmpleado;
        private System.Windows.Forms.TextBox txSFSEmpleador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txAFPEmpleador;
        private System.Windows.Forms.TextBox txAFPEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSRLEmpleador;
        private System.Windows.Forms.TextBox txSRLEmpleado;
    }
}

