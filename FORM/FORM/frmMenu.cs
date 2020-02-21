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
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            frmAdicao adicao = new frmAdicao();
            adicao.Show();
            this.Hide();
            SoundPlayer somMusica = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\cafe.wav");
            somMusica.Play();
            somMusica.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmMultiplicacao mult = new frmMultiplicacao();
            mult.Show();
            this.Hide();
            SoundPlayer somMusica = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\cafe.wav");
            somMusica.Play();
            somMusica.Stop();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmSubtracao sub = new frmSubtracao();
            sub.Show();
            this.Hide();
            SoundPlayer somMusica = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\cafe.wav");
            somMusica.Play();
            somMusica.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmDivisao div = new frmDivisao();
            div.Show();
            this.Hide();
            SoundPlayer somMusica = new SoundPlayer(@"C:\Users\Vanderson\Desktop\FORM\Audios\cafe.wav");
            somMusica.Play();
            somMusica.Stop();
        }
        private void tocarMusicaMenu()
        {
            SoundPlayer somMusica = new SoundPlayer(@"\FORM\Audios\cafe.wav");
            somMusica.Play();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            tocarMusicaMenu();
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            tocarMusicaMenu();
        }
        private void btPause_Click(object sender, EventArgs e)
        {
            tocarMusicaMenu();
        }
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
