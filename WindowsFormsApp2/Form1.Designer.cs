﻿namespace WindowsFormsApp2
{
    partial class TxtCuotasMensual
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
            this.LblMonto = new System.Windows.Forms.Label();
            this.LblTipoPrestamo = new System.Windows.Forms.Label();
            this.LblMeses = new System.Windows.Forms.Label();
            this.LblTasaInteres = new System.Windows.Forms.Label();
            this.LblCalcular = new System.Windows.Forms.Button();
            this.CBxMeses = new System.Windows.Forms.ComboBox();
            this.CBxPrestamo = new System.Windows.Forms.ComboBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.TxtInteres = new System.Windows.Forms.TextBox();
            this.LblCuotasMensual = new System.Windows.Forms.Label();
            this.TxtCuota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.ForeColor = System.Drawing.Color.Sienna;
            this.LblMonto.Location = new System.Drawing.Point(117, 105);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(59, 20);
            this.LblMonto.TabIndex = 0;
            this.LblMonto.Text = "Monto";
            // 
            // LblTipoPrestamo
            // 
            this.LblTipoPrestamo.AutoSize = true;
            this.LblTipoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPrestamo.ForeColor = System.Drawing.Color.Sienna;
            this.LblTipoPrestamo.Location = new System.Drawing.Point(51, 141);
            this.LblTipoPrestamo.Name = "LblTipoPrestamo";
            this.LblTipoPrestamo.Size = new System.Drawing.Size(125, 20);
            this.LblTipoPrestamo.TabIndex = 8;
            this.LblTipoPrestamo.Text = "Tipo-Prestamo";
            // 
            // LblMeses
            // 
            this.LblMeses.AutoSize = true;
            this.LblMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeses.ForeColor = System.Drawing.Color.Sienna;
            this.LblMeses.Location = new System.Drawing.Point(42, 185);
            this.LblMeses.Name = "LblMeses";
            this.LblMeses.Size = new System.Drawing.Size(139, 20);
            this.LblMeses.TabIndex = 10;
            this.LblMeses.Text = "Cantidad-Meses";
            this.LblMeses.Click += new System.EventHandler(this.label10_Click);
            // 
            // LblTasaInteres
            // 
            this.LblTasaInteres.AutoSize = true;
            this.LblTasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTasaInteres.ForeColor = System.Drawing.Color.Sienna;
            this.LblTasaInteres.Location = new System.Drawing.Point(70, 223);
            this.LblTasaInteres.Name = "LblTasaInteres";
            this.LblTasaInteres.Size = new System.Drawing.Size(111, 20);
            this.LblTasaInteres.TabIndex = 11;
            this.LblTasaInteres.Text = "Tasa-Interes";
            this.LblTasaInteres.Click += new System.EventHandler(this.LblTasaInteres_Click);
            // 
            // LblCalcular
            // 
            this.LblCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalcular.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblCalcular.Location = new System.Drawing.Point(144, 340);
            this.LblCalcular.Name = "LblCalcular";
            this.LblCalcular.Size = new System.Drawing.Size(101, 54);
            this.LblCalcular.TabIndex = 12;
            this.LblCalcular.Text = "Calcular";
            this.LblCalcular.UseVisualStyleBackColor = true;
            this.LblCalcular.Click += new System.EventHandler(this.LblCalcular_Click);
            // 
            // CBxMeses
            // 
            this.CBxMeses.FormattingEnabled = true;
            this.CBxMeses.Location = new System.Drawing.Point(196, 187);
            this.CBxMeses.Name = "CBxMeses";
            this.CBxMeses.Size = new System.Drawing.Size(134, 21);
            this.CBxMeses.TabIndex = 14;
            // 
            // CBxPrestamo
            // 
            this.CBxPrestamo.FormattingEnabled = true;
            this.CBxPrestamo.Location = new System.Drawing.Point(196, 143);
            this.CBxPrestamo.Name = "CBxPrestamo";
            this.CBxPrestamo.Size = new System.Drawing.Size(134, 21);
            this.CBxPrestamo.TabIndex = 16;
            this.CBxPrestamo.SelectedIndexChanged += new System.EventHandler(this.CBxPrestamo_SelectedIndexChanged);
            this.CBxPrestamo.SelectedValueChanged += new System.EventHandler(this.CBxPrestamo_SelectedValueChanged);
            this.CBxPrestamo.Leave += new System.EventHandler(this.CBxPrestamo_Leave);
            this.CBxPrestamo.MouseLeave += new System.EventHandler(this.CBxPrestamo_MouseLeave);
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(196, 105);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(134, 20);
            this.TxtMonto.TabIndex = 17;
            this.TxtMonto.Click += new System.EventHandler(this.TxtMonto_Click);
            this.TxtMonto.TextChanged += new System.EventHandler(this.TxtMonto_TextChanged);
            this.TxtMonto.Leave += new System.EventHandler(this.TxtMonto_Leave);
            this.TxtMonto.MouseLeave += new System.EventHandler(this.TxtMonto_MouseLeave);
            // 
            // TxtInteres
            // 
            this.TxtInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInteres.Location = new System.Drawing.Point(196, 225);
            this.TxtInteres.Name = "TxtInteres";
            this.TxtInteres.ReadOnly = true;
            this.TxtInteres.Size = new System.Drawing.Size(134, 20);
            this.TxtInteres.TabIndex = 18;
            this.TxtInteres.TextChanged += new System.EventHandler(this.TxtInteres_TextChanged);
            // 
            // LblCuotasMensual
            // 
            this.LblCuotasMensual.AutoSize = true;
            this.LblCuotasMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuotasMensual.ForeColor = System.Drawing.Color.Sienna;
            this.LblCuotasMensual.Location = new System.Drawing.Point(51, 282);
            this.LblCuotasMensual.Name = "LblCuotasMensual";
            this.LblCuotasMensual.Size = new System.Drawing.Size(130, 20);
            this.LblCuotasMensual.TabIndex = 19;
            this.LblCuotasMensual.Text = "Cuota-Mensual";
            // 
            // TxtCuota
            // 
            this.TxtCuota.Location = new System.Drawing.Point(196, 284);
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.ReadOnly = true;
            this.TxtCuota.Size = new System.Drawing.Size(134, 20);
            this.TxtCuota.TabIndex = 20;
            this.TxtCuota.TextChanged += new System.EventHandler(this.TxtCuota_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Calculadora de prestamos";
            // 
            // TxtCuotasMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.LblCuotasMensual);
            this.Controls.Add(this.TxtInteres);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.CBxPrestamo);
            this.Controls.Add(this.CBxMeses);
            this.Controls.Add(this.LblCalcular);
            this.Controls.Add(this.LblTasaInteres);
            this.Controls.Add(this.LblMeses);
            this.Controls.Add(this.LblTipoPrestamo);
            this.Controls.Add(this.LblMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TxtCuotasMensual";
            this.Text = "CalculadorPrestamo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.TxtCuotasMensual_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label LblTipoPrestamo;
        private System.Windows.Forms.Label LblMeses;
        private System.Windows.Forms.Label LblTasaInteres;
        private System.Windows.Forms.Button LblCalcular;
        private System.Windows.Forms.ComboBox CBxMeses;
        private System.Windows.Forms.ComboBox CBxPrestamo;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.TextBox TxtInteres;
        private System.Windows.Forms.Label LblCuotasMensual;
        private System.Windows.Forms.TextBox TxtCuota;
        private System.Windows.Forms.Label label1;
    }
}

