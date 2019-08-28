using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Canny
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _Imginput;
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _Imginput = new Image<Bgr, byte>(ofd.FileName);
                panAndZoomPictureBox1.Image = _Imginput.Bitmap;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar?", "Cerrar Ventana", MessageBoxButtons.YesNo) == DialogResult.Yes);

        }

        private void cAnnyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
