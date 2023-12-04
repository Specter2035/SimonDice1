namespace SimonDice
{
    partial class SelecNivelReverso
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
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnN3
            // 
            this.btnN3.Location = new System.Drawing.Point(78, 173);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(91, 34);
            this.btnN3.TabIndex = 14;
            this.btnN3.Text = "Nivel 3";
            this.btnN3.UseVisualStyleBackColor = true;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN2
            // 
            this.btnN2.Location = new System.Drawing.Point(78, 133);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(91, 34);
            this.btnN2.TabIndex = 13;
            this.btnN2.Text = "Nivel 2";
            this.btnN2.UseVisualStyleBackColor = true;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN1
            // 
            this.btnN1.Location = new System.Drawing.Point(78, 93);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(91, 34);
            this.btnN1.TabIndex = 12;
            this.btnN1.Text = "Nivel 1";
            this.btnN1.UseVisualStyleBackColor = true;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "SELECCIONA NIVEL";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(106, 248);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(91, 34);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // SelecNivelReverso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(252, 321);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Name = "SelecNivelReverso";
            this.Text = "SelecNivelReverso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
    }
}