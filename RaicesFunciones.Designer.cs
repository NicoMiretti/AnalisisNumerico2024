namespace AnalisisNumerico2024
{
    partial class RaicesFunciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            btnBiseccion = new Button();
            btnReglaFalsa = new Button();
            btnTangente = new Button();
            btnSecante = new Button();
            seleccioneMetodo = new Label();
            metodosCerrados = new Label();
            metodosAbiertos = new Label();
            lblMetodoSeleccionado = new Label();
            lblMetodoSelecc = new Label();
            IngreseLosDatos = new Label();
            lblFx = new Label();
            txtFuncion = new TextBox();
            txtXi = new TextBox();
            lblXi = new Label();
            txtXd = new TextBox();
            lblXd = new Label();
            txtTolerancia = new TextBox();
            lblTolerancia = new Label();
            txtIteracionesMax = new TextBox();
            lblIteracionesMax = new Label();
            lblConverge = new Label();
            txtConverge = new TextBox();
            txtCantIteraciones = new TextBox();
            lblCantIteraciones = new Label();
            txtRaiz = new TextBox();
            lblRaiz = new Label();
            txtErrorRelativ = new TextBox();
            lblErrorRelativ = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(298, 279);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(174, 28);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBiseccion
            // 
            btnBiseccion.Location = new Point(32, 57);
            btnBiseccion.Name = "btnBiseccion";
            btnBiseccion.Size = new Size(160, 45);
            btnBiseccion.TabIndex = 1;
            btnBiseccion.Text = "Bisección";
            btnBiseccion.UseVisualStyleBackColor = true;
            btnBiseccion.Click += btnBiseccion_Click;
            // 
            // btnReglaFalsa
            // 
            btnReglaFalsa.Location = new Point(198, 57);
            btnReglaFalsa.Name = "btnReglaFalsa";
            btnReglaFalsa.Size = new Size(160, 45);
            btnReglaFalsa.TabIndex = 2;
            btnReglaFalsa.Text = "Regla Falsa";
            btnReglaFalsa.UseVisualStyleBackColor = true;
            btnReglaFalsa.Click += btnReglaFalsa_Click;
            // 
            // btnTangente
            // 
            btnTangente.Location = new Point(423, 57);
            btnTangente.Name = "btnTangente";
            btnTangente.Size = new Size(160, 45);
            btnTangente.TabIndex = 3;
            btnTangente.Text = "Tangente";
            btnTangente.UseVisualStyleBackColor = true;
            btnTangente.Click += btnTangente_Click;
            // 
            // btnSecante
            // 
            btnSecante.Location = new Point(589, 57);
            btnSecante.Name = "btnSecante";
            btnSecante.Size = new Size(160, 45);
            btnSecante.TabIndex = 4;
            btnSecante.Text = "Secante";
            btnSecante.UseVisualStyleBackColor = true;
            btnSecante.Click += btnSecante_Click;
            // 
            // seleccioneMetodo
            // 
            seleccioneMetodo.AutoSize = true;
            seleccioneMetodo.Location = new Point(32, 21);
            seleccioneMetodo.Name = "seleccioneMetodo";
            seleccioneMetodo.Size = new Size(136, 15);
            seleccioneMetodo.TabIndex = 5;
            seleccioneMetodo.Text = "1) Seleccione el método:";
            // 
            // metodosCerrados
            // 
            metodosCerrados.AutoSize = true;
            metodosCerrados.Location = new Point(145, 39);
            metodosCerrados.Name = "metodosCerrados";
            metodosCerrados.Size = new Size(102, 15);
            metodosCerrados.TabIndex = 6;
            metodosCerrados.Text = "Metodos cerrados";
            // 
            // metodosAbiertos
            // 
            metodosAbiertos.AutoSize = true;
            metodosAbiertos.Location = new Point(536, 39);
            metodosAbiertos.Name = "metodosAbiertos";
            metodosAbiertos.Size = new Size(99, 15);
            metodosAbiertos.TabIndex = 7;
            metodosAbiertos.Text = "Metodos abiertos";
            // 
            // lblMetodoSeleccionado
            // 
            lblMetodoSeleccionado.AutoSize = true;
            lblMetodoSeleccionado.Location = new Point(162, 249);
            lblMetodoSeleccionado.Name = "lblMetodoSeleccionado";
            lblMetodoSeleccionado.Size = new Size(171, 15);
            lblMetodoSeleccionado.TabIndex = 8;
            lblMetodoSeleccionado.Text = "No seleccionó ningún método.";
            // 
            // lblMetodoSelecc
            // 
            lblMetodoSelecc.AutoSize = true;
            lblMetodoSelecc.Location = new Point(32, 249);
            lblMetodoSelecc.Name = "lblMetodoSelecc";
            lblMetodoSelecc.Size = new Size(124, 15);
            lblMetodoSelecc.TabIndex = 9;
            lblMetodoSelecc.Text = "Método seleccionado:";
            // 
            // IngreseLosDatos
            // 
            IngreseLosDatos.AutoSize = true;
            IngreseLosDatos.Location = new Point(32, 127);
            IngreseLosDatos.Name = "IngreseLosDatos";
            IngreseLosDatos.Size = new Size(167, 15);
            IngreseLosDatos.TabIndex = 10;
            IngreseLosDatos.Text = "2) Ingrese los siguientes datos:";
            // 
            // lblFx
            // 
            lblFx.AutoSize = true;
            lblFx.Location = new Point(68, 156);
            lblFx.Name = "lblFx";
            lblFx.Size = new Size(39, 15);
            lblFx.TabIndex = 11;
            lblFx.Text = "F(X) =";
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(113, 153);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(210, 23);
            txtFuncion.TabIndex = 12;
            // 
            // txtXi
            // 
            txtXi.Location = new Point(113, 194);
            txtXi.Name = "txtXi";
            txtXi.Size = new Size(79, 23);
            txtXi.TabIndex = 14;
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Location = new Point(79, 197);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(28, 15);
            lblXi.TabIndex = 13;
            lblXi.Text = "Xi =";
            // 
            // txtXd
            // 
            txtXd.Location = new Point(244, 194);
            txtXd.Name = "txtXd";
            txtXd.Size = new Size(79, 23);
            txtXd.TabIndex = 16;
            // 
            // lblXd
            // 
            lblXd.AutoSize = true;
            lblXd.Location = new Point(206, 197);
            lblXd.Name = "lblXd";
            lblXd.Size = new Size(32, 15);
            lblXd.TabIndex = 15;
            lblXd.Text = "Xd =";
            // 
            // txtTolerancia
            // 
            txtTolerancia.Location = new Point(477, 153);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(112, 23);
            txtTolerancia.TabIndex = 18;
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Location = new Point(400, 156);
            lblTolerancia.Name = "lblTolerancia";
            lblTolerancia.Size = new Size(71, 15);
            lblTolerancia.TabIndex = 17;
            lblTolerancia.Text = "Tolerancia =";
            // 
            // txtIteracionesMax
            // 
            txtIteracionesMax.Location = new Point(511, 194);
            txtIteracionesMax.Name = "txtIteracionesMax";
            txtIteracionesMax.Size = new Size(79, 23);
            txtIteracionesMax.TabIndex = 20;
            // 
            // lblIteracionesMax
            // 
            lblIteracionesMax.AutoSize = true;
            lblIteracionesMax.Location = new Point(401, 197);
            lblIteracionesMax.Name = "lblIteracionesMax";
            lblIteracionesMax.Size = new Size(104, 15);
            lblIteracionesMax.TabIndex = 19;
            lblIteracionesMax.Text = "Iteraciones máx. =";
            // 
            // lblConverge
            // 
            lblConverge.AutoSize = true;
            lblConverge.Location = new Point(177, 342);
            lblConverge.Name = "lblConverge";
            lblConverge.Size = new Size(61, 15);
            lblConverge.TabIndex = 21;
            lblConverge.Text = "Converge:";
            // 
            // txtConverge
            // 
            txtConverge.Location = new Point(244, 339);
            txtConverge.Name = "txtConverge";
            txtConverge.ReadOnly = true;
            txtConverge.Size = new Size(115, 23);
            txtConverge.TabIndex = 22;
            // 
            // txtCantIteraciones
            // 
            txtCantIteraciones.Location = new Point(280, 377);
            txtCantIteraciones.Name = "txtCantIteraciones";
            txtCantIteraciones.ReadOnly = true;
            txtCantIteraciones.Size = new Size(79, 23);
            txtCantIteraciones.TabIndex = 24;
            // 
            // lblCantIteraciones
            // 
            lblCantIteraciones.AutoSize = true;
            lblCantIteraciones.Location = new Point(176, 380);
            lblCantIteraciones.Name = "lblCantIteraciones";
            lblCantIteraciones.Size = new Size(98, 15);
            lblCantIteraciones.TabIndex = 23;
            lblCantIteraciones.Text = "Cant. Iteraciones:";
            // 
            // txtRaiz
            // 
            txtRaiz.Location = new Point(462, 339);
            txtRaiz.Name = "txtRaiz";
            txtRaiz.ReadOnly = true;
            txtRaiz.Size = new Size(108, 23);
            txtRaiz.TabIndex = 25;
            // 
            // lblRaiz
            // 
            lblRaiz.AutoSize = true;
            lblRaiz.Location = new Point(395, 342);
            lblRaiz.Name = "lblRaiz";
            lblRaiz.Size = new Size(61, 15);
            lblRaiz.TabIndex = 26;
            lblRaiz.Text = "Raíz (Xr) =";
            // 
            // txtErrorRelativ
            // 
            txtErrorRelativ.Location = new Point(477, 377);
            txtErrorRelativ.Name = "txtErrorRelativ";
            txtErrorRelativ.ReadOnly = true;
            txtErrorRelativ.Size = new Size(93, 23);
            txtErrorRelativ.TabIndex = 28;
            // 
            // lblErrorRelativ
            // 
            lblErrorRelativ.AutoSize = true;
            lblErrorRelativ.Location = new Point(395, 380);
            lblErrorRelativ.Name = "lblErrorRelativ";
            lblErrorRelativ.Size = new Size(76, 15);
            lblErrorRelativ.TabIndex = 27;
            lblErrorRelativ.Text = "Error Relativ.:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtErrorRelativ);
            Controls.Add(lblErrorRelativ);
            Controls.Add(lblRaiz);
            Controls.Add(txtRaiz);
            Controls.Add(txtCantIteraciones);
            Controls.Add(lblCantIteraciones);
            Controls.Add(txtConverge);
            Controls.Add(lblConverge);
            Controls.Add(txtIteracionesMax);
            Controls.Add(lblIteracionesMax);
            Controls.Add(txtTolerancia);
            Controls.Add(lblTolerancia);
            Controls.Add(txtXd);
            Controls.Add(lblXd);
            Controls.Add(txtXi);
            Controls.Add(lblXi);
            Controls.Add(txtFuncion);
            Controls.Add(lblFx);
            Controls.Add(IngreseLosDatos);
            Controls.Add(lblMetodoSelecc);
            Controls.Add(lblMetodoSeleccionado);
            Controls.Add(metodosAbiertos);
            Controls.Add(metodosCerrados);
            Controls.Add(seleccioneMetodo);
            Controls.Add(btnSecante);
            Controls.Add(btnTangente);
            Controls.Add(btnReglaFalsa);
            Controls.Add(btnBiseccion);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnBiseccion;
        private Button btnReglaFalsa;
        private Button btnTangente;
        private Button btnSecante;
        private Label seleccioneMetodo;
        private Label metodosCerrados;
        private Label metodosAbiertos;
        private Label lblMetodoSeleccionado;
        private Label lblMetodoSelecc;
        private Label IngreseLosDatos;
        private Label lblFx;
        private TextBox txtFuncion;
        private TextBox txtXi;
        private Label lblXi;
        private TextBox txtXd;
        private Label lblXd;
        private TextBox txtTolerancia;
        private Label lblTolerancia;
        private TextBox txtIteracionesMax;
        private Label lblIteracionesMax;
        private Label lblConverge;
        private TextBox txtConverge;
        private TextBox txtCantIteraciones;
        private Label lblCantIteraciones;
        private TextBox txtRaiz;
        private Label lblRaiz;
        private TextBox txtErrorRelativ;
        private Label lblErrorRelativ;
    }
}