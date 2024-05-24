using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESTAMO_CUOTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Double Monto, Tasa_Interes, Cuotas, Total;
            int Años;

            Monto = Double.Parse(txt_monto_prestamo.Text);
            Años = int.Parse(txt_plazo_meses.Text);

            Tasa_Interes = ((Monto * 16)/100) * Años;

            Total = Monto + Tasa_Interes;
            Cuotas = Total/(Años * 12);


            txt_tasa_interes.Text = Tasa_Interes.ToString();
            txt_resultado.Text = Total.ToString();

            dgv_prestamo_cuota.Rows.Add(txt_monto_prestamo.Text, txt_plazo_meses.Text, txt_resultado.Text, txt_tasa_interes.Text);

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_monto_prestamo.Clear();
            txt_plazo_meses.Clear();
            txt_tasa_interes.Clear();
            txt_resultado.Clear();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (dlg_guarda.ShowDialog() == DialogResult.OK) ;
            {
                string rutaArchivo = dlg_guarda.FileName;
                string createxto = txt_monto_prestamo.Text;

                StreamWriter archivo = File.CreateText(rutaArchivo);

                archivo.Write(createxto);
                archivo.Flush();
                archivo.Close();
            }


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
