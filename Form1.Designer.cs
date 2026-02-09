namespace SimuladorMaquinaTuring
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.grpCadena = new System.Windows.Forms.GroupBox();
            this.grpMaquina = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(200, 409);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Location = new System.Drawing.Point(227, 12);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(704, 409);
            this.grpOperaciones.TabIndex = 1;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // grpCadena
            // 
            this.grpCadena.Location = new System.Drawing.Point(950, 12);
            this.grpCadena.Name = "grpCadena";
            this.grpCadena.Size = new System.Drawing.Size(200, 409);
            this.grpCadena.TabIndex = 2;
            this.grpCadena.TabStop = false;
            this.grpCadena.Text = "Cadena";
            // 
            // grpMaquina
            // 
            this.grpMaquina.Location = new System.Drawing.Point(12, 427);
            this.grpMaquina.Name = "grpMaquina";
            this.grpMaquina.Size = new System.Drawing.Size(1138, 175);
            this.grpMaquina.TabIndex = 3;
            this.grpMaquina.TabStop = false;
            this.grpMaquina.Text = "Máquina de Turing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 614);
            this.Controls.Add(this.grpMaquina);
            this.Controls.Add(this.grpCadena);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "SimuladorMT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.GroupBox grpCadena;
        private System.Windows.Forms.GroupBox grpMaquina;
    }
}

