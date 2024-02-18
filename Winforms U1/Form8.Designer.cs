namespace PTM
{
    partial class Form8
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
            this.txtNumeroDia = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMostrarDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroDia
            // 
            this.txtNumeroDia.Location = new System.Drawing.Point(451, 67);
            this.txtNumeroDia.Name = "txtNumeroDia";
            this.txtNumeroDia.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDia.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(451, 107);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btnMostrarDia
            // 
            this.btnMostrarDia.Location = new System.Drawing.Point(376, 144);
            this.btnMostrarDia.Name = "btnMostrarDia";
            this.btnMostrarDia.Size = new System.Drawing.Size(103, 23);
            this.btnMostrarDia.TabIndex = 2;
            this.btnMostrarDia.Text = "Consultar día";
            this.btnMostrarDia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "DÍA DE LA SEMANA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(294, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduce un número del 1 al 7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarDia);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroDia);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroDia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMostrarDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}