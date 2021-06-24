using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaMecanica
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string nomeserv = Request.Form["nomeserv"];
            string descricao = Request.Form["descricao"];
            float valor = 0;
                try
            {
                valor = float.Parse(Request.Form["valor"]);
            }
            catch (ArgumentNullException)
            {

            }
            catch (FormatException)
            {
                
            }
            
            Cadastro.CadServico(nomeserv, descricao, valor);
        }
    }
}