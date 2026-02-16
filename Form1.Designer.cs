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
            this.btnBlanco = new System.Windows.Forms.Button();
            this.txtCinta = new System.Windows.Forms.TextBox();
            this.lblCinta = new System.Windows.Forms.Label();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.radMoverCelda = new System.Windows.Forms.RadioButton();
            this.btnSimbolo = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.radEliminarXHastaExtremo = new System.Windows.Forms.RadioButton();
            this.radBuscarXHastaExtremo = new System.Windows.Forms.RadioButton();
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
            this.grpMarca = new System.Windows.Forms.GroupBox();
            this.btnRegresarMarca = new System.Windows.Forms.Button();
            this.btnInsertarMarcaInicial = new System.Windows.Forms.Button();
            this.radEliminarDesdePosicion = new System.Windows.Forms.RadioButton();
            this.chkEliminarSimboloRecorrido = new System.Windows.Forms.CheckBox();
            this.grpDatos.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.grpCadena.SuspendLayout();
            this.grpMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMT)).BeginInit();
            this.grpMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnIniciarMT);
            this.grpDatos.Controls.Add(this.txtCabezal);
            this.grpDatos.Controls.Add(this.lblCabezal);
            this.grpDatos.Controls.Add(this.btnBlanco);
            this.grpDatos.Controls.Add(this.txtCinta);
            this.grpDatos.Controls.Add(this.lblCinta);
            this.grpDatos.Controls.Add(this.txtAlfabeto);
            this.grpDatos.Controls.Add(this.lblAlfabeto);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatos.Size = new System.Drawing.Size(200, 363);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // btnIniciarMT
            // 
            this.btnIniciarMT.BackColor = System.Drawing.Color.Turquoise;
            this.btnIniciarMT.Location = new System.Drawing.Point(5, 275);
            this.btnIniciarMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarMT.Name = "btnIniciarMT";
            this.btnIniciarMT.Size = new System.Drawing.Size(185, 82);
            this.btnIniciarMT.TabIndex = 4;
            this.btnIniciarMT.Text = "Iniciar máquina de Turing";
            this.btnIniciarMT.UseVisualStyleBackColor = false;
            this.btnIniciarMT.Click += new System.EventHandler(this.btnIniciarMT_Click);
            // 
            // txtCabezal
            // 
            this.txtCabezal.Location = new System.Drawing.Point(149, 158);
            this.txtCabezal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCabezal.Name = "txtCabezal";
            this.txtCabezal.Size = new System.Drawing.Size(41, 22);
            this.txtCabezal.TabIndex = 8;
            // 
            // lblCabezal
            // 
            this.lblCabezal.AutoSize = true;
            this.lblCabezal.Location = new System.Drawing.Point(11, 161);
            this.lblCabezal.Name = "lblCabezal";
            this.lblCabezal.Size = new System.Drawing.Size(132, 16);
            this.lblCabezal.TabIndex = 7;
            this.lblCabezal.Text = "Posición del cabezal";
            // 
            // btnBlanco
            // 
            this.btnBlanco.Location = new System.Drawing.Point(9, 118);
            this.btnBlanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(185, 23);
            this.btnBlanco.TabIndex = 4;
            this.btnBlanco.Text = "Insertar Δ";
            this.btnBlanco.UseVisualStyleBackColor = true;
            this.btnBlanco.Click += new System.EventHandler(this.btnBlanco_Click);
            // 
            // txtCinta
            // 
            this.txtCinta.Location = new System.Drawing.Point(9, 89);
            this.txtCinta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCinta.Name = "txtCinta";
            this.txtCinta.Size = new System.Drawing.Size(185, 22);
            this.txtCinta.TabIndex = 3;
            // 
            // lblCinta
            // 
            this.lblCinta.AutoSize = true;
            this.lblCinta.Location = new System.Drawing.Point(5, 70);
            this.lblCinta.Name = "lblCinta";
            this.lblCinta.Size = new System.Drawing.Size(123, 16);
            this.lblCinta.TabIndex = 2;
            this.lblCinta.Text = "Cadena de entrada";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(69, 28);
            this.txtAlfabeto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(124, 22);
            this.txtAlfabeto.TabIndex = 1;
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(5, 31);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(57, 16);
            this.lblAlfabeto.TabIndex = 0;
            this.lblAlfabeto.Text = "Alfabeto";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.radEliminarDesdePosicion);
            this.grpOperaciones.Controls.Add(this.radMoverCelda);
            this.grpOperaciones.Controls.Add(this.btnSimbolo);
            this.grpOperaciones.Controls.Add(this.btnEscribir);
            this.grpOperaciones.Controls.Add(this.radEliminarXHastaExtremo);
            this.grpOperaciones.Controls.Add(this.radBuscarXHastaExtremo);
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
            this.grpOperaciones.Location = new System.Drawing.Point(219, 12);
            this.grpOperaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOperaciones.Size = new System.Drawing.Size(429, 363);
            this.grpOperaciones.TabIndex = 1;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones";
            // 
            // radMoverCelda
            // 
            this.radMoverCelda.AutoSize = true;
            this.radMoverCelda.Location = new System.Drawing.Point(19, 94);
            this.radMoverCelda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMoverCelda.Name = "radMoverCelda";
            this.radMoverCelda.Size = new System.Drawing.Size(143, 20);
            this.radMoverCelda.TabIndex = 23;
            this.radMoverCelda.Text = "Moverse una celda";
            this.radMoverCelda.UseVisualStyleBackColor = true;
            // 
            // btnSimbolo
            // 
            this.btnSimbolo.Location = new System.Drawing.Point(141, 50);
            this.btnSimbolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimbolo.Name = "btnSimbolo";
            this.btnSimbolo.Size = new System.Drawing.Size(105, 23);
            this.btnSimbolo.TabIndex = 9;
            this.btnSimbolo.Text = "Insertar Δ";
            this.btnSimbolo.UseVisualStyleBackColor = true;
            this.btnSimbolo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(210, 166);
            this.btnEscribir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(100, 28);
            this.btnEscribir.TabIndex = 22;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // radEliminarXHastaExtremo
            // 
            this.radEliminarXHastaExtremo.AutoSize = true;
            this.radEliminarXHastaExtremo.Location = new System.Drawing.Point(19, 313);
            this.radEliminarXHastaExtremo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEliminarXHastaExtremo.Name = "radEliminarXHastaExtremo";
            this.radEliminarXHastaExtremo.Size = new System.Drawing.Size(166, 36);
            this.radEliminarXHastaExtremo.TabIndex = 21;
            this.radEliminarXHastaExtremo.Text = "Eliminar símbolo hasta \r\nextremo de la cinta";
            this.radEliminarXHastaExtremo.UseVisualStyleBackColor = true;
            this.radEliminarXHastaExtremo.CheckedChanged += new System.EventHandler(this.radEliminarXHastaFinalCinta_CheckedChanged);
            // 
            // radBuscarXHastaExtremo
            // 
            this.radBuscarXHastaExtremo.AutoSize = true;
            this.radBuscarXHastaExtremo.Location = new System.Drawing.Point(19, 273);
            this.radBuscarXHastaExtremo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBuscarXHastaExtremo.Name = "radBuscarXHastaExtremo";
            this.radBuscarXHastaExtremo.Size = new System.Drawing.Size(160, 36);
            this.radBuscarXHastaExtremo.TabIndex = 20;
            this.radBuscarXHastaExtremo.Text = "Buscar símbolo hasta \r\nextremo de la cinta";
            this.radBuscarXHastaExtremo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Der";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Izq";
            // 
            // btnOpDer
            // 
            this.btnOpDer.Location = new System.Drawing.Point(362, 287);
            this.btnOpDer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpDer.Name = "btnOpDer";
            this.btnOpDer.Size = new System.Drawing.Size(53, 43);
            this.btnOpDer.TabIndex = 17;
            this.btnOpDer.Text = "→";
            this.btnOpDer.UseVisualStyleBackColor = true;
            this.btnOpDer.Click += new System.EventHandler(this.btnOpDer_Click);
            // 
            // btnOpIzq
            // 
            this.btnOpIzq.Location = new System.Drawing.Point(293, 287);
            this.btnOpIzq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpIzq.Name = "btnOpIzq";
            this.btnOpIzq.Size = new System.Drawing.Size(53, 43);
            this.btnOpIzq.TabIndex = 16;
            this.btnOpIzq.Text = "←";
            this.btnOpIzq.UseVisualStyleBackColor = true;
            this.btnOpIzq.Click += new System.EventHandler(this.btnOpIzq_Click);
            // 
            // radEliminarHastaEncontrar
            // 
            this.radEliminarHastaEncontrar.AutoSize = true;
            this.radEliminarHastaEncontrar.Location = new System.Drawing.Point(19, 249);
            this.radEliminarHastaEncontrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEliminarHastaEncontrar.Name = "radEliminarHastaEncontrar";
            this.radEliminarHastaEncontrar.Size = new System.Drawing.Size(177, 20);
            this.radEliminarHastaEncontrar.TabIndex = 14;
            this.radEliminarHastaEncontrar.Text = "Eliminar hasta el símbolo";
            this.radEliminarHastaEncontrar.UseVisualStyleBackColor = true;
            // 
            // radEliminarDif
            // 
            this.radEliminarDif.AutoSize = true;
            this.radEliminarDif.Location = new System.Drawing.Point(19, 221);
            this.radEliminarDif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEliminarDif.Name = "radEliminarDif";
            this.radEliminarDif.Size = new System.Drawing.Size(138, 20);
            this.radEliminarDif.TabIndex = 13;
            this.radEliminarDif.Text = "Eliminar diferentes";
            this.radEliminarDif.UseVisualStyleBackColor = true;
            // 
            // radBuscarDif
            // 
            this.radBuscarDif.AutoSize = true;
            this.radBuscarDif.Location = new System.Drawing.Point(19, 196);
            this.radBuscarDif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBuscarDif.Name = "radBuscarDif";
            this.radBuscarDif.Size = new System.Drawing.Size(132, 20);
            this.radBuscarDif.TabIndex = 12;
            this.radBuscarDif.Text = "Buscar diferentes";
            this.radBuscarDif.UseVisualStyleBackColor = true;
            // 
            // radEscribirPosAct
            // 
            this.radEscribirPosAct.AutoSize = true;
            this.radEscribirPosAct.Location = new System.Drawing.Point(19, 170);
            this.radEscribirPosAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEscribirPosAct.Name = "radEscribirPosAct";
            this.radEscribirPosAct.Size = new System.Drawing.Size(184, 20);
            this.radEscribirPosAct.TabIndex = 11;
            this.radEscribirPosAct.Text = "Escribir en posición actual";
            this.radEscribirPosAct.UseVisualStyleBackColor = true;
            // 
            // radEliminarIgual
            // 
            this.radEliminarIgual.AutoSize = true;
            this.radEliminarIgual.Location = new System.Drawing.Point(19, 144);
            this.radEliminarIgual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEliminarIgual.Name = "radEliminarIgual";
            this.radEliminarIgual.Size = new System.Drawing.Size(159, 20);
            this.radEliminarIgual.TabIndex = 9;
            this.radEliminarIgual.Text = "Eliminar símbolo igual";
            this.radEliminarIgual.UseVisualStyleBackColor = true;
            // 
            // radBuscarIgual
            // 
            this.radBuscarIgual.AutoSize = true;
            this.radBuscarIgual.Location = new System.Drawing.Point(19, 118);
            this.radBuscarIgual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBuscarIgual.Name = "radBuscarIgual";
            this.radBuscarIgual.Size = new System.Drawing.Size(121, 20);
            this.radBuscarIgual.TabIndex = 8;
            this.radBuscarIgual.Text = "Buscar símbolo";
            this.radBuscarIgual.UseVisualStyleBackColor = true;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(19, 50);
            this.txtSimbolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(100, 22);
            this.txtSimbolo.TabIndex = 7;
            this.txtSimbolo.TextChanged += new System.EventHandler(this.txtSimbolo_TextChanged);
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
            this.grpCadena.Location = new System.Drawing.Point(653, 12);
            this.grpCadena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadena.Name = "grpCadena";
            this.grpCadena.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadena.Size = new System.Drawing.Size(200, 189);
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
            this.btnADerecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADerecha.Name = "btnADerecha";
            this.btnADerecha.Size = new System.Drawing.Size(53, 43);
            this.btnADerecha.TabIndex = 12;
            this.btnADerecha.Text = "→";
            this.btnADerecha.UseVisualStyleBackColor = true;
            this.btnADerecha.Click += new System.EventHandler(this.btnADerecha_Click);
            // 
            // btnAIzquierda
            // 
            this.btnAIzquierda.Location = new System.Drawing.Point(15, 118);
            this.btnAIzquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblBuscarBt.Location = new System.Drawing.Point(75, 130);
            this.lblBuscarBt.Name = "lblBuscarBt";
            this.lblBuscarBt.Size = new System.Drawing.Size(49, 16);
            this.lblBuscarBt.TabIndex = 10;
            this.lblBuscarBt.Text = "Buscar";
            // 
            // btnCadBlanco
            // 
            this.btnCadBlanco.Location = new System.Drawing.Point(19, 76);
            this.btnCadBlanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadBlanco.Name = "btnCadBlanco";
            this.btnCadBlanco.Size = new System.Drawing.Size(164, 23);
            this.btnCadBlanco.TabIndex = 9;
            this.btnCadBlanco.Text = "Insertar Δ";
            this.btnCadBlanco.UseVisualStyleBackColor = true;
            this.btnCadBlanco.Click += new System.EventHandler(this.btnCadBlanco_Click);
            // 
            // txtBuscarCadena
            // 
            this.txtBuscarCadena.Location = new System.Drawing.Point(19, 48);
            this.txtBuscarCadena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCadena.Name = "txtBuscarCadena";
            this.txtBuscarCadena.Size = new System.Drawing.Size(164, 22);
            this.txtBuscarCadena.TabIndex = 1;
            this.txtBuscarCadena.TextChanged += new System.EventHandler(this.txtBuscarCadena_TextChanged);
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
            this.grpMaquina.Location = new System.Drawing.Point(12, 382);
            this.grpMaquina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMaquina.Name = "grpMaquina";
            this.grpMaquina.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMaquina.Size = new System.Drawing.Size(843, 208);
            this.grpMaquina.TabIndex = 3;
            this.grpMaquina.TabStop = false;
            this.grpMaquina.Text = "Cinta de la Máquina de Turing";
            // 
            // ritCompuesta
            // 
            this.ritCompuesta.Location = new System.Drawing.Point(9, 139);
            this.ritCompuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ritCompuesta.Name = "ritCompuesta";
            this.ritCompuesta.Size = new System.Drawing.Size(815, 53);
            this.ritCompuesta.TabIndex = 2;
            this.ritCompuesta.Text = "";
            // 
            // lblMTC
            // 
            this.lblMTC.AutoSize = true;
            this.lblMTC.Location = new System.Drawing.Point(5, 121);
            this.lblMTC.Name = "lblMTC";
            this.lblMTC.Size = new System.Drawing.Size(224, 16);
            this.lblMTC.TabIndex = 1;
            this.lblMTC.Text = "Compuesta de la Maquina de Turing";
            // 
            // dgMT
            // 
            this.dgMT.AllowUserToAddRows = false;
            this.dgMT.AllowUserToDeleteRows = false;
            this.dgMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMT.Location = new System.Drawing.Point(9, 21);
            this.dgMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMT.MultiSelect = false;
            this.dgMT.Name = "dgMT";
            this.dgMT.ReadOnly = true;
            this.dgMT.RowHeadersVisible = false;
            this.dgMT.RowHeadersWidth = 51;
            this.dgMT.RowTemplate.Height = 24;
            this.dgMT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgMT.Size = new System.Drawing.Size(815, 89);
            this.dgMT.TabIndex = 3;
            this.dgMT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMT_CellContentClick);
            // 
            // grpMarca
            // 
            this.grpMarca.Controls.Add(this.chkEliminarSimboloRecorrido);
            this.grpMarca.Controls.Add(this.btnRegresarMarca);
            this.grpMarca.Controls.Add(this.btnInsertarMarcaInicial);
            this.grpMarca.Location = new System.Drawing.Point(655, 205);
            this.grpMarca.Name = "grpMarca";
            this.grpMarca.Size = new System.Drawing.Size(200, 172);
            this.grpMarca.TabIndex = 4;
            this.grpMarca.TabStop = false;
            this.grpMarca.Text = "Marca inicial";
            // 
            // btnRegresarMarca
            // 
            this.btnRegresarMarca.Location = new System.Drawing.Point(13, 61);
            this.btnRegresarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarMarca.Name = "btnRegresarMarca";
            this.btnRegresarMarca.Size = new System.Drawing.Size(175, 35);
            this.btnRegresarMarca.TabIndex = 16;
            this.btnRegresarMarca.Text = "Regresar a marca inicial";
            this.btnRegresarMarca.UseVisualStyleBackColor = true;
            this.btnRegresarMarca.Click += new System.EventHandler(this.btnRegresarMarca_Click);
            // 
            // btnInsertarMarcaInicial
            // 
            this.btnInsertarMarcaInicial.Location = new System.Drawing.Point(13, 22);
            this.btnInsertarMarcaInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertarMarcaInicial.Name = "btnInsertarMarcaInicial";
            this.btnInsertarMarcaInicial.Size = new System.Drawing.Size(175, 35);
            this.btnInsertarMarcaInicial.TabIndex = 15;
            this.btnInsertarMarcaInicial.Text = "Insertar marca inicial";
            this.btnInsertarMarcaInicial.UseVisualStyleBackColor = true;
            this.btnInsertarMarcaInicial.Click += new System.EventHandler(this.btnInsertarMarcaInicial_Click);
            // 
            // radEliminarDesdePosicion
            // 
            this.radEliminarDesdePosicion.AutoSize = true;
            this.radEliminarDesdePosicion.Location = new System.Drawing.Point(247, 94);
            this.radEliminarDesdePosicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEliminarDesdePosicion.Name = "radEliminarDesdePosicion";
            this.radEliminarDesdePosicion.Size = new System.Drawing.Size(155, 36);
            this.radEliminarDesdePosicion.TabIndex = 24;
            this.radEliminarDesdePosicion.Text = "Eliminar todos desde\r\nla posición actual";
            this.radEliminarDesdePosicion.UseVisualStyleBackColor = true;
            this.radEliminarDesdePosicion.Visible = false;
            // 
            // chkEliminarSimboloRecorrido
            // 
            this.chkEliminarSimboloRecorrido.AutoSize = true;
            this.chkEliminarSimboloRecorrido.Location = new System.Drawing.Point(29, 106);
            this.chkEliminarSimboloRecorrido.Name = "chkEliminarSimboloRecorrido";
            this.chkEliminarSimboloRecorrido.Size = new System.Drawing.Size(138, 36);
            this.chkEliminarSimboloRecorrido.TabIndex = 17;
            this.chkEliminarSimboloRecorrido.Text = "Eliminar símbolos \r\nen recorrido";
            this.chkEliminarSimboloRecorrido.UseVisualStyleBackColor = true;
            this.chkEliminarSimboloRecorrido.CheckedChanged += new System.EventHandler(this.chkEliminarSimboloRecorrido_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 601);
            this.Controls.Add(this.grpMarca);
            this.Controls.Add(this.grpMaquina);
            this.Controls.Add(this.grpCadena);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.grpMarca.ResumeLayout(false);
            this.grpMarca.PerformLayout();
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
        private System.Windows.Forms.RadioButton radEliminarXHastaExtremo;
        private System.Windows.Forms.RadioButton radBuscarXHastaExtremo;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnSimbolo;
        private System.Windows.Forms.GroupBox grpMarca;
        private System.Windows.Forms.RadioButton radMoverCelda;
        private System.Windows.Forms.Button btnRegresarMarca;
        private System.Windows.Forms.Button btnInsertarMarcaInicial;
        private System.Windows.Forms.RadioButton radEliminarDesdePosicion;
        private System.Windows.Forms.CheckBox chkEliminarSimboloRecorrido;
    }
}

