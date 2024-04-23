namespace AnalisisNumerico2024
{
    partial class Home
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
            btnRaices = new Button();
            btnSistemaEcuaciones = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRaices
            // 
            btnRaices.Location = new Point(248, 220);
            btnRaices.Name = "btnRaices";
            btnRaices.Size = new Size(153, 78);
            btnRaices.TabIndex = 0;
            btnRaices.Text = "Calcular Raíces de Funciones";
            btnRaices.UseVisualStyleBackColor = true;
            btnRaices.Click += btnRaices_Click;
            // 
            // btnSistemaEcuaciones
            // 
            btnSistemaEcuaciones.Location = new Point(464, 220);
            btnSistemaEcuaciones.Name = "btnSistemaEcuaciones";
            btnSistemaEcuaciones.Size = new Size(153, 78);
            btnSistemaEcuaciones.TabIndex = 1;
            btnSistemaEcuaciones.Text = "Calcular Sistemas de Ecuaciones";
            btnSistemaEcuaciones.UseVisualStyleBackColor = true;
            btnSistemaEcuaciones.Click += btnSistemaEcuaciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 129);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione la aplicación:";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(btnSistemaEcuaciones);
            Controls.Add(btnRaices);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRaices;
        private Button btnSistemaEcuaciones;
        private Label label1;
    }
}