namespace ejercicio9
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
            this.Tnum1 = new System.Windows.Forms.TextBox();
            this.Tnum2 = new System.Windows.Forms.TextBox();
            this.Bres = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.resto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // Tnum1
            // 
            this.Tnum1.Location = new System.Drawing.Point(214, 49);
            this.Tnum1.Name = "Tnum1";
            this.Tnum1.Size = new System.Drawing.Size(100, 20);
            this.Tnum1.TabIndex = 3;
            // 
            // Tnum2
            // 
            this.Tnum2.Location = new System.Drawing.Point(214, 108);
            this.Tnum2.Name = "Tnum2";
            this.Tnum2.Size = new System.Drawing.Size(100, 20);
            this.Tnum2.TabIndex = 4;
            // 
            // Bres
            // 
            this.Bres.Location = new System.Drawing.Point(214, 205);
            this.Bres.Name = "Bres";
            this.Bres.Size = new System.Drawing.Size(100, 20);
            this.Bres.TabIndex = 5;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(444, 57);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 6;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(444, 141);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 7;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click_1);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(567, 57);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(75, 23);
            this.restar.TabIndex = 8;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(567, 141);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 9;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click_1);
            // 
            // resto
            // 
            this.resto.Location = new System.Drawing.Point(506, 205);
            this.resto.Name = "resto";
            this.resto.Size = new System.Drawing.Size(75, 23);
            this.resto.TabIndex = 10;
            this.resto.Text = "%";
            this.resto.UseVisualStyleBackColor = true;
            this.resto.Click += new System.EventHandler(this.resto_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 314);
            this.Controls.Add(this.resto);
            this.Controls.Add(this.div);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Bres);
            this.Controls.Add(this.Tnum2);
            this.Controls.Add(this.Tnum1);
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
        private System.Windows.Forms.TextBox Tnum1;
        private System.Windows.Forms.TextBox Tnum2;
        private System.Windows.Forms.TextBox Bres;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button resto;
    }
}

