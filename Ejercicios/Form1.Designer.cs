
namespace Ejercicios
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
            this.txtEdadForm1 = new System.Windows.Forms.TextBox();
            this.btncomprobarForm1 = new System.Windows.Forms.Button();
            this.lblEdadForm1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEdadForm1
            // 
            this.txtEdadForm1.Location = new System.Drawing.Point(53, 38);
            this.txtEdadForm1.Name = "txtEdadForm1";
            this.txtEdadForm1.Size = new System.Drawing.Size(100, 20);
            this.txtEdadForm1.TabIndex = 0;
            // 
            // btncomprobarForm1
            // 
            this.btncomprobarForm1.Location = new System.Drawing.Point(159, 36);
            this.btncomprobarForm1.Name = "btncomprobarForm1";
            this.btncomprobarForm1.Size = new System.Drawing.Size(75, 23);
            this.btncomprobarForm1.TabIndex = 1;
            this.btncomprobarForm1.Text = "Comprobar";
            this.btncomprobarForm1.UseVisualStyleBackColor = true;
            this.btncomprobarForm1.Click += new System.EventHandler(this.btncomprobarForm1_Click);
            // 
            // lblEdadForm1
            // 
            this.lblEdadForm1.AutoSize = true;
            this.lblEdadForm1.Location = new System.Drawing.Point(12, 41);
            this.lblEdadForm1.Name = "lblEdadForm1";
            this.lblEdadForm1.Size = new System.Drawing.Size(32, 13);
            this.lblEdadForm1.TabIndex = 2;
            this.lblEdadForm1.Text = "Edad";
            this.lblEdadForm1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdadForm1);
            this.Controls.Add(this.btncomprobarForm1);
            this.Controls.Add(this.txtEdadForm1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdadForm1;
        private System.Windows.Forms.Button btncomprobarForm1;
        private System.Windows.Forms.Label lblEdadForm1;
    }
}

