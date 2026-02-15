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
            this.btnSimbolo = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.radEliminarXHastaFinalCinta = new System.Windows.Forms.RadioButton();
            this.radBuscarHastaFinal = new System.Windows.Forms.RadioButton();
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
            this.grpDatos.Location = new System.Drawing.Point(9, 10);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatos.Size = new System.Drawing.Size(150, 295);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // btnIniciarMT
            // 
            this.btnIniciarMT.BackColor = System.Drawing.Color.OrangeRed;
            this.btnIniciarMT.Location = new System.Drawing.Point(4, 169);
            this.btnIniciarMT.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarMT.Name = "btnIniciarMT";
            this.btnIniciarMT.Size = new System.Drawing.Size(139, 121);
            this.btnIniciarMT.TabIndex = 4;
            this.btnIniciarMT.Text = "Iniciar máquina de Turing";
            this.btnIniciarMT.UseVisualStyleBackColor = false;
            this.btnIniciarMT.Click += new System.EventHandler(this.btnIniciarMT_Click);
            // 
            // txtCabezal
            // 
            this.txtCabezal.Location = new System.Drawing.Point(52, 146);
            this.txtCabezal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCabezal.Name = "txtCabezal";
            this.txtCabezal.Size = new System.Drawing.Size(32, 20);
            this.txtCabezal.TabIndex = 8;
            // 
            // lblCabezal
            // 
            this.lblCabezal.AutoSize = true;
            this.lblCabezal.Location = new System.Drawing.Point(4, 149);
            this.lblCabezal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCabezal.Name = "lblCabezal";
            this.lblCabezal.Size = new System.Drawing.Size(45, 13);
            this.lblCabezal.TabIndex = 7;
            this.lblCabezal.Text = "Cabezal";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 119);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 19);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBlanco
            // 
            this.btnBlanco.Location = new System.Drawing.Point(7, 96);
            this.btnBlanco.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(139, 19);
            this.btnBlanco.TabIndex = 4;
            this.btnBlanco.Text = "Insertar Δ";
            this.btnBlanco.UseVisualStyleBackColor = true;
            this.btnBlanco.Click += new System.EventHandler(this.btnBlanco_Click);
            // 
            // txtCinta
            // 
            this.txtCinta.Location = new System.Drawing.Point(7, 72);
            this.txtCinta.Margin = new System.Windows.Forms.Padding(2);
            this.txtCinta.Name = "txtCinta";
            this.txtCinta.Size = new System.Drawing.Size(140, 20);
            this.txtCinta.TabIndex = 3;
            // 
            // lblCinta
            // 
            this.lblCinta.AutoSize = true;
            this.lblCinta.Location = new System.Drawing.Point(4, 57);
            this.lblCinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCinta.Name = "lblCinta";
            this.lblCinta.Size = new System.Drawing.Size(98, 13);
            this.lblCinta.TabIndex = 2;
            this.lblCinta.Text = "Cadena de entrada";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(52, 23);
            this.txtAlfabeto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(94, 20);
            this.txtAlfabeto.TabIndex = 1;
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(4, 25);
            this.lblAlfabeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(46, 13);
            this.lblAlfabeto.TabIndex = 0;
            this.lblAlfabeto.Text = "Alfabeto";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.btnSimbolo);
            this.grpOperaciones.Controls.Add(this.btnEscribir);
            this.grpOperaciones.Controls.Add(this.radEliminarXHastaFinalCinta);
            this.grpOperaciones.Controls.Add(this.radBuscarHastaFinal);
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
            this.grpOperaciones.Location = new System.Drawing.Point(164, 10);
            this.grpOperaciones.Margin = new System.Windows.Forms.Padding(2);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Padding = new System.Windows.Forms.Padding(2);
            this.grpOperaciones.Size = new System.Drawing.Size(322, 295);
            this.grpOperaciones.TabIndex = 1;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // btnSimbolo
            // 
            this.btnSimbolo.Location = new System.Drawing.Point(106, 41);
            this.btnSimbolo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimbolo.Name = "btnSimbolo";
            this.btnSimbolo.Size = new System.Drawing.Size(79, 19);
            this.btnSimbolo.TabIndex = 9;
            this.btnSimbolo.Text = "Insertar Δ";
            this.btnSimbolo.UseVisualStyleBackColor = true;
            this.btnSimbolo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(206, 155);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 22;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // radEliminarXHastaFinalCinta
            // 
            this.radEliminarXHastaFinalCinta.AutoSize = true;
            this.radEliminarXHastaFinalCinta.Location = new System.Drawing.Point(181, 110);
            this.radEliminarXHastaFinalCinta.Margin = new System.Windows.Forms.Padding(2);
            this.radEliminarXHastaFinalCinta.Name = "radEliminarXHastaFinalCinta";
            this.radEliminarXHastaFinalCinta.Size = new System.Drawing.Size(133, 30);
            this.radEliminarXHastaFinalCinta.TabIndex = 21;
            this.radEliminarXHastaFinalCinta.Text = "Eliminar símbolo hasta \r\nel final de la cinta";
            this.radEliminarXHastaFinalCinta.UseVisualStyleBackColor = true;
            // 
            // radBuscarHastaFinal
            // 
            this.radBuscarHastaFinal.AutoSize = true;
            this.radBuscarHastaFinal.Location = new System.Drawing.Point(181, 72);
            this.radBuscarHastaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.radBuscarHastaFinal.Name = "radBuscarHastaFinal";
            this.radBuscarHastaFinal.Size = new System.Drawing.Size(130, 30);
            this.radBuscarHastaFinal.TabIndex = 20;
            this.radBuscarHastaFinal.Text = "Buscar símbolo hasta \r\nel final de la cinta";
            this.radBuscarHastaFinal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Der";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Izq";
            // 
            // btnOpDer
            // 
            this.btnOpDer.Location = new System.Drawing.Point(78, 201);
            this.btnOpDer.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpDer.Name = "btnOpDer";
            this.btnOpDer.Size = new System.Drawing.Size(40, 35);
            this.btnOpDer.TabIndex = 17;
            this.btnOpDer.Text = "→";
            this.btnOpDer.UseVisualStyleBackColor = true;
            this.btnOpDer.Click += new System.EventHandler(this.btnOpDer_Click);
            // 
            // btnOpIzq
            // 
            this.btnOpIzq.Location = new System.Drawing.Point(26, 201);
            this.btnOpIzq.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpIzq.Name = "btnOpIzq";
            this.btnOpIzq.Size = new System.Drawing.Size(40, 35);
            this.btnOpIzq.TabIndex = 16;
            this.btnOpIzq.Text = "←";
            this.btnOpIzq.UseVisualStyleBackColor = true;
            this.btnOpIzq.Click += new System.EventHandler(this.btnOpIzq_Click);
            // 
            // radEliminarHastaEncontrar
            // 
            this.radEliminarHastaEncontrar.AutoSize = true;
            this.radEliminarHastaEncontrar.Location = new System.Drawing.Point(14, 180);
            this.radEliminarHastaEncontrar.Margin = new System.Windows.Forms.Padding(2);
            this.radEliminarHastaEncontrar.Name = "radEliminarHastaEncontrar";
            this.radEliminarHastaEncontrar.Size = new System.Drawing.Size(141, 17);
            this.radEliminarHastaEncontrar.TabIndex = 14;
            this.radEliminarHastaEncontrar.Text = "Eliminar hasta el símbolo";
            this.radEliminarHastaEncontrar.UseVisualStyleBackColor = true;
            // 
            // radEliminarDif
            // 
            this.radEliminarDif.AutoSize = true;
            this.radEliminarDif.Location = new System.Drawing.Point(14, 158);
            this.radEliminarDif.Margin = new System.Windows.Forms.Padding(2);
            this.radEliminarDif.Name = "radEliminarDif";
            this.radEliminarDif.Size = new System.Drawing.Size(110, 17);
            this.radEliminarDif.TabIndex = 13;
            this.radEliminarDif.Text = "Eliminar diferentes";
            this.radEliminarDif.UseVisualStyleBackColor = true;
            // 
            // radBuscarDif
            // 
            this.radBuscarDif.AutoSize = true;
            this.radBuscarDif.Location = new System.Drawing.Point(14, 137);
            this.radBuscarDif.Margin = new System.Windows.Forms.Padding(2);
            this.radBuscarDif.Name = "radBuscarDif";
            this.radBuscarDif.Size = new System.Drawing.Size(107, 17);
            this.radBuscarDif.TabIndex = 12;
            this.radBuscarDif.Text = "Buscar diferentes";
            this.radBuscarDif.UseVisualStyleBackColor = true;
            // 
            // radEscribirPosAct
            // 
            this.radEscribirPosAct.AutoSize = true;
            this.radEscribirPosAct.Location = new System.Drawing.Point(14, 116);
            this.radEscribirPosAct.Margin = new System.Windows.Forms.Padding(2);
            this.radEscribirPosAct.Name = "radEscribirPosAct";
            this.radEscribirPosAct.Size = new System.Drawing.Size(148, 17);
            this.radEscribirPosAct.TabIndex = 11;
            this.radEscribirPosAct.Text = "Escribir en posición actual";
            this.radEscribirPosAct.UseVisualStyleBackColor = true;
            // 
            // radEliminarIgual
            // 
            this.radEliminarIgual.AutoSize = true;
            this.radEliminarIgual.Location = new System.Drawing.Point(14, 95);
            this.radEliminarIgual.Margin = new System.Windows.Forms.Padding(2);
            this.radEliminarIgual.Name = "radEliminarIgual";
            this.radEliminarIgual.Size = new System.Drawing.Size(126, 17);
            this.radEliminarIgual.TabIndex = 9;
            this.radEliminarIgual.Text = "Eliminar símbolo igual";
            this.radEliminarIgual.UseVisualStyleBackColor = true;
            // 
            // radBuscarIgual
            // 
            this.radBuscarIgual.AutoSize = true;
            this.radBuscarIgual.Location = new System.Drawing.Point(14, 74);
            this.radBuscarIgual.Margin = new System.Windows.Forms.Padding(2);
            this.radBuscarIgual.Name = "radBuscarIgual";
            this.radBuscarIgual.Size = new System.Drawing.Size(98, 17);
            this.radBuscarIgual.TabIndex = 8;
            this.radBuscarIgual.Text = "Buscar símbolo";
            this.radBuscarIgual.UseVisualStyleBackColor = true;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(14, 41);
            this.txtSimbolo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(76, 20);
            this.txtSimbolo.TabIndex = 7;
            this.txtSimbolo.TextChanged += new System.EventHandler(this.txtSimbolo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
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
            this.grpCadena.Location = new System.Drawing.Point(490, 10);
            this.grpCadena.Margin = new System.Windows.Forms.Padding(2);
            this.grpCadena.Name = "grpCadena";
            this.grpCadena.Padding = new System.Windows.Forms.Padding(2);
            this.grpCadena.Size = new System.Drawing.Size(150, 295);
            this.grpCadena.TabIndex = 2;
            this.grpCadena.TabStop = false;
            this.grpCadena.Text = "Cadena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Der";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Izq";
            // 
            // btnADerecha
            // 
            this.btnADerecha.Location = new System.Drawing.Point(97, 96);
            this.btnADerecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnADerecha.Name = "btnADerecha";
            this.btnADerecha.Size = new System.Drawing.Size(40, 35);
            this.btnADerecha.TabIndex = 12;
            this.btnADerecha.Text = "→";
            this.btnADerecha.UseVisualStyleBackColor = true;
            this.btnADerecha.Click += new System.EventHandler(this.btnADerecha_Click);
            // 
            // btnAIzquierda
            // 
            this.btnAIzquierda.Location = new System.Drawing.Point(11, 96);
            this.btnAIzquierda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAIzquierda.Name = "btnAIzquierda";
            this.btnAIzquierda.Size = new System.Drawing.Size(40, 35);
            this.btnAIzquierda.TabIndex = 11;
            this.btnAIzquierda.Text = "←";
            this.btnAIzquierda.UseVisualStyleBackColor = true;
            this.btnAIzquierda.Click += new System.EventHandler(this.btnAIzquierda_Click);
            // 
            // lblBuscarBt
            // 
            this.lblBuscarBt.AutoSize = true;
            this.lblBuscarBt.Location = new System.Drawing.Point(56, 106);
            this.lblBuscarBt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarBt.Name = "lblBuscarBt";
            this.lblBuscarBt.Size = new System.Drawing.Size(40, 13);
            this.lblBuscarBt.TabIndex = 10;
            this.lblBuscarBt.Text = "Buscar";
            // 
            // btnCadBlanco
            // 
            this.btnCadBlanco.Location = new System.Drawing.Point(14, 62);
            this.btnCadBlanco.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadBlanco.Name = "btnCadBlanco";
            this.btnCadBlanco.Size = new System.Drawing.Size(123, 19);
            this.btnCadBlanco.TabIndex = 9;
            this.btnCadBlanco.Text = "Insertar Δ";
            this.btnCadBlanco.UseVisualStyleBackColor = true;
            this.btnCadBlanco.Click += new System.EventHandler(this.btnCadBlanco_Click);
            // 
            // txtBuscarCadena
            // 
            this.txtBuscarCadena.Location = new System.Drawing.Point(14, 39);
            this.txtBuscarCadena.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCadena.Name = "txtBuscarCadena";
            this.txtBuscarCadena.Size = new System.Drawing.Size(124, 20);
            this.txtBuscarCadena.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(11, 23);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(79, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar cadena";
            // 
            // grpMaquina
            // 
            this.grpMaquina.Controls.Add(this.ritCompuesta);
            this.grpMaquina.Controls.Add(this.lblMTC);
            this.grpMaquina.Controls.Add(this.dgMT);
            this.grpMaquina.Location = new System.Drawing.Point(9, 310);
            this.grpMaquina.Margin = new System.Windows.Forms.Padding(2);
            this.grpMaquina.Name = "grpMaquina";
            this.grpMaquina.Padding = new System.Windows.Forms.Padding(2);
            this.grpMaquina.Size = new System.Drawing.Size(632, 169);
            this.grpMaquina.TabIndex = 3;
            this.grpMaquina.TabStop = false;
            this.grpMaquina.Text = "Cinta de la Máquina de Turing";
            // 
            // ritCompuesta
            // 
            this.ritCompuesta.Location = new System.Drawing.Point(7, 113);
            this.ritCompuesta.Margin = new System.Windows.Forms.Padding(2);
            this.ritCompuesta.Name = "ritCompuesta";
            this.ritCompuesta.Size = new System.Drawing.Size(612, 44);
            this.ritCompuesta.TabIndex = 2;
            this.ritCompuesta.Text = "";
            // 
            // lblMTC
            // 
            this.lblMTC.AutoSize = true;
            this.lblMTC.Location = new System.Drawing.Point(4, 98);
            this.lblMTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMTC.Name = "lblMTC";
            this.lblMTC.Size = new System.Drawing.Size(178, 13);
            this.lblMTC.TabIndex = 1;
            this.lblMTC.Text = "Compuesta de la Maquina de Turing";
            // 
            // dgMT
            // 
            this.dgMT.AllowUserToAddRows = false;
            this.dgMT.AllowUserToDeleteRows = false;
            this.dgMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMT.Location = new System.Drawing.Point(7, 17);
            this.dgMT.Margin = new System.Windows.Forms.Padding(2);
            this.dgMT.MultiSelect = false;
            this.dgMT.Name = "dgMT";
            this.dgMT.ReadOnly = true;
            this.dgMT.RowHeadersVisible = false;
            this.dgMT.RowHeadersWidth = 51;
            this.dgMT.RowTemplate.Height = 24;
            this.dgMT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgMT.Size = new System.Drawing.Size(611, 72);
            this.dgMT.TabIndex = 3;
            this.dgMT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMT_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 488);
            this.Controls.Add(this.grpMaquina);
            this.Controls.Add(this.grpCadena);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.RadioButton radEliminarXHastaFinalCinta;
        private System.Windows.Forms.RadioButton radBuscarHastaFinal;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnSimbolo;
    }
}

