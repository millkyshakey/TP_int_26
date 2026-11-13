namespace UI_Pañol
{
    partial class Principal
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 19);
            label1.Name = "label1";
            label1.Size = new Size(229, 33);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Pañol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 95);
            label2.Name = "label2";
            label2.Size = new Size(214, 31);
            label2.TabIndex = 1;
            label2.Text = "Usted es: Alumno";
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(69, 230);
            button1.Name = "button1";
            button1.Size = new Size(182, 93);
            button1.TabIndex = 2;
            button1.Text = "Catálogo y préstamos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(282, 230);
            button2.Name = "button2";
            button2.Size = new Size(229, 93);
            button2.TabIndex = 3;
            button2.Text = "Mis solicitudes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(555, 230);
            button3.Name = "button3";
            button3.Size = new Size(182, 93);
            button3.TabIndex = 4;
            button3.Text = "Reportar daño";
            button3.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}