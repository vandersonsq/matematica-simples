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
    public partial class primeiro : MetroFramework.Forms.MetroForm
    {
        public primeiro()
        {
            InitializeComponent();
        }
        public void adicao ()
        {
            SoundPlayer somErrou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Matemática\somMusica\errou.wav");
            SoundPlayer somAcertou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Matemática\somMusica\acertou.wav");

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
                //somAcertou.Play();
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
                //somErrou.Play();
                picmeninaE.Visible = true;
                int cont2 = int.Parse(txtErrou.Text);
                cont2++;
                txtErrou.Text = cont2.ToString();
                int resp = int.Parse(txtRespondidas.Text);
                resp++;
                txtRespondidas.Text = resp.ToString();
            }
        }
        public void subtracao()
        {
            //SoundPlayer somErrou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Audios\errou.wav");
            //SoundPlayer somAcertou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Audios\acertou.wav");

            int n1 = Convert.ToInt32(lbN1.Text);
            int n2 = Convert.ToInt32(lbN2.Text);
            int res = Convert.ToInt32(txtUsuario.Text);
            int resultado = 0;

            resultado = n1 - n2;

            if (res - resultado == 0)
            {
                lbResultado.Text = resultado.ToString();
                lbResposta.BackColor = System.Drawing.Color.Green;
                lbResposta.Text = "CORRETA";
                //somAcertou.Play();
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
                //somErrou.Play();
                picmeninaE.Visible = true;
                int cont2 = int.Parse(txtErrou.Text);
                cont2++;
                txtErrou.Text = cont2.ToString();
                int resp = int.Parse(txtRespondidas.Text);
                resp++;
                txtRespondidas.Text = resp.ToString();
            }
        }
        public void multiplicacao()
        {
            //SoundPlayer somErrou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Audios\errou.wav");
            //SoundPlayer somAcertou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Audios\acertou.wav");

            int n1 = Convert.ToInt32(lbN1.Text);
            int n2 = Convert.ToInt32(lbN2.Text);
            int res = Convert.ToInt32(txtUsuario.Text);
            int resultado = 0;

            resultado = n1 * n2;

            if (res - resultado == 0)
            {
                lbResultado.Text = resultado.ToString();
                lbResposta.BackColor = System.Drawing.Color.Green;
                lbResposta.Text = "CORRETA";
                //somAcertou.Play();
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
                //somErrou.Play();
                picmeninaE.Visible = true;
                int cont2 = int.Parse(txtErrou.Text);
                cont2++;
                txtErrou.Text = cont2.ToString();
                int resp = int.Parse(txtRespondidas.Text);
                resp++;
                txtRespondidas.Text = resp.ToString();
            }
        }
        public void divisao()
        {
           // SoundPlayer somErrou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Audios\errou.wav");
            //SoundPlayer somAcertou = new SoundPlayer(@"C:\Users\Vanderson\OneDrive - sga.pucminas.br\Vanderson\Faculdade\2º Semestre 2018\POO - Lab\C#\Finalizados\Matemática Básica\Audios\acertou.wav");

            int n1 = Convert.ToInt32(lbN1.Text);
            int n2 = Convert.ToInt32(lbN2.Text);
            double res = Convert.ToDouble(txtUsuario.Text);
            double resultado = 0;

            resultado = n1 / (double)n2;

            if (res - resultado == 0)
            {
                Math.Round(resultado, 0);
                Math.Truncate(resultado);
                lbResultado.Text = Math.Round(resultado, 0).ToString();
                
                lbResposta.BackColor = System.Drawing.Color.Green;
                lbResposta.Text = "CORRETA";
                //somAcertou.Play();
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
                //somErrou.Play();
                picmeninaE.Visible = true;
                int cont2 = int.Parse(txtErrou.Text);
                cont2++;
                txtErrou.Text = cont2.ToString();
                int resp = int.Parse(txtRespondidas.Text);
                resp++;
                txtRespondidas.Text = resp.ToString();
            }
        }
        public void limparCampos()
        {
            txtUsuario.Text = "";
            lbResultado.Text = "";
            picmeninaA.Visible = false;
            picmeninaE.Visible = false;

            lbN1.Text = "";
            lbN2.Text = "";

            Random alea = new Random();

            lbN1.Text += alea.Next(0, 10);
            lbN2.Text += alea.Next(0, 10);           
        }
        private void primeiro_Load(object sender, EventArgs e)
        {
            Random alea = new Random();

            lbN1.Text += alea.Next(0, 10);
            lbN2.Text += alea.Next(0, 10);   
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {         
            if (cbxTipos.Text == "+")
            {
                adicao();
            }
            if (cbxTipos.Text == "-")
            {
                subtracao();
            }
            if (cbxTipos.Text == "*")
            {
                multiplicacao();
            }
            if (cbxTipos.Text == "/")
            {
                divisao();
            }         
        }
        private void btGerar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtUsuario_ClientSizeChanged(object sender, EventArgs e)
        {
            
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                btCalcular.Enabled = false;
            }
            else
            {
                btCalcular.Enabled = true;
            }
        }
    }
}
