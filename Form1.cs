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

namespace EjercicioSonidoYCargarImagen
{
    public partial class Form1 : Form

    {
        private SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = this.txtDirSonido.Text;

                // Load the .wav file.
                player.LoadAsync();
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            // Ensure WaitOnLoad is false.
            pictureBox1.WaitOnLoad = false;

            // Load the image asynchronously.
            pictureBox1.LoadAsync(@"C:\Users\jsamu\source\repos\EjercicioSonidoYCargarImagen\64663e9017f78.jpeg");
        }
    }
}
