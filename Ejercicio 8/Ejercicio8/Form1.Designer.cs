namespace Ejercicio8
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
            this.Tnum1 = new System.Windows.Forms.TextBox();
            this.Tnum3 = new System.Windows.Forms.TextBox();
            this.Tnum2 = new System.Windows.Forms.TextBox();
            this.Boperar = new System.Windows.Forms.Button();
            this.Lmultiplicacion = new System.Windows.Forms.Label();
            this.Lsuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tnum1
            // 
            this.Tnum1.Location = new System.Drawing.Point(119, 50);
            this.Tnum1.Name = "Tnum1";
            this.Tnum1.Size = new System.Drawing.Size(100, 20);
            this.Tnum1.TabIndex = 0;
            // 
            // Tnum3
            // 
            this.Tnum3.Location = new System.Drawing.Point(119, 280);
            this.Tnum3.Name = "Tnum3";
            this.Tnum3.Size = new System.Drawing.Size(100, 20);
            this.Tnum3.TabIndex = 1;
            // 
            // Tnum2
            // 
            this.Tnum2.Location = new System.Drawing.Point(119, 168);
            this.Tnum2.Name = "Tnum2";
            this.Tnum2.Size = new System.Drawing.Size(100, 20);
            this.Tnum2.TabIndex = 2;
            // 
            // Boperar
            // 
            this.Boperar.Location = new System.Drawing.Point(377, 50);
            this.Boperar.Name = "Boperar";
            this.Boperar.Size = new System.Drawing.Size(147, 138);
            this.Boperar.TabIndex = 3;
            this.Boperar.Text = "operar";
            this.Boperar.UseVisualStyleBackColor = true;
            this.Boperar.Click += new System.EventHandler(this.Boperar_Click);
            // 
            // Lmultiplicacion
            // 
            this.Lmultiplicacion.AutoSize = true;
            this.Lmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lmultiplicacion.Location = new System.Drawing.Point(432, 283);
            this.Lmultiplicacion.Name = "Lmultiplicacion";
            this.Lmultiplicacion.Size = new System.Drawing.Size(60, 24);
            this.Lmultiplicacion.TabIndex = 4;
            this.Lmultiplicacion.Text = "          ";
            // 
            // Lsuma
            // 
            this.Lsuma.AutoSize = true;
            this.Lsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lsuma.Location = new System.Drawing.Point(432, 219);
            this.Lsuma.Name = "Lsuma";
            this.Lsuma.Size = new System.Drawing.Size(60, 24);
            this.Lsuma.TabIndex = 5;
            this.Lsuma.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 382);
            this.Controls.Add(this.Lsuma);
            this.Controls.Add(this.Lmultiplicacion);
            this.Controls.Add(this.Boperar);
            this.Controls.Add(this.Tnum2);
            this.Controls.Add(this.Tnum3);
            this.Controls.Add(this.Tnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tnum1;
        private System.Windows.Forms.TextBox Tnum3;
        private System.Windows.Forms.TextBox Tnum2;
        private System.Windows.Forms.Button Boperar;
        private System.Windows.Forms.Label Lmultiplicacion;
        private System.Windows.Forms.Label Lsuma;
    }
}

