using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace SistemaMecanica
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) // Método de criação de um objeto da classe Veículo
        {
            string placa = Request.Form["placa"];
            if (placa == "")
            {
                placa = "nulo";
            }
            string tipo = Request.Form["tipo"];
            if (tipo == "")
            {
                tipo = "nulo";
            }
            string marca = Request.Form["marca"];
            if (marca == "")
            {
                marca = "nulo";
            }
            string modelo = Request.Form["modelo"];
            if (modelo == "")
            {
                modelo = "nulo";
            }
            int anomodelo = 0;
            try
            {
                anomodelo = Convert.ToInt32(Request.Form["anomodelo"]); // Try para caso o valor enviado seja nulo ou incorreto, como letras por exemplo.
            }
            catch (FormatException)
            {

            }
            if (anomodelo == 0)
            {
                anomodelo = 9999;
            }
            int anofabricacao = 0;
            try
            {
                anofabricacao = Convert.ToInt32(Request.Form["anofabricacao"]); // Try para caso o valor enviado seja nulo ou incorreto, como letras por exemplo.
            }
            catch (FormatException)
            {

            }
            if (anofabricacao == 0)
            {
                anofabricacao = 9999;
            }
            Veiculo Veic = Cadastro.CadVeiculo(placa, tipo, marca, modelo, anomodelo, anofabricacao);  // Essa chamada do método pretente criar um objeto Veiculo e retornar o nome do cliente na linha abaixo.
            if (this.IsPostBack)
            {

                DataTable dt = new DataTable();

                dt.Columns.AddRange(new DataColumn[7] {
                new DataColumn("Id", typeof(int)),
                new DataColumn("placa", typeof(string)),
                new DataColumn("marca",typeof(string)),
                new DataColumn("modelo", typeof(string)),
                new DataColumn("anomodelo", typeof(int)),
                new DataColumn("anofabricacao", typeof(int)),
                new DataColumn("Delete", typeof(string))
                });
                int i = 1;

                StringBuilder sb = new StringBuilder();

                dt.Rows.Add(i, Veic.GetPlaca(), Veic.GetMarca(), Veic.GetModelo(), Veic.GetAnomodelo(), Veic.GetAnofabricacao(), "<a href=\"/CadastroCliente\">delete</a>");

                //Table start.

                sb.Append("<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:Arial'>");

                //Adding HeaderRow.
                sb.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.ColumnName + "</th>");
                }
                sb.Append("</tr>");


                //Adding DataRow.
                foreach (DataRow row in dt.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        sb.Append("<td style='width:100px;border: 1px solid #ccc'>" + row[column.ColumnName].ToString() + "</td>");
                    }
                    sb.Append("</tr>");
                }

                //Table end.
                sb.Append("</table>");
                sb.Append("<div><p>O 'objeto' Veículo foi cadastrado com os dados acima</p></div>");
                ltTable.Text = sb.ToString();
            }
        }
    }
}