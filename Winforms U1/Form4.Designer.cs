namespace PTM
{
    partial class Form4
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
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.txtValorConversion = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(488, 69);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(100, 20);
            this.txtOpcion.TabIndex = 0;
            // 
            // txtValorConversion
            // 
            this.txtValorConversion.Location = new System.Drawing.Point(488, 111);
            this.txtValorConversion.Name = "txtValorConversion";
            this.txtValorConversion.Size = new System.Drawing.Size(100, 20);
            this.txtValorConversion.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(488, 196);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(503, 222);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "DÓLAR/EURO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduce 1 para Dólar a Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "O Introduce 2 para Euro a Dolar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Introduce el valor de la conversión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(488, 154);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Introduce el monto a convertir";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValorConversion);
            this.Controls.Add(this.txtOpcion);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.TextBox txtValorConversion;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
    }
}