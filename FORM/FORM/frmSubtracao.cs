using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM
{
    public partial class frmSubtracao : MetroFramework.Forms.MetroForm
    {
        public frmSubtracao()
        {
            InitializeComponent();
        }
        private void frmSubtracao_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            lbN1.Text += r.Next(8);
            lbN2.Text += r.Next(8);
        }
        private void btGerar_Click(object sender, EventArgs e)
        {
            lbN1.Text = "";
            lbN2.Text = "";
            txtUsuario.Text = "";
            lbResposta.Text = "";
            lbResultado.Text = "";
            picmeninaA.Visible = false;
            picmeninaE.Visible = false;

            Random r = new Random();
            lbN1.Text += r.Next(10);
            lbN2.Text += r.Next(10);
        }
        private void frmSubtracao_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    formAberto.Show();
                    break;
                }
                SoundPlayer somMusica = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\cafe.wav");
                somMusica.Play();
            }
        }
        private void btCalcular_Click_1(object sender, EventArgs e)
        {
            SoundPlayer somErrou = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\errou.wav");
            SoundPlayer somAcertou = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\acertou.wav");

            int n1 = Convert.ToInt32(lbN1.Text);
            int n2 = Convert.ToInt32(lbN2.Text);
            int res = Convert.ToInt32(txtUsuario.Text);
            int resultado = 0;

            resultado = n1 + n2;

            if (res - resultado == 0)
            {
                lbResultado.Text = resultado.ToString();
                lbResposta.BackColor = System.Drawing.Color.Green;
                lbResposta.Text = "CORRETA";
                somAcertou.Play();
                picmeninaA.Visible = true;
                int cont = int.Parse(txtAcertou.Text);
                cont++;
                txtAcertou.Text = cont.ToString();
                int resp = int.Parse(txtRespondidas.Text);
                resp++;
                txtRespondidas.Text = resp.ToString();
            }
            else
            {
                lbResultado.Text = resultado.ToString();
                lbResposta.BackColor = System.Drawing.Color.Red;
                lbResposta.Text = "INCORRETA";
                somErrou.Play();
                picmeninaE.Visible = true;
                int cont2 = int.Parse(txtErrou.Text);
                cont2++;
                txtErrou.Text = cont2.ToString();
                int resp = int.Parse(txtRespondidas.Text);
                resp++;
                txtRespondidas.Text = resp.ToString();
            }
        }
        private void btGerar_Click_1(object sender, EventArgs e)
        {
            SoundPlayer somBotao = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\botao.wav");
            somBotao.Play();
            lbN1.Text = "";
            lbN2.Text = "";
            txtUsuario.Text = "";
            lbResposta.Text = "";
            lbResultado.Text = "";
            picmeninaA.Visible = false;
            picmeninaE.Visible = false;

            Random r = new Random();
            lbN1.Text += r.Next(10);
            lbN2.Text += r.Next(10);
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtUsuario.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btCalcular_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "")
            {
                btCalcular.Enabled = true;
            }
            else
            {
                btCalcular.Enabled = false;
            }
        }
    }
}
