namespace FORM
{
    partial class frmAdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicao));
            this.txtRespondidas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtErrou = new System.Windows.Forms.TextBox();
            this.lberros = new System.Windows.Forms.Label();
            this.lbAcertos = new System.Windows.Forms.Label();
            this.txtAcertou = new System.Windows.Forms.TextBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.lbAcerto = new System.Windows.Forms.Label();
            this.lbResposta = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbN2 = new System.Windows.Forms.Label();
            this.lbN1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.picmeninaE = new System.Windows.Forms.PictureBox();
            this.picmeninaA = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRespondidas
            // 
            this.txtRespondidas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRespondidas.Enabled = false;
            this.txtRespondidas.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespondidas.Location = new System.Drawing.Point(220, 622);
            this.txtRespondidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRespondidas.Multiline = true;
            this.txtRespondidas.Name = "txtRespondidas";
            this.txtRespondidas.Size = new System.Drawing.Size(58, 55);
            this.txtRespondidas.TabIndex = 31;
            this.txtRespondidas.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 622);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "Respondidas:";
            // 
            // txtErrou
            // 
            this.txtErrou.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtErrou.Enabled = false;
            this.txtErrou.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrou.Location = new System.Drawing.Point(220, 768);
            this.txtErrou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtErrou.Multiline = true;
            this.txtErrou.Name = "txtErrou";
            this.txtErrou.Size = new System.Drawing.Size(58, 55);
            this.txtErrou.TabIndex = 29;
            this.txtErrou.Text = "0";
            // 
            // lberros
            // 
            this.lberros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lberros.AutoSize = true;
            this.lberros.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberros.Location = new System.Drawing.Point(112, 768);
            this.lberros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lberros.Name = "lberros";
            this.lberros.Size = new System.Drawing.Size(97, 42);
            this.lberros.TabIndex = 28;
            this.lberros.Text = "Erros:";
            // 
            // lbAcertos
            // 
            this.lbAcertos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAcertos.AutoSize = true;
            this.lbAcertos.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcertos.Location = new System.Drawing.Point(84, 697);
            this.lbAcertos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAcertos.Name = "lbAcertos";
            this.lbAcertos.Size = new System.Drawing.Size(126, 42);
            this.lbAcertos.TabIndex = 27;
            this.lbAcertos.Text = "Acertos:";
            // 
            // txtAcertou
            // 
            this.txtAcertou.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAcertou.Enabled = false;
            this.txtAcertou.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcertou.Location = new System.Drawing.Point(220, 697);
            this.txtAcertou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcertou.Multiline = true;
            this.txtAcertou.Name = "txtAcertou";
            this.txtAcertou.Size = new System.Drawing.Size(58, 55);
            this.txtAcertou.TabIndex = 26;
            this.txtAcertou.Text = "0";
            // 
            // btGerar
            // 
            this.btGerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerar.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btGerar.Location = new System.Drawing.Point(1036, 334);
            this.btGerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(411, 72);
            this.btGerar.TabIndex = 25;
            this.btGerar.Text = "Próxima Questão";
            this.btGerar.UseVisualStyleBackColor = false;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // lbAcerto
            // 
            this.lbAcerto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAcerto.AutoSize = true;
            this.lbAcerto.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcerto.Location = new System.Drawing.Point(374, 708);
            this.lbAcerto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAcerto.Name = "lbAcerto";
            this.lbAcerto.Size = new System.Drawing.Size(302, 83);
            this.lbAcerto.TabIndex = 24;
            this.lbAcerto.Text = "Resposta:";
            // 
            // lbResposta
            // 
            this.lbResposta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbResposta.AutoSize = true;
            this.lbResposta.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.Location = new System.Drawing.Point(706, 708);
            this.lbResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(0, 83);
            this.lbResposta.TabIndex = 23;
            // 
            // lbResultado
            // 
            this.lbResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(832, 559);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(68, 83);
            this.lbResultado.TabIndex = 22;
            this.lbResultado.Text = "?";
            // 
            // btCalcular
            // 
            this.btCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCalcular.BackColor = System.Drawing.Color.Lime;
            this.btCalcular.Enabled = false;
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCalcular.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.Black;
            this.btCalcular.Location = new System.Drawing.Point(580, 334);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(411, 72);
            this.btCalcular.TabIndex = 21;
            this.btCalcular.Text = "Mostrar Resultado";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 83);
            this.label2.TabIndex = 19;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 83);
            this.label1.TabIndex = 18;
            this.label1.Text = "+";
            // 
            // lbN2
            // 
            this.lbN2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbN2.AutoSize = true;
            this.lbN2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN2.Location = new System.Drawing.Point(680, 191);
            this.lbN2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbN2.Name = "lbN2";
            this.lbN2.Size = new System.Drawing.Size(0, 83);
            this.lbN2.TabIndex = 17;
            // 
            // lbN1
            // 
            this.lbN1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbN1.AutoSize = true;
            this.lbN1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN1.Location = new System.Drawing.Point(426, 191);
            this.lbN1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbN1.Name = "lbN1";
            this.lbN1.Size = new System.Drawing.Size(0, 83);
            this.lbN1.TabIndex = 16;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(866, 191);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(124, 72);
            this.txtUsuario.TabIndex = 32;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress_1);
            // 
            // picmeninaE
            // 
            this.picmeninaE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picmeninaE.Image = ((System.Drawing.Image)(resources.GetObject("picmeninaE.Image")));
            this.picmeninaE.Location = new System.Drawing.Point(1173, 608);
            this.picmeninaE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picmeninaE.Name = "picmeninaE";
            this.picmeninaE.Size = new System.Drawing.Size(254, 217);
            this.picmeninaE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmeninaE.TabIndex = 38;
            this.picmeninaE.TabStop = false;
            this.picmeninaE.Visible = false;
            // 
            // picmeninaA
            // 
            this.picmeninaA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picmeninaA.Image = ((System.Drawing.Image)(resources.GetObject("picmeninaA.Image")));
            this.picmeninaA.Location = new System.Drawing.Point(1173, 608);
            this.picmeninaA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picmeninaA.Name = "picmeninaA";
            this.picmeninaA.Size = new System.Drawing.Size(254, 217);
            this.picmeninaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmeninaA.TabIndex = 37;
            this.picmeninaA.TabStop = false;
            this.picmeninaA.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 559);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 83);
            this.label4.TabIndex = 39;
            this.label4.Text = "A resposta é:";
            // 
            // frmAdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 840);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picmeninaE);
            this.Controls.Add(this.picmeninaA);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtRespondidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtErrou);
            this.Controls.Add(this.lberros);
            this.Controls.Add(this.lbAcertos);
            this.Controls.Add(this.txtAcertou);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.lbAcerto);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbN2);
            this.Controls.Add(this.lbN1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicao";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Adição";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdicao_FormClosed);
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRespondidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtErrou;
        private System.Windows.Forms.Label lberros;
        private System.Windows.Forms.Label lbAcertos;
        private System.Windows.Forms.TextBox txtAcertou;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Label lbAcerto;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbN2;
        private System.Windows.Forms.Label lbN1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox picmeninaE;
        private System.Windows.Forms.PictureBox picmeninaA;
        private System.Windows.Forms.Label label4;
    }
}