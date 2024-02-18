namespace PTM
{
    partial class Form7
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(489, 74);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(100, 20);
            this.txtOpcion.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(489, 122);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(489, 173);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(396, 226);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(109, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Calcular precio real";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "IMPUESTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione 1 para productos normales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "O 2 si su producto es medicina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Introduzca el valor de su producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtOpcion);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}