using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            int fontSize = trackBar.Value;
            lb_fuente.Font = new System.Drawing.Font(lb_tamaño.Font.FontFamily, fontSize);
            lb_tamaño.Text = $"Tamaño de Fuente: {fontSize}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
