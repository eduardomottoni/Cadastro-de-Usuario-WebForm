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
        protected void Page_Load(object sender, EventArgs e) // Método que recebe o envio do formulário
        {

            string nomeserv = Request.Form["nomeserv"];
            string descricao = Request.Form["descricao"];
            float valor = 0;
                try
            {
                valor = float.Parse(Request.Form["valor"]); // O método naturalmente retornava erro, então foi adicionada uma excessão para a primeira execução não encerrar o programa.
            }
            catch (ArgumentNullException)
            {

            }
            catch (FormatException)
            {
                
            }
            
            Cadastro.CadServico(nomeserv, descricao, valor); //Trecho para criar um objeto da classe Serviço ao ser preenchido e enviado pelo usuário.
        }
    }
}