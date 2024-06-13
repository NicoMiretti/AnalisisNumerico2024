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
            btnIntegracionNumerica = new Button();
            btnRegresionLineal = new Button();
            SuspendLayout();
            // 
            // btnRaices
            // 
            btnRaices.Location = new Point(224, 156);
            btnRaices.Margin = new Padding(3, 2, 3, 2);
            btnRaices.Name = "btnRaices";
            btnRaices.Size = new Size(134, 58);
            btnRaices.TabIndex = 0;
            btnRaices.Text = "Calcular Raíces de Funciones";
            btnRaices.UseVisualStyleBackColor = true;
            btnRaices.Click += btnRaices_Click;
            // 
            // btnSistemaEcuaciones
            // 
            btnSistemaEcuaciones.Location = new Point(418, 156);
            btnSistemaEcuaciones.Margin = new Padding(3, 2, 3, 2);
            btnSistemaEcuaciones.Name = "btnSistemaEcuaciones";
            btnSistemaEcuaciones.Size = new Size(134, 58);
            btnSistemaEcuaciones.TabIndex = 1;
            btnSistemaEcuaciones.Text = "Calcular Sistemas de Ecuaciones";
            btnSistemaEcuaciones.UseVisualStyleBackColor = true;
            btnSistemaEcuaciones.Click += btnSistemaEcuaciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(304, 97);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione la aplicación:";
            // 
            // btnIntegracionNumerica
            // 
            btnIntegracionNumerica.Location = new Point(418, 260);
            btnIntegracionNumerica.Name = "btnIntegracionNumerica";
            btnIntegracionNumerica.Size = new Size(134, 58);
            btnIntegracionNumerica.TabIndex = 3;
            btnIntegracionNumerica.Text = "Calcular Integración Numerica";
            btnIntegracionNumerica.UseVisualStyleBackColor = true;
            btnIntegracionNumerica.Click += btnIntegracionNumerica_Click;
            // 
            // btnRegresionLineal
            // 
            btnRegresionLineal.Location = new Point(224, 260);
            btnRegresionLineal.Name = "btnRegresionLineal";
            btnRegresionLineal.Size = new Size(134, 58);
            btnRegresionLineal.TabIndex = 4;
            btnRegresionLineal.Text = "Ajuste de curvas";
            btnRegresionLineal.UseVisualStyleBackColor = true;
            btnRegresionLineal.Click += btnRegresionLineal_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresionLineal);
            Controls.Add(btnIntegracionNumerica);
            Controls.Add(label1);
            Controls.Add(btnSistemaEcuaciones);
            Controls.Add(btnRaices);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRaices;
        private Button btnSistemaEcuaciones;
        private Label label1;
        private Button btnIntegracionNumerica;
        private Button btnRegresionLineal;
    }
}