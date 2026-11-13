namespace UI_Pañol
{
    partial class Admin
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(554, 240);
            button3.Name = "button3";
            button3.Size = new Size(182, 93);
            button3.TabIndex = 9;
            button3.Text = "Reportar daño";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(281, 240);
            button2.Name = "button2";
            button2.Size = new Size(229, 93);
            button2.TabIndex = 8;
            button2.Text = "Inventario y mantenimiento";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(68, 240);
            button1.Name = "button1";
            button1.Size = new Size(182, 93);
            button1.TabIndex = 7;
            button1.Text = "Catálogo y préstamos";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 85);
            label2.Name = "label2";
            label2.Size = new Size(289, 31);
            label2.TabIndex = 6;
            label2.Text = "Usted es: Administrador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 33);
            label1.TabIndex = 5;
            label1.Text = "Sistema de Pañol";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}