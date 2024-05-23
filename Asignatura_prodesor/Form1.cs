using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignatura_prodesor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_prosesar_Click(object sender, EventArgs e)
        {
            
            string asignatura = txt_asignatura.Text;
            string profesor = txt_profesor.Text;
            string modalidad = "";

            if (rdb_vistual.Checked)
            {
                modalidad = "Virtual";
            }
            else if (rdb_presencial.Checked)
            {
                modalidad = "Presencial";
            }
            if (radioButton1.Checked)
            {
                modalidad = "Ambos";
            }

            
            txt_informacion.Text = $"Asignatura: {asignatura}\nProfesor: {profesor}\nModalidad: {modalidad}";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_asignatura.Clear();
            txt_profesor.Clear();
            txt_informacion.Clear();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_informacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
