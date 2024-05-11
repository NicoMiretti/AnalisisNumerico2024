namespace AnalisisNumerico2024
{
    partial class SistemaEcuaciones
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
            lblIngresar = new Label();
            txtDimension = new TextBox();
            btnGenerar = new Button();
            lblMetodo = new Label();
            cmbBox = new ComboBox();
            btnCalcular = new Button();
            groupBoxMatriz = new GroupBox();
            SuspendLayout();
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Location = new Point(24, 20);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(236, 15);
            lblIngresar.TabIndex = 0;
            lblIngresar.Text = "Ingrese la dimensión de la matriz a calcular:";
            // 
            // txtDimension
            // 
            txtDimension.Location = new Point(290, 17);
            txtDimension.Margin = new Padding(3, 2, 3, 2);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(47, 23);
            txtDimension.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(354, 16);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(82, 22);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Location = new Point(462, 18);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(52, 15);
            lblMetodo.TabIndex = 3;
            lblMetodo.Text = "Método:";
            // 
            // cmbBox
            // 
            cmbBox.FormattingEnabled = true;
            cmbBox.Items.AddRange(new object[] { "Gauss-Jordan", "Gauss-Seidel" });
            cmbBox.Location = new Point(534, 16);
            cmbBox.Margin = new Padding(3, 2, 3, 2);
            cmbBox.Name = "cmbBox";
            cmbBox.Size = new Size(133, 23);
            cmbBox.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(689, 16);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 22);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBoxMatriz
            // 
            groupBoxMatriz.Location = new Point(44, 58);
            groupBoxMatriz.Margin = new Padding(3, 2, 3, 2);
            groupBoxMatriz.Name = "groupBoxMatriz";
            groupBoxMatriz.Padding = new Padding(3, 2, 3, 2);
            groupBoxMatriz.Size = new Size(814, 218);
            groupBoxMatriz.TabIndex = 6;
            groupBoxMatriz.TabStop = false;
            groupBoxMatriz.Text = "Matriz";
            // 
            // SistemaEcuaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 415);
            Controls.Add(groupBoxMatriz);
            Controls.Add(btnCalcular);
            Controls.Add(cmbBox);
            Controls.Add(lblMetodo);
            Controls.Add(btnGenerar);
            Controls.Add(txtDimension);
            Controls.Add(lblIngresar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SistemaEcuaciones";
            Text = "SistemaEcuaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngresar;
        private TextBox txtDimension;
        private Button btnGenerar;
        private Label lblMetodo;
        private ComboBox cmbBox;
        private Button btnCalcular;
        private GroupBox groupBoxMatriz;
    }
}