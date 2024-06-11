namespace AnalisisNumerico2024
{
    partial class AjusteCurva
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            cmbMetodo = new ComboBox();
            DeleteAllButton = new Button();
            DeleteLastButton = new Button();
            CalcularButton = new Button();
            CargarButton = new Button();
            panelPuntosIngresados = new Panel();
            txtTolerancia = new TextBox();
            txtY = new TextBox();
            txtX = new TextBox();
            lblPuntosIngresados = new Label();
            lblMetodoAUtilizar = new Label();
            lblTolerancia = new Label();
            lblIngresarPunto = new Label();
            label1 = new Label();
            panelGrafica = new Panel();
            EfectividadAjuste = new Label();
            Correccion = new Label();
            FuncionObtenida = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblGrado = new Label();
            txtGrado = new TextBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 52);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(211, 24);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(211, 24);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtGrado);
            splitContainer1.Panel1.Controls.Add(lblGrado);
            splitContainer1.Panel1.Controls.Add(cmbMetodo);
            splitContainer1.Panel1.Controls.Add(DeleteAllButton);
            splitContainer1.Panel1.Controls.Add(DeleteLastButton);
            splitContainer1.Panel1.Controls.Add(CalcularButton);
            splitContainer1.Panel1.Controls.Add(CargarButton);
            splitContainer1.Panel1.Controls.Add(panelPuntosIngresados);
            splitContainer1.Panel1.Controls.Add(txtTolerancia);
            splitContainer1.Panel1.Controls.Add(txtY);
            splitContainer1.Panel1.Controls.Add(txtX);
            splitContainer1.Panel1.Controls.Add(lblPuntosIngresados);
            splitContainer1.Panel1.Controls.Add(lblMetodoAUtilizar);
            splitContainer1.Panel1.Controls.Add(lblTolerancia);
            splitContainer1.Panel1.Controls.Add(lblIngresarPunto);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelGrafica);
            splitContainer1.Panel2.Controls.Add(EfectividadAjuste);
            splitContainer1.Panel2.Controls.Add(Correccion);
            splitContainer1.Panel2.Controls.Add(FuncionObtenida);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Size = new Size(1073, 715);
            splitContainer1.SplitterDistance = 524;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // cmbMetodo
            // 
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Items.AddRange(new object[] { "Regresión Lineal", "Regresión Polinomial" });
            cmbMetodo.Location = new Point(171, 170);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(134, 28);
            cmbMetodo.TabIndex = 29;
            cmbMetodo.SelectedIndexChanged += cmbMetodo_SelectedIndexChanged;
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.Location = new Point(346, 348);
            DeleteAllButton.Margin = new Padding(3, 4, 3, 4);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(141, 31);
            DeleteAllButton.TabIndex = 28;
            DeleteAllButton.Text = "Borrar Todos";
            DeleteAllButton.UseVisualStyleBackColor = true;
            DeleteAllButton.Click += DeleteAllButton_Click;
            // 
            // DeleteLastButton
            // 
            DeleteLastButton.Location = new Point(346, 275);
            DeleteLastButton.Margin = new Padding(3, 4, 3, 4);
            DeleteLastButton.Name = "DeleteLastButton";
            DeleteLastButton.Size = new Size(141, 31);
            DeleteLastButton.TabIndex = 27;
            DeleteLastButton.Text = "Eliminar Ultimo";
            DeleteLastButton.UseVisualStyleBackColor = true;
            DeleteLastButton.Click += DeleteLastButton_Click;
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(346, 167);
            CalcularButton.Margin = new Padding(3, 4, 3, 4);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(141, 31);
            CalcularButton.TabIndex = 26;
            CalcularButton.Text = "Calcular";
            CalcularButton.UseVisualStyleBackColor = true;
            CalcularButton.Click += CalcularButton_Click_1;
            // 
            // CargarButton
            // 
            CargarButton.Location = new Point(346, 61);
            CargarButton.Margin = new Padding(3, 4, 3, 4);
            CargarButton.Name = "CargarButton";
            CargarButton.Size = new Size(141, 31);
            CargarButton.TabIndex = 25;
            CargarButton.Text = "Cargar Punto";
            CargarButton.UseVisualStyleBackColor = true;
            CargarButton.Click += CargarButton_Click_1;
            // 
            // panelPuntosIngresados
            // 
            panelPuntosIngresados.Location = new Point(177, 231);
            panelPuntosIngresados.Margin = new Padding(3, 4, 3, 4);
            panelPuntosIngresados.Name = "panelPuntosIngresados";
            panelPuntosIngresados.Size = new Size(142, 247);
            panelPuntosIngresados.TabIndex = 24;
            // 
            // txtTolerancia
            // 
            txtTolerancia.Location = new Point(171, 119);
            txtTolerancia.Margin = new Padding(3, 4, 3, 4);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(134, 27);
            txtTolerancia.TabIndex = 22;
            // 
            // txtY
            // 
            txtY.Location = new Point(242, 63);
            txtY.Margin = new Padding(3, 4, 3, 4);
            txtY.Name = "txtY";
            txtY.Size = new Size(63, 27);
            txtY.TabIndex = 21;
            // 
            // txtX
            // 
            txtX.Location = new Point(171, 63);
            txtX.Margin = new Padding(3, 4, 3, 4);
            txtX.Name = "txtX";
            txtX.Size = new Size(63, 27);
            txtX.TabIndex = 20;
            // 
            // lblPuntosIngresados
            // 
            lblPuntosIngresados.AutoSize = true;
            lblPuntosIngresados.Location = new Point(33, 231);
            lblPuntosIngresados.Name = "lblPuntosIngresados";
            lblPuntosIngresados.Size = new Size(132, 20);
            lblPuntosIngresados.TabIndex = 19;
            lblPuntosIngresados.Text = "Puntos Ingresados:";
            // 
            // lblMetodoAUtilizar
            // 
            lblMetodoAUtilizar.AutoSize = true;
            lblMetodoAUtilizar.Location = new Point(39, 170);
            lblMetodoAUtilizar.Name = "lblMetodoAUtilizar";
            lblMetodoAUtilizar.Size = new Size(126, 20);
            lblMetodoAUtilizar.TabIndex = 18;
            lblMetodoAUtilizar.Text = "Método a utilizar:";
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Location = new Point(85, 123);
            lblTolerancia.Name = "lblTolerancia";
            lblTolerancia.Size = new Size(80, 20);
            lblTolerancia.TabIndex = 17;
            lblTolerancia.Text = "Tolerancia:";
            // 
            // lblIngresarPunto
            // 
            lblIngresarPunto.AutoSize = true;
            lblIngresarPunto.Location = new Point(18, 67);
            lblIngresarPunto.Name = "lblIngresarPunto";
            lblIngresarPunto.Size = new Size(149, 20);
            lblIngresarPunto.TabIndex = 16;
            lblIngresarPunto.Text = "Ingresar Punto (X , Y):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 15;
            label1.Text = "Datos de Entrada";
            // 
            // panelGrafica
            // 
            panelGrafica.Location = new Point(18, 231);
            panelGrafica.Margin = new Padding(3, 4, 3, 4);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Size = new Size(512, 468);
            panelGrafica.TabIndex = 7;
            // 
            // EfectividadAjuste
            // 
            EfectividadAjuste.AutoSize = true;
            EfectividadAjuste.Location = new Point(209, 177);
            EfectividadAjuste.Name = "EfectividadAjuste";
            EfectividadAjuste.Size = new Size(21, 20);
            EfectividadAjuste.TabIndex = 6;
            EfectividadAjuste.Text = "--";
            // 
            // Correccion
            // 
            Correccion.AutoSize = true;
            Correccion.Location = new Point(209, 123);
            Correccion.Name = "Correccion";
            Correccion.Size = new Size(21, 20);
            Correccion.TabIndex = 5;
            Correccion.Text = "--";
            // 
            // FuncionObtenida
            // 
            FuncionObtenida.AutoSize = true;
            FuncionObtenida.Location = new Point(209, 67);
            FuncionObtenida.Name = "FuncionObtenida";
            FuncionObtenida.Size = new Size(21, 20);
            FuncionObtenida.TabIndex = 4;
            FuncionObtenida.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 177);
            label9.Name = "label9";
            label9.Size = new Size(153, 20);
            label9.TabIndex = 3;
            label9.Text = "Efectividad del Ajuste";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 119);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 2;
            label8.Text = "Correción (r)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 67);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 1;
            label7.Text = "Función Obtenida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 3);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 0;
            label6.Text = "Datos de Salida";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Location = new Point(346, 122);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(53, 20);
            lblGrado.TabIndex = 30;
            lblGrado.Text = "Grado:";
            lblGrado.Visible = false;
            // 
            // txtGrado
            // 
            txtGrado.Location = new Point(405, 119);
            txtGrado.Margin = new Padding(3, 4, 3, 4);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(63, 27);
            txtGrado.TabIndex = 31;
            txtGrado.Visible = false;
            // 
            // AjusteCurva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 715);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AjusteCurva";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private SplitContainer splitContainer1;
        private Button DeleteAllButton;
        private Button DeleteLastButton;
        private Button CalcularButton;
        private Button CargarButton;
        private Panel panelPuntosIngresados;
        private TextBox txtTolerancia;
        private TextBox txtY;
        private TextBox txtX;
        private Label lblPuntosIngresados;
        private Label lblMetodoAUtilizar;
        private Label lblTolerancia;
        private Label lblIngresarPunto;
        private Label label1;
        private Label label6;
        private Label label8;
        private Label label7;
        private Panel panelGrafica;
        private Label EfectividadAjuste;
        private Label Correccion;
        private Label FuncionObtenida;
        private Label label9;
        private ComboBox cmbMetodo;
        private Label lblGrado;
        private TextBox txtGrado;
    }
}