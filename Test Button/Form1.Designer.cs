namespace Test_Button
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.LEtiqueta = new System.Windows.Forms.Label();
            this.Cuadrotext = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Boton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LEtiqueta
            // 
            this.LEtiqueta.AutoSize = true;
            this.LEtiqueta.Location = new System.Drawing.Point(309, 206);
            this.LEtiqueta.Name = "LEtiqueta";
            this.LEtiqueta.Size = new System.Drawing.Size(41, 16);
            this.LEtiqueta.TabIndex = 1;
            this.LEtiqueta.Text = "Texto";
            this.LEtiqueta.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cuadrotext
            // 
            this.Cuadrotext.Location = new System.Drawing.Point(234, 318);
            this.Cuadrotext.Name = "Cuadrotext";
            this.Cuadrotext.Size = new System.Drawing.Size(195, 22);
            this.Cuadrotext.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 94);
            this.button2.TabIndex = 3;
            this.button2.Text = "Boton2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(677, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cuadrotext);
            this.Controls.Add(this.LEtiqueta);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LEtiqueta;
        private System.Windows.Forms.TextBox Cuadrotext;
        private System.Windows.Forms.Button button2;
    }
}

