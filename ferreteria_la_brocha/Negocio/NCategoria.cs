using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class NCategoria
    {
       public static DataTable Listar_cat (string texto)
        {
            DCategoria datos = new DCategoria();
            return datos.Listar_cat (texto);
        }
    }
}
