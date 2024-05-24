using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace impuesto_sobre_larenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string Status;
            double sueldoNeto;
            double isr;
            double afp, sfs;


            double sueldo = Convert.ToDouble(txt_Sueldo.Text);



            afp = sueldo * 0.0287; // 2.87%
            sfs = sueldo * 0.0304; // 3.04%


            double totalDescuentos = afp + sfs;
            sueldoNeto = (sueldo - totalDescuentos) * 12;


            if (sueldoNeto <= 416220.00)
            {
                isr = 0;
                txt_Status.Text = " No Aplica";
            }
            else if (sueldoNeto >= 416220.01 && sueldoNeto <= 624329.00)
            {
                isr = (sueldoNeto - 416220.00) * 0.15;
                txt_Status.Text = "Aplica";
            }
            else if (sueldoNeto >= 624329.01 && sueldoNeto <= 867123.00)
            {
                isr = (sueldoNeto - 624329.00) * 0.20 + 31216.00 / 12;
                txt_Status.Text = "Aplica";
            }
            else if (sueldoNeto <= 867123.01 && sueldoNeto <= 100000.00)
            {
                isr = (sueldoNeto - 867123.00) * 0.25 + 79776.00 / 12;
                txt_Status.Text = "Aplica";
            }
            else
            {
                isr = (sueldoNeto - 1000000.00) * 0.30 + 181920.00 / 12;
                txt_Status.Text = "Aplica";
            }




            txt_isr.Text = isr.ToString();
            txt_afp.Text = afp.ToString("0.00");
            txt_sfs.Text = sfs.ToString("0.00");



        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txt_Status.Clear();
            txt_Sueldo.Clear();
            txt_isr.Clear();
            txt_afp.Clear();
            txt_sfs.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

