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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            Metodo = new ToolStripMenuItem();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            FuncionObtenida = new Label();
            Correccion = new Label();
            EfectividadAjuste = new Label();
            panel2 = new Panel();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(EfectividadAjuste);
            splitContainer1.Panel2.Controls.Add(Correccion);
            splitContainer1.Panel2.Controls.Add(FuncionObtenida);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint_1;
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
            // 
            // DeleteLastButton
            // 
            DeleteLastButton.Location = new Point(303, 206);
            DeleteLastButton.Name = "DeleteLastButton";
            DeleteLastButton.Size = new Size(123, 23);
            DeleteLastButton.TabIndex = 27;
            DeleteLastButton.Text = "Eliminar Ultimo";
            DeleteLastButton.UseVisualStyleBackColor = true;
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
            // 
            // panel1
            // 
            panel1.Location = new Point(155, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 185);
            panel1.TabIndex = 24;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Metodo });
            menuStrip1.Location = new Point(150, 129);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(73, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // Metodo
            // 
            Metodo.Name = "Metodo";
            Metodo.Size = new Size(61, 20);
            Metodo.Text = "Metodo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(27, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(27, 23);
            textBox1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 173);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 19;
            label5.Text = "Puntos Ingreados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 129);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 18;
            label4.Text = "Método a utilizar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 92);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 17;
            label3.Text = "Tolerancia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 50);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 16;
            label2.Text = "Ingresar Punto (X , Y)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 15;
            label1.Text = "Datos de Entrada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 2);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 0;
            label6.Text = "Datos de Salida";
            label6.Click += label6_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 89);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 2;
            label8.Text = "Correción (r)";
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
            // FuncionObtenida
            // 
            FuncionObtenida.AutoSize = true;
            FuncionObtenida.Location = new Point(183, 50);
            FuncionObtenida.Name = "FuncionObtenida";
            FuncionObtenida.Size = new Size(17, 15);
            FuncionObtenida.TabIndex = 4;
            FuncionObtenida.Text = "--";
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
            // EfectividadAjuste
            // 
            EfectividadAjuste.AutoSize = true;
            EfectividadAjuste.Location = new Point(183, 133);
            EfectividadAjuste.Name = "EfectividadAjuste";
            EfectividadAjuste.Size = new Size(17, 15);
            EfectividadAjuste.TabIndex = 6;
            EfectividadAjuste.Text = "--";
            // 
            // panel2
            // 
            panel2.Location = new Point(16, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 351);
            panel2.TabIndex = 7;
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Metodo;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private Label EfectividadAjuste;
        private Label Correccion;
        private Label FuncionObtenida;
        private Label label9;
    }
}