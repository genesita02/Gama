using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_paises
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar la información de los países
        private Dictionary<string, string> countryInfo = new Dictionary<string, string>()
            {
            { "Seleccionar país", "" },
            { "Estados Unidos", "Capital: Washington, D.C.\r\nPoblación: 331 millones\r\nIdioma: Inglés" },
            { "España", "Capital: Madrid\r\nPoblación: 47 millones\r\nIdioma: Español" },
            { "argentina", "Capital: Ciudad de Buenos Aires\r\nPoblación: 46 millones\r\nIdioma: Español" },
            { "Republica Dominicana", "Capital: Santo Domingo\r\nPoblación: 11.12 millones\r\nIdioma: Español" },
            { "Colombia", "Capital: Bogota\r\nPoblación: 52 millones\r\nIdioma: Español" }
            // Agrega más países según sea necesario
        };
        public Form1()
        {
            InitializeComponent();

            InitializeComponent();
            // Agrega los países al ComboBox
            foreach (var country in countryInfo.Keys)
            {
                comboBox1.Items.Add(country);
            }

            comboBox1.SelectedIndex = 0;
        }

    }

    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
