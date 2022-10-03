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
using Timer = System.Threading.Timer;

namespace WinFormsSplash
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            temporizador.Stop();
            FormPrincipal fp = new FormPrincipal();
            fp.Show();
            this.Hide();
        }

        private void FormSplash_show(object sender, EventArgs e)
        {
            temporizador.Start();
            SoundPlayer simpleSound = new SoundPlayer("D:\\Interfaces\\Tema2\\WinFormsSplash\\WinFormsSplash\\Sonidos\\ChistosoMc.wav");
            simpleSound.Play();
        }

    }
}
