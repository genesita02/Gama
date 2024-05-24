using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Decimal montoTotal;

            if (decimal.TryParse(txt_monto_total.Text, out montoTotal))
            {
                decimal descuento = CalcularDescuento(montoTotal);
                decimal itbis = CalcularITBIS(montoTotal);
                decimal montoNeto = montoTotal - descuento + itbis;

                if (descuento > 0)
                {
                    MessageBox.Show($"Se aplicará un descuento de {descuento:C}\n" +
                                    $"El ITBIS a aplicar es: {itbis:C}\n" +
                                    $"El monto neto a pagar es: {montoNeto:C}",
                                    "Información de Pago");
                }
                else
                {
                    MessageBox.Show("No aplica descuento.", "Información de Pago");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido.", "Error de Entrada");
            }
        }

        private decimal CalcularDescuento(decimal montoTotal)
        {
            decimal descuento = 0;

            if (montoTotal >= 1001 && montoTotal <= 10000)
            {
                descuento = montoTotal * 0.03m;
            }
            else if (montoTotal > 10000 && montoTotal <= 15000)
            {
                descuento = montoTotal * 0.05m;
            }
            else if (montoTotal > 15000 && montoTotal <= 20000)
            {
                descuento = montoTotal * 0.08m;
            }
            else if (montoTotal > 20000)
            {
                descuento = montoTotal * 0.10m;
            }

            return descuento;
        }

        private decimal CalcularITBIS(decimal montoTotal)
        {
            // Supondremos que el ITBIS es el 18% del monto total
            return montoTotal * 0.18m;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_descuento.Clear();
            txt_itbis.Clear();
            txt_monto_neto.Clear();
            txt_monto_total.Clear();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

