namespace Ejercicio10
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
            this.Teuros = new System.Windows.Forms.TextBox();
            this.Tpesetas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bpesetas = new System.Windows.Forms.Button();
            this.Beuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Teuros
            // 
            this.Teuros.Location = new System.Drawing.Point(177, 28);
            this.Teuros.Name = "Teuros";
            this.Teuros.Size = new System.Drawing.Size(100, 20);
            this.Teuros.TabIndex = 0;
            // 
            // Tpesetas
            // 
            this.Tpesetas.Location = new System.Drawing.Point(177, 90);
            this.Tpesetas.Name = "Tpesetas";
            this.Tpesetas.Size = new System.Drawing.Size(100, 20);
            this.Tpesetas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "euros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "pesetas";
            // 
            // Bpesetas
            // 
            this.Bpesetas.Location = new System.Drawing.Point(94, 232);
            this.Bpesetas.Name = "Bpesetas";
            this.Bpesetas.Size = new System.Drawing.Size(183, 98);
            this.Bpesetas.TabIndex = 6;
            this.Bpesetas.Text = "Pasar a pesetas";
            this.Bpesetas.UseVisualStyleBackColor = true;
            this.Bpesetas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Beuros
            // 
            this.Beuros.Location = new System.Drawing.Point(102, 336);
            this.Beuros.Name = "Beuros";
            this.Beuros.Size = new System.Drawing.Size(175, 102);
            this.Beuros.TabIndex = 7;
            this.Beuros.Text = "Pasar a euros";
            this.Beuros.UseVisualStyleBackColor = true;
            this.Beuros.Click += new System.EventHandler(this.Beuros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 467);
            this.Controls.Add(this.Beuros);
            this.Controls.Add(this.Bpesetas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tpesetas);
            this.Controls.Add(this.Teuros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Teuros;
        private System.Windows.Forms.TextBox Tpesetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bpesetas;
        private System.Windows.Forms.Button Beuros;
    }
}

