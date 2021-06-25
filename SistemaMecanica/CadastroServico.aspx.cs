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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) // Método que recebe o envio do formulário
        {

            string nomeserv = Request.Form["nomeserv"];
            if (nomeserv == "")
            {
                nomeserv = "nulo";
            }
            string descricao = Request.Form["descricao"];
            if (descricao == "")
            {
                descricao = "nulo";
            }
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
                valor = float.NaN;
            }
            

            Servico Serv = Cadastro.CadServico(nomeserv, descricao, valor); //Trecho para criar um objeto da classe Serviço ao ser preenchido e enviado pelo usuário.

            if (this.IsPostBack)
            {
                DataTable dt = new DataTable();

                dt.Columns.AddRange(new DataColumn[5] {
                new DataColumn("Id", typeof(int)),
                new DataColumn("Nome do serviço", typeof(string)),
                new DataColumn("Descrição do serviço",typeof(string)),
                new DataColumn("Valor", typeof(float)),
                new DataColumn("Delete", typeof(string))

                });

                int i = 1;

                StringBuilder sb = new StringBuilder();

                dt.Rows.Add(i, Serv.GetNomeserv(), Serv.GetDescricao(), Serv.GetValor(), "<a href=\"/CadastroServico\">delete</a>");





                
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
                sb.Append("<div><p>O 'objeto' Serviço foi cadastrado com os dados acima</p></div>");
                ltTable.Text = sb.ToString();
            }
        }
    }
}