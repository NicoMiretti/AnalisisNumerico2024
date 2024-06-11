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
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
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
            splitContainer1.Size = new Size(939, 536);
            splitContainer1.SplitterDistance = 459;
            splitContainer1.TabIndex = 1;
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.Location = new Point(303, 261);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(123, 23);
            DeleteAllButton.TabIndex = 28;
            DeleteAllButton.Text = "Borrar Todos";
            DeleteAllButton.UseVisualStyleBackColor = true;
            DeleteAllButton.Click += DeleteAllButton_Click;
            // 
            // DeleteLastButton
            // 
            DeleteLastButton.Location = new Point(303, 206);
            DeleteLastButton.Name = "DeleteLastButton";
            DeleteLastButton.Size = new Size(123, 23);
            DeleteLastButton.TabIndex = 27;
            DeleteLastButton.Text = "Eliminar Ultimo";
            DeleteLastButton.UseVisualStyleBackColor = true;
            DeleteLastButton.Click += DeleteLastButton_Click;
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(303, 125);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(123, 23);
            CalcularButton.TabIndex = 26;
            CalcularButton.Text = "Calcular";
            CalcularButton.UseVisualStyleBackColor = true;
            // 
            // CargarButton
            // 
            CargarButton.Location = new Point(303, 46);
            CargarButton.Name = "CargarButton";
            CargarButton.Size = new Size(123, 23);
            CargarButton.TabIndex = 25;
            CargarButton.Text = "Cargar Punto";
            CargarButton.UseVisualStyleBackColor = true;
            CargarButton.Click += CargarButton_Click_1;
            // 
            // panelPuntosIngresados
            // 
            panelPuntosIngresados.Location = new Point(155, 173);
            panelPuntosIngresados.Name = "panelPuntosIngresados";
            panelPuntosIngresados.Size = new Size(124, 185);
            panelPuntosIngresados.TabIndex = 24;
            // 
            // txtTolerancia
            // 
            txtTolerancia.Location = new Point(150, 89);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(118, 23);
            txtTolerancia.TabIndex = 22;
            // 
            // txtY
            // 
            txtY.Location = new Point(212, 47);
            txtY.Name = "txtY";
            txtY.Size = new Size(56, 23);
            txtY.TabIndex = 21;
            // 
            // txtX
            // 
            txtX.Location = new Point(150, 47);
            txtX.Name = "txtX";
            txtX.Size = new Size(56, 23);
            txtX.TabIndex = 20;
            // 
            // lblPuntosIngresados
            // 
            lblPuntosIngresados.AutoSize = true;
            lblPuntosIngresados.Location = new Point(35, 173);
            lblPuntosIngresados.Name = "lblPuntosIngresados";
            lblPuntosIngresados.Size = new Size(107, 15);
            lblPuntosIngresados.TabIndex = 19;
            lblPuntosIngresados.Text = "Puntos Ingresados:";
            // 
            // lblMetodoAUtilizar
            // 
            lblMetodoAUtilizar.AutoSize = true;
            lblMetodoAUtilizar.Location = new Point(41, 129);
            lblMetodoAUtilizar.Name = "lblMetodoAUtilizar";
            lblMetodoAUtilizar.Size = new Size(99, 15);
            lblMetodoAUtilizar.TabIndex = 18;
            lblMetodoAUtilizar.Text = "Método a utilizar:";
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Location = new Point(74, 92);
            lblTolerancia.Name = "lblTolerancia";
            lblTolerancia.Size = new Size(63, 15);
            lblTolerancia.TabIndex = 17;
            lblTolerancia.Text = "Tolerancia:";
            // 
            // lblIngresarPunto
            // 
            lblIngresarPunto.AutoSize = true;
            lblIngresarPunto.Location = new Point(16, 50);
            lblIngresarPunto.Name = "lblIngresarPunto";
            lblIngresarPunto.Size = new Size(121, 15);
            lblIngresarPunto.TabIndex = 16;
            lblIngresarPunto.Text = "Ingresar Punto (X , Y):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 15;
            label1.Text = "Datos de Entrada";
            // 
            // panelGrafica
            // 
            panelGrafica.Location = new Point(16, 173);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Size = new Size(448, 351);
            panelGrafica.TabIndex = 7;
            // 
            // EfectividadAjuste
            // 
            EfectividadAjuste.AutoSize = true;
            EfectividadAjuste.Location = new Point(183, 133);
            EfectividadAjuste.Name = "EfectividadAjuste";
            EfectividadAjuste.Size = new Size(17, 15);
            EfectividadAjuste.TabIndex = 6;
            EfectividadAjuste.Text = "--";
            // 
            // Correccion
            // 
            Correccion.AutoSize = true;
            Correccion.Location = new Point(183, 92);
            Correccion.Name = "Correccion";
            Correccion.Size = new Size(17, 15);
            Correccion.TabIndex = 5;
            Correccion.Text = "--";
            // 
            // FuncionObtenida
            // 
            FuncionObtenida.AutoSize = true;
            FuncionObtenida.Location = new Point(183, 50);
            FuncionObtenida.Name = "FuncionObtenida";
            FuncionObtenida.Size = new Size(17, 15);
            FuncionObtenida.TabIndex = 4;
            FuncionObtenida.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 133);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 3;
            label9.Text = "Efectividad del Ajuste";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 89);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 2;
            label8.Text = "Correción (r)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 50);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 1;
            label7.Text = "Función Obtenida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 2);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 0;
            label6.Text = "Datos de Salida";
            // 
            // AjusteCurva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 536);
            Controls.Add(splitContainer1);
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
    }
}