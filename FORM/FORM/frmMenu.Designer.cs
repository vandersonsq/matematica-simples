﻿namespace FORM
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCalcular.BackColor = System.Drawing.Color.White;
            this.btCalcular.FlatAppearance.BorderSize = 0;
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcular.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btCalcular.Image")));
            this.btCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalcular.Location = new System.Drawing.Point(252, 90);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(242, 52);
            this.btCalcular.TabIndex = 22;
            this.btCalcular.Text = "Adição";
            this.btCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(252, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "Multiplicação";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(252, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 52);
            this.button2.TabIndex = 24;
            this.button2.Text = "Subtração";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(252, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 52);
            this.button3.TabIndex = 25;
            this.button3.Text = "Divisão";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btPlay
            // 
            this.btPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPlay.BackColor = System.Drawing.Color.White;
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Image = ((System.Drawing.Image)(resources.GetObject("btPlay.Image")));
            this.btPlay.Location = new System.Drawing.Point(569, 355);
            this.btPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(53, 50);
            this.btPlay.TabIndex = 26;
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btPause
            // 
            this.btPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPause.BackColor = System.Drawing.Color.White;
            this.btPause.FlatAppearance.BorderSize = 0;
            this.btPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPause.Image = ((System.Drawing.Image)(resources.GetObject("btPause.Image")));
            this.btPause.Location = new System.Drawing.Point(628, 355);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(53, 50);
            this.btPause.TabIndex = 27;
            this.btPause.UseVisualStyleBackColor = false;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 408);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu de Operações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btPause;
    }
}