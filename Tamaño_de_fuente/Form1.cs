using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamaño_de_fuente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Actualizar el tamaño de fuente del Label con el valor del TrackBar
            int fontSize = trackBar1.Value;
            label1.Text = $"Tamaño de fuente: {fontSize}";
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, fontSize);
        }
    }
}
