using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SistemaMecanica
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string nome = Request.Form["nome"];
            string email = Request.Form["email"];
            string endereco = Request.Form["endereco"];
            long cpf = 0;
            try
            {
                cpf = Convert.ToInt64(Request.Form["cpf"]);
            }
            catch (FormatException)
            {

            }
            Cadastro.CadCliente(nome, email, endereco, cpf);

        }
    }
}