namespace SimonDice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimonBrinca = new System.Windows.Forms.Button();
            this.btnSimonSorpresa = new System.Windows.Forms.Button();
            this.btnSimonReverso = new System.Windows.Forms.Button();
            this.btnSimonClasico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMON DICE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btnSimonBrinca);
            this.groupBox1.Controls.Add(this.btnSimonSorpresa);
            this.groupBox1.Controls.Add(this.btnSimonReverso);
            this.groupBox1.Controls.Add(this.btnSimonClasico);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSimonBrinca
            // 
            this.btnSimonBrinca.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSimonBrinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimonBrinca.Location = new System.Drawing.Point(338, 10);
            this.btnSimonBrinca.Name = "btnSimonBrinca";
            this.btnSimonBrinca.Size = new System.Drawing.Size(104, 60);
            this.btnSimonBrinca.TabIndex = 3;
            this.btnSimonBrinca.Text = "Simon Brinca";
            this.btnSimonBrinca.UseVisualStyleBackColor = false;
            this.btnSimonBrinca.Click += new System.EventHandler(this.btnSimonBrinca_Click);
            // 
            // btnSimonSorpresa
            // 
            this.btnSimonSorpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimonSorpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimonSorpresa.Location = new System.Drawing.Point(228, 10);
            this.btnSimonSorpresa.Name = "btnSimonSorpresa";
            this.btnSimonSorpresa.Size = new System.Drawing.Size(104, 60);
            this.btnSimonSorpresa.TabIndex = 2;
            this.btnSimonSorpresa.Text = "Simon Sorpresa";
            this.btnSimonSorpresa.UseVisualStyleBackColor = false;
            this.btnSimonSorpresa.Click += new System.EventHandler(this.btnSimonSorpresa_Click);
            // 
            // btnSimonReverso
            // 
            this.btnSimonReverso.BackColor = System.Drawing.Color.Red;
            this.btnSimonReverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimonReverso.Location = new System.Drawing.Point(118, 11);
            this.btnSimonReverso.Name = "btnSimonReverso";
            this.btnSimonReverso.Size = new System.Drawing.Size(104, 59);
            this.btnSimonReverso.TabIndex = 1;
            this.btnSimonReverso.Text = "Simon Dice Reverso";
            this.btnSimonReverso.UseVisualStyleBackColor = false;
            this.btnSimonReverso.Click += new System.EventHandler(this.btnSimonReverso_Click);
            // 
            // btnSimonClasico
            // 
            this.btnSimonClasico.BackColor = System.Drawing.Color.Lime;
            this.btnSimonClasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimonClasico.Location = new System.Drawing.Point(8, 11);
            this.btnSimonClasico.Name = "btnSimonClasico";
            this.btnSimonClasico.Size = new System.Drawing.Size(104, 59);
            this.btnSimonClasico.TabIndex = 0;
            this.btnSimonClasico.Text = "Simon Dice Clásico";
            this.btnSimonClasico.UseVisualStyleBackColor = false;
            this.btnSimonClasico.Click += new System.EventHandler(this.btnSimonClasico_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(350, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(96, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "SELECCIONA MODO DE JUEGO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimonDice.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(477, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Forms1_ResizeEvent);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSimonBrinca;
        private System.Windows.Forms.Button btnSimonSorpresa;
        private System.Windows.Forms.Button btnSimonReverso;
        private System.Windows.Forms.Button btnSimonClasico;
        private System.Windows.Forms.Label label2;
    }
}

