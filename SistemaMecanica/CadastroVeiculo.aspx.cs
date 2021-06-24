using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaMecanica
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) // Método de criação de um objeto da classe Veículo
        {
            string placa = Request.Form["placa"];
            string tipo = Request.Form["tipo"];
            string marca = Request.Form["marca"];
            string modelo = Request.Form["modelo"];
            int anomodelo = 0;
            try
            {
                anomodelo = Convert.ToInt32(Request.Form["anomodelo"]); // Try para caso o valor enviado seja nulo ou incorreto, como letras por exemplo.
            }
            catch (FormatException)
            {

            }
            int anofabricacao = 0;
            try
            {
                anofabricacao = Convert.ToInt32(Request.Form["anofabricacao"]); // Try para caso o valor enviado seja nulo ou incorreto, como letras por exemplo.
            }
            catch (FormatException)
            {

            }

            Cadastro.CadVeiculo(placa, tipo, marca, modelo, anomodelo, anofabricacao);
        }
    }
}