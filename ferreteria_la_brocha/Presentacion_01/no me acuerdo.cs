using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_01
{
    public partial class no_me_acuerdo : Form
    {
        public no_me_acuerdo()
        {
            InitializeComponent();
        }

        #region "Mis sueños"

        private void Formato_cat()
        {
           
        }

        private void Listar_cat (String texto) 
        {

            dgv_principal.DataSource =  NCategoria.Listar_cat(texto);
        
        }
        private void no_me_acuerdo_Load(object sender, EventArgs e)
        {

        }
    }
}
