namespace FORM
{
    partial class frmMultiplicacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultiplicacao));
            this.lbN1 = new System.Windows.Forms.Label();
            this.lbN2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbResposta = new System.Windows.Forms.Label();
            this.lbAcerto = new System.Windows.Forms.Label();
            this.txtAcertou = new System.Windows.Forms.TextBox();
            this.lbAcertos = new System.Windows.Forms.Label();
            this.lberros = new System.Windows.Forms.Label();
            this.txtErrou = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRespondidas = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.picmeninaE = new System.Windows.Forms.PictureBox();
            this.picmeninaA = new System.Windows.Forms.PictureBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaA)).BeginInit();
            this.SuspendLayout();
            // 
            // lbN1
            // 
            this.lbN1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbN1.AutoSize = true;
            this.lbN1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN1.Location = new System.Drawing.Point(279, 107);
            this.lbN1.Name = "lbN1";
            this.lbN1.Size = new System.Drawing.Size(0, 57);
            this.lbN1.TabIndex = 0;
            // 
            // lbN2
            // 
            this.lbN2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbN2.AutoSize = true;
            this.lbN2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN2.Location = new System.Drawing.Point(448, 107);
            this.lbN2.Name = "lbN2";
            this.lbN2.Size = new System.Drawing.Size(0, 57);
            this.lbN2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // lbResultado
            // 
            this.lbResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(436, 349);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(47, 57);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "?";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbResposta.AutoSize = true;
            this.lbResposta.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.Location = new System.Drawing.Point(466, 443);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(0, 57);
            this.lbResposta.TabIndex = 7;
            // 
            // lbAcerto
            // 
            this.lbAcerto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAcerto.AutoSize = true;
            this.lbAcerto.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcerto.Location = new System.Drawing.Point(244, 443);
            this.lbAcerto.Name = "lbAcerto";
            this.lbAcerto.Size = new System.Drawing.Size(203, 57);
            this.lbAcerto.TabIndex = 8;
            this.lbAcerto.Text = "Resposta:";
            // 
            // txtAcertou
            // 
            this.txtAcertou.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAcertou.Enabled = false;
            this.txtAcertou.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcertou.Location = new System.Drawing.Point(142, 436);
            this.txtAcertou.Multiline = true;
            this.txtAcertou.Name = "txtAcertou";
            this.txtAcertou.Size = new System.Drawing.Size(40, 37);
            this.txtAcertou.TabIndex = 10;
            this.txtAcertou.Text = "0";
            // 
            // lbAcertos
            // 
            this.lbAcertos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAcertos.AutoSize = true;
            this.lbAcertos.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcertos.Location = new System.Drawing.Point(51, 436);
            this.lbAcertos.Name = "lbAcertos";
            this.lbAcertos.Size = new System.Drawing.Size(85, 29);
            this.lbAcertos.TabIndex = 11;
            this.lbAcertos.Text = "Acertos:";
            // 
            // lberros
            // 
            this.lberros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lberros.AutoSize = true;
            this.lberros.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberros.Location = new System.Drawing.Point(70, 482);
            this.lberros.Name = "lberros";
            this.lberros.Size = new System.Drawing.Size(66, 29);
            this.lberros.TabIndex = 12;
            this.lberros.Text = "Erros:";
            // 
            // txtErrou
            // 
            this.txtErrou.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtErrou.Enabled = false;
            this.txtErrou.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrou.Location = new System.Drawing.Point(142, 482);
            this.txtErrou.Multiline = true;
            this.txtErrou.Name = "txtErrou";
            this.txtErrou.Size = new System.Drawing.Size(40, 37);
            this.txtErrou.TabIndex = 13;
            this.txtErrou.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Respondidas:";
            // 
            // txtRespondidas
            // 
            this.txtRespondidas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRespondidas.Enabled = false;
            this.txtRespondidas.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespondidas.Location = new System.Drawing.Point(142, 387);
            this.txtRespondidas.Multiline = true;
            this.txtRespondidas.Name = "txtRespondidas";
            this.txtRespondidas.Size = new System.Drawing.Size(40, 37);
            this.txtRespondidas.TabIndex = 15;
            this.txtRespondidas.Text = "0";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(572, 107);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(84, 48);
            this.txtUsuario.TabIndex = 33;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress_1);
            // 
            // picmeninaE
            // 
            this.picmeninaE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picmeninaE.Image = ((System.Drawing.Image)(resources.GetObject("picmeninaE.Image")));
            this.picmeninaE.Location = new System.Drawing.Point(786, 387);
            this.picmeninaE.Name = "picmeninaE";
            this.picmeninaE.Size = new System.Drawing.Size(169, 141);
            this.picmeninaE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmeninaE.TabIndex = 38;
            this.picmeninaE.TabStop = false;
            this.picmeninaE.Visible = false;
            // 
            // picmeninaA
            // 
            this.picmeninaA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picmeninaA.Image = ((System.Drawing.Image)(resources.GetObject("picmeninaA.Image")));
            this.picmeninaA.Location = new System.Drawing.Point(786, 387);
            this.picmeninaA.Name = "picmeninaA";
            this.picmeninaA.Size = new System.Drawing.Size(169, 141);
            this.picmeninaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmeninaA.TabIndex = 37;
            this.picmeninaA.TabStop = false;
            this.picmeninaA.Visible = false;
            // 
            // btGerar
            // 
            this.btGerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerar.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btGerar.Location = new System.Drawing.Point(678, 194);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(274, 47);
            this.btGerar.TabIndex = 40;
            this.btGerar.Text = "Próxima Questão";
            this.btGerar.UseVisualStyleBackColor = false;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click_1);
            // 
            // btCalcular
            // 
            this.btCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCalcular.BackColor = System.Drawing.Color.Lime;
            this.btCalcular.Enabled = false;
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCalcular.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.Black;
            this.btCalcular.Location = new System.Drawing.Point(374, 194);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(274, 47);
            this.btCalcular.TabIndex = 39;
            this.btCalcular.Text = "Mostrar Resultado";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click_1);
            // 
            // frmMultiplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 546);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.picmeninaE);
            this.Controls.Add(this.picmeninaA);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtRespondidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtErrou);
            this.Controls.Add(this.lberros);
            this.Controls.Add(this.lbAcertos);
            this.Controls.Add(this.txtAcertou);
            this.Controls.Add(this.lbAcerto);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbN2);
            this.Controls.Add(this.lbN1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMultiplicacao";
            this.Text = "Multiplicação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMultiplicacao_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmeninaA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbN1;
        private System.Windows.Forms.Label lbN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Label lbAcerto;
        private System.Windows.Forms.TextBox txtAcertou;
        private System.Windows.Forms.Label lbAcertos;
        private System.Windows.Forms.Label lberros;
        private System.Windows.Forms.TextBox txtErrou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRespondidas;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox picmeninaE;
        private System.Windows.Forms.PictureBox picmeninaA;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Button btCalcular;
    }
}

