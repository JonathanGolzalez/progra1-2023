
namespace Ejercicios
{
    partial class cboDeConversores
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
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.lblAConversores = new System.Windows.Forms.Label();
            this.cboAConversores = new System.Windows.Forms.ComboBox();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblCantidadConversores = new System.Windows.Forms.Label();
            this.cboCantidadConversores = new System.Windows.Forms.ComboBox();
            this.btnCerrarConversores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(10, 148);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(163, 96);
            this.btnConvertirConversores.TabIndex = 0;
            this.btnConvertirConversores.Text = "Convertir";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Colon SV",
            "Cordoba",
            "Pesos CR",
            "Yenes",
            "Libras Esterlinas",
            "Rupia India"});
            this.comboBox1.Location = new System.Drawing.Point(52, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(12, 9);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(34, 20);
            this.lblDeConversor.TabIndex = 2;
            this.lblDeConversor.Text = "De:";
            // 
            // lblAConversores
            // 
            this.lblAConversores.AutoSize = true;
            this.lblAConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversores.Location = new System.Drawing.Point(12, 38);
            this.lblAConversores.Name = "lblAConversores";
            this.lblAConversores.Size = new System.Drawing.Size(24, 20);
            this.lblAConversores.TabIndex = 4;
            this.lblAConversores.Text = "A:";
            // 
            // cboAConversores
            // 
            this.cboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversores.FormattingEnabled = true;
            this.cboAConversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Colon SV",
            "Cordoba",
            "Pesos CR",
            "Yenes",
            "Libras Esterlinas",
            "Rupia India"});
            this.cboAConversores.Location = new System.Drawing.Point(52, 38);
            this.cboAConversores.Name = "cboAConversores";
            this.cboAConversores.Size = new System.Drawing.Size(121, 21);
            this.cboAConversores.TabIndex = 3;
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(12, 116);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(111, 20);
            this.lblRespuestaConversores.TabIndex = 5;
            this.lblRespuestaConversores.Text = "Respuesta:?";
            // 
            // lblCantidadConversores
            // 
            this.lblCantidadConversores.AutoSize = true;
            this.lblCantidadConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversores.Location = new System.Drawing.Point(12, 73);
            this.lblCantidadConversores.Name = "lblCantidadConversores";
            this.lblCantidadConversores.Size = new System.Drawing.Size(77, 20);
            this.lblCantidadConversores.TabIndex = 6;
            this.lblCantidadConversores.Text = "Cantidad:";
            // 
            // cboCantidadConversores
            // 
            this.cboCantidadConversores.FormattingEnabled = true;
            this.cboCantidadConversores.Location = new System.Drawing.Point(95, 75);
            this.cboCantidadConversores.Name = "cboCantidadConversores";
            this.cboCantidadConversores.Size = new System.Drawing.Size(121, 21);
            this.cboCantidadConversores.TabIndex = 7;
            // 
            // btnCerrarConversores
            // 
            this.btnCerrarConversores.BackColor = System.Drawing.Color.Red;
            this.btnCerrarConversores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarConversores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarConversores.Location = new System.Drawing.Point(240, 209);
            this.btnCerrarConversores.Name = "btnCerrarConversores";
            this.btnCerrarConversores.Size = new System.Drawing.Size(78, 32);
            this.btnCerrarConversores.TabIndex = 8;
            this.btnCerrarConversores.Text = "Cerrar";
            this.btnCerrarConversores.UseVisualStyleBackColor = false;
            this.btnCerrarConversores.Click += new System.EventHandler(this.btnCerrarConversores_Click);
            // 
            // cboDeConversores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 253);
            this.Controls.Add(this.btnCerrarConversores);
            this.Controls.Add(this.cboCantidadConversores);
            this.Controls.Add(this.lblCantidadConversores);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.lblAConversores);
            this.Controls.Add(this.cboAConversores);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConvertirConversores);
            this.Name = "cboDeConversores";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirConversores;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.Label lblAConversores;
        private System.Windows.Forms.ComboBox cboAConversores;
        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblCantidadConversores;
        private System.Windows.Forms.ComboBox cboCantidadConversores;
        private System.Windows.Forms.Button btnCerrarConversores;
    }
}

