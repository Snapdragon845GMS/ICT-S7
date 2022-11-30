namespace Ejercicio12
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.TextBox();
            this.Bsi = new System.Windows.Forms.TextBox();
            this.B3 = new System.Windows.Forms.TextBox();
            this.B2 = new System.Windows.Forms.TextBox();
            this.Bci = new System.Windows.Forms.TextBox();
            this.Bcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "producto1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Con Iva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sin Iva";
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(234, 29);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 20);
            this.B1.TabIndex = 5;
            // 
            // Bsi
            // 
            this.Bsi.Location = new System.Drawing.Point(234, 249);
            this.Bsi.Name = "Bsi";
            this.Bsi.Size = new System.Drawing.Size(100, 20);
            this.Bsi.TabIndex = 6;
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(234, 129);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 20);
            this.B3.TabIndex = 7;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(234, 83);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 20);
            this.B2.TabIndex = 8;
            // 
            // Bci
            // 
            this.Bci.Location = new System.Drawing.Point(234, 295);
            this.Bci.Name = "Bci";
            this.Bci.Size = new System.Drawing.Size(100, 20);
            this.Bci.TabIndex = 9;
            // 
            // Bcalcular
            // 
            this.Bcalcular.Location = new System.Drawing.Point(424, 184);
            this.Bcalcular.Name = "Bcalcular";
            this.Bcalcular.Size = new System.Drawing.Size(75, 23);
            this.Bcalcular.TabIndex = 10;
            this.Bcalcular.Text = "Calcular";
            this.Bcalcular.UseVisualStyleBackColor = true;
            this.Bcalcular.Click += new System.EventHandler(this.Bcalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 364);
            this.Controls.Add(this.Bcalcular);
            this.Controls.Add(this.Bci);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.Bsi);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.TextBox Bsi;
        private System.Windows.Forms.TextBox B3;
        private System.Windows.Forms.TextBox B2;
        private System.Windows.Forms.TextBox Bci;
        private System.Windows.Forms.Button Bcalcular;
    }
}

