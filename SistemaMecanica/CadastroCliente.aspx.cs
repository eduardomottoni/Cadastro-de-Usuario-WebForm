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
        protected void Page_Load(object sender, EventArgs e) // Método que recebe o envio do formulário
        {


            string nome = Request.Form["nome"];
            string email = Request.Form["email"];
            string endereco = Request.Form["endereco"];
            long cpf = 0;
            try
            {
                cpf = Convert.ToInt64(Request.Form["cpf"]); // Try para caso o valor enviado seja nulo ou incorreto, como letras por exemplo.
            }
            catch (FormatException)
            {

            }
            Cadastro.CadCliente(nome, email, endereco, cpf); // Método de criação de um novo objeto da classe Cliente após o envio de formulário.

        }
    }
}