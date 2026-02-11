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
            this.btnIniciarMT = new System.Windows.Forms.Button();
            this.txtCabezal = new System.Windows.Forms.TextBox();
            this.lblCabezal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBlanco = new System.Windows.Forms.Button();
            this.txtCinta = new System.Windows.Forms.TextBox();
            this.lblCinta = new System.Windows.Forms.Label();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpDer = new System.Windows.Forms.Button();
            this.btnOpIzq = new System.Windows.Forms.Button();
            this.radEliminarHastaEncontrar = new System.Windows.Forms.RadioButton();
            this.radEliminarDif = new System.Windows.Forms.RadioButton();
            this.radBuscarDif = new System.Windows.Forms.RadioButton();
            this.radEscribirPosAct = new System.Windows.Forms.RadioButton();
            this.radEliminarIgual = new System.Windows.Forms.RadioButton();
            this.radBuscarIgual = new System.Windows.Forms.RadioButton();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCadena = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnADerecha = new System.Windows.Forms.Button();
            this.btnAIzquierda = new System.Windows.Forms.Button();
            this.lblBuscarBt = new System.Windows.Forms.Label();
            this.btnCadBlanco = new System.Windows.Forms.Button();
            this.txtBuscarCadena = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.grpMaquina = new System.Windows.Forms.GroupBox();
            this.ritCompuesta = new System.Windows.Forms.RichTextBox();
            this.lblMTC = new System.Windows.Forms.Label();
            this.dgMT = new System.Windows.Forms.DataGridView();
            this.grpDatos.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.grpCadena.SuspendLayout();
            this.grpMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMT)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnIniciarMT);
            this.grpDatos.Controls.Add(this.txtCabezal);
            this.grpDatos.Controls.Add(this.lblCabezal);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.btnBlanco);
            this.grpDatos.Controls.Add(this.txtCinta);
            this.grpDatos.Controls.Add(this.lblCinta);
            this.grpDatos.Controls.Add(this.txtAlfabeto);
            this.grpDatos.Controls.Add(this.lblAlfabeto);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(200, 363);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // btnIniciarMT
            // 
            this.btnIniciarMT.BackColor = System.Drawing.Color.OrangeRed;
            this.btnIniciarMT.Location = new System.Drawing.Point(6, 208);
            this.btnIniciarMT.Name = "btnIniciarMT";
            this.btnIniciarMT.Size = new System.Drawing.Size(185, 149);
            this.btnIniciarMT.TabIndex = 4;
            this.btnIniciarMT.Text = "Iniciar máquina de Turing";
            this.btnIniciarMT.UseVisualStyleBackColor = false;
            // 
            // txtCabezal
            // 
            this.txtCabezal.Location = new System.Drawing.Point(69, 180);
            this.txtCabezal.Name = "txtCabezal";
            this.txtCabezal.Size = new System.Drawing.Size(41, 22);
            this.txtCabezal.TabIndex = 8;
            // 
            // lblCabezal
            // 
            this.lblCabezal.AutoSize = true;
            this.lblCabezal.Location = new System.Drawing.Point(6, 183);
            this.lblCabezal.Name = "lblCabezal";
            this.lblCabezal.Size = new System.Drawing.Size(57, 16);
            this.lblCabezal.TabIndex = 7;
            this.lblCabezal.Text = "Cabezal";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 147);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBlanco
            // 
            this.btnBlanco.Location = new System.Drawing.Point(9, 118);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(185, 23);
            this.btnBlanco.TabIndex = 4;
            this.btnBlanco.Text = "Insertar Δ";
            this.btnBlanco.UseVisualStyleBackColor = true;
            // 
            // txtCinta
            // 
            this.txtCinta.Location = new System.Drawing.Point(9, 89);
            this.txtCinta.Name = "txtCinta";
            this.txtCinta.Size = new System.Drawing.Size(185, 22);
            this.txtCinta.TabIndex = 3;
            // 
            // lblCinta
            // 
            this.lblCinta.AutoSize = true;
            this.lblCinta.Location = new System.Drawing.Point(6, 70);
            this.lblCinta.Name = "lblCinta";
            this.lblCinta.Size = new System.Drawing.Size(123, 16);
            this.lblCinta.TabIndex = 2;
            this.lblCinta.Text = "Cadena de entrada";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(70, 28);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(124, 22);
            this.txtAlfabeto.TabIndex = 1;
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(6, 31);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(57, 16);
            this.lblAlfabeto.TabIndex = 0;
            this.lblAlfabeto.Text = "Alfabeto";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.label4);
            this.grpOperaciones.Controls.Add(this.label5);
            this.grpOperaciones.Controls.Add(this.btnOpDer);
            this.grpOperaciones.Controls.Add(this.btnOpIzq);
            this.grpOperaciones.Controls.Add(this.radEliminarHastaEncontrar);
            this.grpOperaciones.Controls.Add(this.radEliminarDif);
            this.grpOperaciones.Controls.Add(this.radBuscarDif);
            this.grpOperaciones.Controls.Add(this.radEscribirPosAct);
            this.grpOperaciones.Controls.Add(this.radEliminarIgual);
            this.grpOperaciones.Controls.Add(this.radBuscarIgual);
            this.grpOperaciones.Controls.Add(this.txtSimbolo);
            this.grpOperaciones.Controls.Add(this.label3);
            this.grpOperaciones.Location = new System.Drawing.Point(227, 12);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(411, 363);
            this.grpOperaciones.TabIndex = 1;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Der";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Izq";
            // 
            // btnOpDer
            // 
            this.btnOpDer.Location = new System.Drawing.Point(104, 247);
            this.btnOpDer.Name = "btnOpDer";
            this.btnOpDer.Size = new System.Drawing.Size(53, 43);
            this.btnOpDer.TabIndex = 17;
            this.btnOpDer.Text = "→";
            this.btnOpDer.UseVisualStyleBackColor = true;
            // 
            // btnOpIzq
            // 
            this.btnOpIzq.Location = new System.Drawing.Point(35, 247);
            this.btnOpIzq.Name = "btnOpIzq";
            this.btnOpIzq.Size = new System.Drawing.Size(53, 43);
            this.btnOpIzq.TabIndex = 16;
            this.btnOpIzq.Text = "←";
            this.btnOpIzq.UseVisualStyleBackColor = true;
            // 
            // radEliminarHastaEncontrar
            // 
            this.radEliminarHastaEncontrar.AutoSize = true;
            this.radEliminarHastaEncontrar.Location = new System.Drawing.Point(19, 221);
            this.radEliminarHastaEncontrar.Name = "radEliminarHastaEncontrar";
            this.radEliminarHastaEncontrar.Size = new System.Drawing.Size(177, 20);
            this.radEliminarHastaEncontrar.TabIndex = 14;
            this.radEliminarHastaEncontrar.Text = "Eliminar hasta el símbolo";
            this.radEliminarHastaEncontrar.UseVisualStyleBackColor = true;
            // 
            // radEliminarDif
            // 
            this.radEliminarDif.AutoSize = true;
            this.radEliminarDif.Location = new System.Drawing.Point(19, 195);
            this.radEliminarDif.Name = "radEliminarDif";
            this.radEliminarDif.Size = new System.Drawing.Size(138, 20);
            this.radEliminarDif.TabIndex = 13;
            this.radEliminarDif.Text = "Eliminar diferentes";
            this.radEliminarDif.UseVisualStyleBackColor = true;
            // 
            // radBuscarDif
            // 
            this.radBuscarDif.AutoSize = true;
            this.radBuscarDif.Location = new System.Drawing.Point(19, 169);
            this.radBuscarDif.Name = "radBuscarDif";
            this.radBuscarDif.Size = new System.Drawing.Size(132, 20);
            this.radBuscarDif.TabIndex = 12;
            this.radBuscarDif.Text = "Buscar diferentes";
            this.radBuscarDif.UseVisualStyleBackColor = true;
            // 
            // radEscribirPosAct
            // 
            this.radEscribirPosAct.AutoSize = true;
            this.radEscribirPosAct.Location = new System.Drawing.Point(19, 143);
            this.radEscribirPosAct.Name = "radEscribirPosAct";
            this.radEscribirPosAct.Size = new System.Drawing.Size(184, 20);
            this.radEscribirPosAct.TabIndex = 11;
            this.radEscribirPosAct.Text = "Escribir en posición actual";
            this.radEscribirPosAct.UseVisualStyleBackColor = true;
            // 
            // radEliminarIgual
            // 
            this.radEliminarIgual.AutoSize = true;
            this.radEliminarIgual.Location = new System.Drawing.Point(19, 117);
            this.radEliminarIgual.Name = "radEliminarIgual";
            this.radEliminarIgual.Size = new System.Drawing.Size(159, 20);
            this.radEliminarIgual.TabIndex = 9;
            this.radEliminarIgual.Text = "Eliminar símbolo igual";
            this.radEliminarIgual.UseVisualStyleBackColor = true;
            // 
            // radBuscarIgual
            // 
            this.radBuscarIgual.AutoSize = true;
            this.radBuscarIgual.Location = new System.Drawing.Point(19, 91);
            this.radBuscarIgual.Name = "radBuscarIgual";
            this.radBuscarIgual.Size = new System.Drawing.Size(121, 20);
            this.radBuscarIgual.TabIndex = 8;
            this.radBuscarIgual.Text = "Buscar símbolo";
            this.radBuscarIgual.UseVisualStyleBackColor = true;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(19, 50);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(100, 22);
            this.txtSimbolo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Símbolo";
            // 
            // grpCadena
            // 
            this.grpCadena.Controls.Add(this.label2);
            this.grpCadena.Controls.Add(this.label1);
            this.grpCadena.Controls.Add(this.btnADerecha);
            this.grpCadena.Controls.Add(this.btnAIzquierda);
            this.grpCadena.Controls.Add(this.lblBuscarBt);
            this.grpCadena.Controls.Add(this.btnCadBlanco);
            this.grpCadena.Controls.Add(this.txtBuscarCadena);
            this.grpCadena.Controls.Add(this.lblBuscar);
            this.grpCadena.Location = new System.Drawing.Point(654, 12);
            this.grpCadena.Name = "grpCadena";
            this.grpCadena.Size = new System.Drawing.Size(200, 363);
            this.grpCadena.TabIndex = 2;
            this.grpCadena.TabStop = false;
            this.grpCadena.Text = "Cadena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Der";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Izq";
            // 
            // btnADerecha
            // 
            this.btnADerecha.Location = new System.Drawing.Point(129, 118);
            this.btnADerecha.Name = "btnADerecha";
            this.btnADerecha.Size = new System.Drawing.Size(53, 43);
            this.btnADerecha.TabIndex = 12;
            this.btnADerecha.Text = "→";
            this.btnADerecha.UseVisualStyleBackColor = true;
            // 
            // btnAIzquierda
            // 
            this.btnAIzquierda.Location = new System.Drawing.Point(15, 118);
            this.btnAIzquierda.Name = "btnAIzquierda";
            this.btnAIzquierda.Size = new System.Drawing.Size(53, 43);
            this.btnAIzquierda.TabIndex = 11;
            this.btnAIzquierda.Text = "←";
            this.btnAIzquierda.UseVisualStyleBackColor = true;
            this.btnAIzquierda.Click += new System.EventHandler(this.btnAIzquierda_Click);
            // 
            // lblBuscarBt
            // 
            this.lblBuscarBt.AutoSize = true;
            this.lblBuscarBt.Location = new System.Drawing.Point(74, 131);
            this.lblBuscarBt.Name = "lblBuscarBt";
            this.lblBuscarBt.Size = new System.Drawing.Size(49, 16);
            this.lblBuscarBt.TabIndex = 10;
            this.lblBuscarBt.Text = "Buscar";
            // 
            // btnCadBlanco
            // 
            this.btnCadBlanco.Location = new System.Drawing.Point(18, 76);
            this.btnCadBlanco.Name = "btnCadBlanco";
            this.btnCadBlanco.Size = new System.Drawing.Size(164, 23);
            this.btnCadBlanco.TabIndex = 9;
            this.btnCadBlanco.Text = "Insertar Δ";
            this.btnCadBlanco.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCadena
            // 
            this.txtBuscarCadena.Location = new System.Drawing.Point(18, 48);
            this.txtBuscarCadena.Name = "txtBuscarCadena";
            this.txtBuscarCadena.Size = new System.Drawing.Size(164, 22);
            this.txtBuscarCadena.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(15, 28);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(98, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar cadena";
            // 
            // grpMaquina
            // 
            this.grpMaquina.Controls.Add(this.ritCompuesta);
            this.grpMaquina.Controls.Add(this.lblMTC);
            this.grpMaquina.Controls.Add(this.dgMT);
            this.grpMaquina.Location = new System.Drawing.Point(12, 381);
            this.grpMaquina.Name = "grpMaquina";
            this.grpMaquina.Size = new System.Drawing.Size(842, 199);
            this.grpMaquina.TabIndex = 3;
            this.grpMaquina.TabStop = false;
            this.grpMaquina.Text = "Máquina de Turing";
            // 
            // ritCompuesta
            // 
            this.ritCompuesta.Location = new System.Drawing.Point(9, 124);
            this.ritCompuesta.Name = "ritCompuesta";
            this.ritCompuesta.Size = new System.Drawing.Size(815, 53);
            this.ritCompuesta.TabIndex = 2;
            this.ritCompuesta.Text = "";
            // 
            // lblMTC
            // 
            this.lblMTC.AutoSize = true;
            this.lblMTC.Location = new System.Drawing.Point(6, 105);
            this.lblMTC.Name = "lblMTC";
            this.lblMTC.Size = new System.Drawing.Size(99, 16);
            this.lblMTC.TabIndex = 1;
            this.lblMTC.Text = "MT Compuesta";
            // 
            // dgMT
            // 
            this.dgMT.AllowUserToAddRows = false;
            this.dgMT.AllowUserToDeleteRows = false;
            this.dgMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMT.Location = new System.Drawing.Point(9, 21);
            this.dgMT.Name = "dgMT";
            this.dgMT.ReadOnly = true;
            this.dgMT.RowHeadersWidth = 51;
            this.dgMT.RowTemplate.Height = 24;
            this.dgMT.Size = new System.Drawing.Size(815, 71);
            this.dgMT.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 586);
            this.Controls.Add(this.grpMaquina);
            this.Controls.Add(this.grpCadena);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "SimuladorMT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            this.grpCadena.ResumeLayout(false);
            this.grpCadena.PerformLayout();
            this.grpMaquina.ResumeLayout(false);
            this.grpMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.GroupBox grpCadena;
        private System.Windows.Forms.GroupBox grpMaquina;
        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.TextBox txtCinta;
        private System.Windows.Forms.Label lblCinta;
        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnIniciarMT;
        private System.Windows.Forms.Label lblCabezal;
        private System.Windows.Forms.TextBox txtCabezal;
        private System.Windows.Forms.DataGridView dgMT;
        private System.Windows.Forms.RichTextBox ritCompuesta;
        private System.Windows.Forms.Label lblMTC;
        private System.Windows.Forms.Button btnCadBlanco;
        private System.Windows.Forms.TextBox txtBuscarCadena;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnADerecha;
        private System.Windows.Forms.Button btnAIzquierda;
        private System.Windows.Forms.Label lblBuscarBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radEscribirPosAct;
        private System.Windows.Forms.RadioButton radEliminarIgual;
        private System.Windows.Forms.RadioButton radBuscarIgual;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radEliminarHastaEncontrar;
        private System.Windows.Forms.RadioButton radEliminarDif;
        private System.Windows.Forms.RadioButton radBuscarDif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpDer;
        private System.Windows.Forms.Button btnOpIzq;
    }
}

