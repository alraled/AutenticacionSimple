using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AutenticacionSimple.Models
{
    public class Usuario
    {

        [DisplayName("Nombre de Usuario")]
        public String Login { get; set; }

        [DisplayName("Contraseña")]
        public String Password { get; set; }
    
        }
    }

