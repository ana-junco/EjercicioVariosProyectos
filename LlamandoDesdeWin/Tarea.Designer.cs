namespace LlamandoDesdeWin
{
    partial class Tarea
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextNumeaFact = new System.Windows.Forms.TextBox();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextSuma = new System.Windows.Forms.TextBox();
            this.TextFact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE EL PRIMER NUMERO A SUMAR";
            // 
            // TextNum1
            // 
            this.TextNum1.Location = new System.Drawing.Point(460, 72);
            this.TextNum1.Name = "TextNum1";
            this.TextNum1.Size = new System.Drawing.Size(100, 22);
            this.TextNum1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE EL SEGUNDO NUMERO A SUMAR";
            // 
            // TextNum2
            // 
            this.TextNum2.Location = new System.Drawing.Point(462, 135);
            this.TextNum2.Name = "TextNum2";
            this.TextNum2.Size = new System.Drawing.Size(100, 22);
            this.TextNum2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "INGRESE UN NUMERO A FACTORAR";
            // 
            // TextNumeaFact
            // 
            this.TextNumeaFact.Location = new System.Drawing.Point(462, 201);
            this.TextNumeaFact.Name = "TextNumeaFact";
            this.TextNumeaFact.Size = new System.Drawing.Size(100, 22);
            this.TextNumeaFact.TabIndex = 5;
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.Location = new System.Drawing.Point(307, 274);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(118, 65);
            this.btnCALCULAR.TabIndex = 6;
            this.btnCALCULAR.Text = "CALCULAR";
            this.btnCALCULAR.UseVisualStyleBackColor = true;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "SUMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "FACTORIAL";
            // 
            // TextSuma
            // 
            this.TextSuma.Location = new System.Drawing.Point(369, 387);
            this.TextSuma.Name = "TextSuma";
            this.TextSuma.Size = new System.Drawing.Size(100, 22);
            this.TextSuma.TabIndex = 9;
            // 
            // TextFact
            // 
            this.TextFact.Location = new System.Drawing.Point(369, 445);
            this.TextFact.Name = "TextFact";
            this.TextFact.Size = new System.Drawing.Size(100, 22);
            this.TextFact.TabIndex = 10;
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TextFact);
            this.Controls.Add(this.TextSuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.TextNumeaFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextNum1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tarea";
            this.Text = "Llamandodesdewin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextNumeaFact;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextSuma;
        private System.Windows.Forms.TextBox TextFact;
    }
}

