namespace AnalisisNumerico2024
{
    partial class IntegracionNumerica
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
            splitContainer1 = new SplitContainer();
            comboBox1 = new ComboBox();
            Intervalo = new TextBox();
            IngresarFuncion = new TextBox();
            TextBoxXd = new TextBox();
            TextBoxXi = new TextBox();
            label8 = new Label();
            button1 = new Button();
            IntervaloLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtResultado = new TextBox();
            label7 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(Intervalo);
            splitContainer1.Panel1.Controls.Add(IngresarFuncion);
            splitContainer1.Panel1.Controls.Add(TextBoxXd);
            splitContainer1.Panel1.Controls.Add(TextBoxXi);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(IntervaloLabel);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Trapecios Simple", "Trapecios Múltiple", "Simpson 1/3 Simple", "Simpson 1/3 Múltiple ", "Simpson 3/8", "Simpson Combinado" });
            comboBox1.Location = new Point(106, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Intervalo
            // 
            Intervalo.Location = new Point(189, 136);
            Intervalo.Name = "Intervalo";
            Intervalo.Size = new Size(78, 23);
            Intervalo.TabIndex = 10;
            // 
            // IngresarFuncion
            // 
            IngresarFuncion.Location = new Point(74, 42);
            IngresarFuncion.Name = "IngresarFuncion";
            IngresarFuncion.Size = new Size(193, 23);
            IngresarFuncion.TabIndex = 9;
            // 
            // TextBoxXd
            // 
            TextBoxXd.Location = new Point(219, 78);
            TextBoxXd.Name = "TextBoxXd";
            TextBoxXd.Size = new Size(48, 23);
            TextBoxXd.TabIndex = 8;
            // 
            // TextBoxXi
            // 
            TextBoxXi.Location = new Point(116, 78);
            TextBoxXi.Name = "TextBoxXi";
            TextBoxXi.Size = new Size(58, 23);
            TextBoxXi.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 179);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 6;
            label8.Text = "Método:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(106, 243);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IntervaloLabel
            // 
            IntervaloLabel.AutoSize = true;
            IntervaloLabel.Location = new Point(12, 139);
            IntervaloLabel.Name = "IntervaloLabel";
            IntervaloLabel.Size = new Size(165, 15);
            IntervaloLabel.TabIndex = 4;
            IntervaloLabel.Text = "Cantidad de subIntervalos (n):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(189, 81);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 3;
            label5.Text = "Xd:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(90, 81);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 2;
            label4.Text = "Xi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 47);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "F(x):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Datos de Entrada";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(99, 49);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(151, 23);
            txtResultado.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 50);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 1;
            label7.Text = "Área:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(15, 7);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Resultado";
            // 
            // IntegracionNumerica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "IntegracionNumerica";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private Label IntervaloLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtResultado;
        private Label label7;
        private Label label2;
        private TextBox TextBoxXd;
        private TextBox TextBoxXi;
        private Label label8;
        private TextBox IngresarFuncion;
        private TextBox Intervalo;
        private ComboBox comboBox1;
    }
}