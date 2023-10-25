namespace PRACTICA_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Resultado = new TextBox();
            Valor = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(174, 214);
            button1.Name = "button1";
            button1.Size = new Size(148, 51);
            button1.TabIndex = 0;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 214);
            button2.Name = "button2";
            button2.Size = new Size(173, 51);
            button2.TabIndex = 1;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(300, 295);
            button3.Name = "button3";
            button3.Size = new Size(124, 47);
            button3.TabIndex = 2;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(68, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 3;
            label1.Text = "DATOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Location = new Point(145, 76);
            label2.Name = "label2";
            label2.Size = new Size(177, 24);
            label2.TabIndex = 4;
            label2.Text = "INGRESA VALOR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Location = new Point(146, 159);
            label3.Name = "label3";
            label3.Size = new Size(331, 24);
            label3.TabIndex = 5;
            label3.Text = "OPERACIONES DE CONVERSION ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Location = new Point(145, 378);
            label4.Name = "label4";
            label4.Size = new Size(268, 24);
            label4.TabIndex = 6;
            label4.Text = "RESULTADOS EN GRADOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Location = new Point(291, 437);
            label5.Name = "label5";
            label5.Size = new Size(273, 24);
            label5.TabIndex = 7;
            label5.Text = "EQUIVALENTE EN GRADOS";
            // 
            // Resultado
            // 
            Resultado.BackColor = SystemColors.Info;
            Resultado.Location = new Point(344, 489);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(190, 30);
            Resultado.TabIndex = 8;
            // 
            // Valor
            // 
            Valor.Location = new Point(357, 76);
            Valor.Name = "Valor";
            Valor.Size = new Size(177, 30);
            Valor.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1200, 540);
            Controls.Add(Valor);
            Controls.Add(Resultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "CONVERSIONES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Resultado;
        private TextBox Valor;
    }
}