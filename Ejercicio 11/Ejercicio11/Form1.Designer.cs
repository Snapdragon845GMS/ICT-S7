namespace Ejercicio11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tinicial = new System.Windows.Forms.TextBox();
            this.Tporcentaje = new System.Windows.Forms.TextBox();
            this.Lfinal = new System.Windows.Forms.Label();
            this.Bcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantida Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interes anual";
            // 
            // Tinicial
            // 
            this.Tinicial.Location = new System.Drawing.Point(149, 26);
            this.Tinicial.Name = "Tinicial";
            this.Tinicial.Size = new System.Drawing.Size(100, 20);
            this.Tinicial.TabIndex = 2;
            // 
            // Tporcentaje
            // 
            this.Tporcentaje.Location = new System.Drawing.Point(149, 66);
            this.Tporcentaje.Name = "Tporcentaje";
            this.Tporcentaje.Size = new System.Drawing.Size(100, 20);
            this.Tporcentaje.TabIndex = 3;
            // 
            // Lfinal
            // 
            this.Lfinal.AutoSize = true;
            this.Lfinal.Location = new System.Drawing.Point(84, 150);
            this.Lfinal.Name = "Lfinal";
            this.Lfinal.Size = new System.Drawing.Size(32, 13);
            this.Lfinal.TabIndex = 4;
            this.Lfinal.Text = "Lfinal";
            // 
            // Bcalcular
            // 
            this.Bcalcular.Location = new System.Drawing.Point(87, 111);
            this.Bcalcular.Name = "Bcalcular";
            this.Bcalcular.Size = new System.Drawing.Size(75, 23);
            this.Bcalcular.TabIndex = 5;
            this.Bcalcular.Text = "Calcular";
            this.Bcalcular.UseVisualStyleBackColor = true;
            this.Bcalcular.Click += new System.EventHandler(this.Bcalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Bcalcular);
            this.Controls.Add(this.Lfinal);
            this.Controls.Add(this.Tporcentaje);
            this.Controls.Add(this.Tinicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tinicial;
        private System.Windows.Forms.TextBox Tporcentaje;
        private System.Windows.Forms.Label Lfinal;
        private System.Windows.Forms.Button Bcalcular;
    }
}

