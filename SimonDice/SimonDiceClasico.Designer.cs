﻿namespace SimonDice
{
    partial class SimonDiceClasico
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
            this.components = new System.ComponentModel.Container();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.P_2 = new System.Windows.Forms.PictureBox();
            this.P_3 = new System.Windows.Forms.PictureBox();
            this.P_1 = new System.Windows.Forms.PictureBox();
            this.P_0 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.P_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_0)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(451, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Gray;
            this.btnIniciar.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(321, 447);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(125, 41);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Puntos:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(366, 23);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(36, 40);
            this.lblPuntos.TabIndex = 11;
            this.lblPuntos.Text = "0";
            // 
            // P_2
            // 
            this.P_2.Image = global::SimonDice.Properties.Resources.CRojo_1;
            this.P_2.Location = new System.Drawing.Point(29, 266);
            this.P_2.Margin = new System.Windows.Forms.Padding(4);
            this.P_2.Name = "P_2";
            this.P_2.Size = new System.Drawing.Size(284, 159);
            this.P_2.TabIndex = 10;
            this.P_2.TabStop = false;
            this.P_2.Click += new System.EventHandler(this.P_0_Click);
            this.P_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_2_MouseDown);
            this.P_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_2_MouseUp);
            // 
            // P_3
            // 
            this.P_3.Image = global::SimonDice.Properties.Resources.CAmarillo_1;
            this.P_3.Location = new System.Drawing.Point(321, 266);
            this.P_3.Margin = new System.Windows.Forms.Padding(4);
            this.P_3.Name = "P_3";
            this.P_3.Size = new System.Drawing.Size(284, 159);
            this.P_3.TabIndex = 9;
            this.P_3.TabStop = false;
            this.P_3.Click += new System.EventHandler(this.P_0_Click);
            this.P_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_3_MouseDown);
            this.P_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_3_MouseUp);
            // 
            // P_1
            // 
            this.P_1.Image = global::SimonDice.Properties.Resources.CVerde_2;
            this.P_1.Location = new System.Drawing.Point(321, 100);
            this.P_1.Margin = new System.Windows.Forms.Padding(4);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(284, 159);
            this.P_1.TabIndex = 8;
            this.P_1.TabStop = false;
            this.P_1.Click += new System.EventHandler(this.P_0_Click);
            this.P_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_1_MouseDown);
            this.P_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_1_MouseUp);
            // 
            // P_0
            // 
            this.P_0.Image = global::SimonDice.Properties.Resources.CAzul_1;
            this.P_0.Location = new System.Drawing.Point(29, 100);
            this.P_0.Margin = new System.Windows.Forms.Padding(4);
            this.P_0.Name = "P_0";
            this.P_0.Size = new System.Drawing.Size(284, 159);
            this.P_0.TabIndex = 7;
            this.P_0.TabStop = false;
            this.P_0.Click += new System.EventHandler(this.P_0_Click);
            this.P_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_0_MouseDown);
            this.P_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_0_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SimonDiceClasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(630, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.P_2);
            this.Controls.Add(this.P_3);
            this.Controls.Add(this.P_1);
            this.Controls.Add(this.P_0);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSalir);
            this.Name = "SimonDiceClasico";
            this.Text = "SimonDiceClasico";
            ((System.ComponentModel.ISupportInitialize)(this.P_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.PictureBox P_2;
        private System.Windows.Forms.PictureBox P_3;
        private System.Windows.Forms.PictureBox P_1;
        private System.Windows.Forms.PictureBox P_0;
        private System.Windows.Forms.Timer timer1;
    }
}