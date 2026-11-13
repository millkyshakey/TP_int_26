namespace UI_Pañol
{
    partial class Daño_reporte
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 33);
            label1.TabIndex = 7;
            label1.Text = "Reporte de daño";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 380);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Catálogo de herramientas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Escribe el nombre de la herramienta..";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(517, 307);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(375, 32);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(547, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 31);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Tipo de daño...";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(547, 192);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(241, 31);
            comboBox2.TabIndex = 10;
            comboBox2.Text = "Gravedad...";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(182, 24);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Provocado por alumno";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 97);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(222, 24);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Detectado en control interno";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 13;
            textBox2.Text = "Legajo..";
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Sans", 9F);
            button2.Location = new Point(547, 379);
            button2.Name = "button2";
            button2.Size = new Size(241, 53);
            button2.TabIndex = 14;
            button2.Text = "Confirmar y registrar reporte";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Location = new Point(547, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proveniencia";
            // 
            // Daño_reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Daño_reporte";
            Text = "Daño_reporte";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox2;
        private Button button2;
    }
}