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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) // Método que recebe o envio do formulário
        {
           
            DataTable dt = new DataTable();
            string nome = Request.Form["nome"];
            if (nome == "")
            {
                nome = "nulo";
            }
            string email = Request.Form["email"];
            if (email == "")
            {
                email = "nulo";
            }
            string endereco = Request.Form["endereco"];
            if (endereco == "")
            {
                endereco = "nulo";
            }
            long cpf = 0;
            try
            {
                cpf = Convert.ToInt64(Request.Form["cpf"]); // Try para caso o valor enviado seja nulo ou incorreto, como letras por exemplo.
            }
            catch (FormatException)
            {

                Console.Write("Formato invalido");
               
            }
            if (cpf == 0)
            {
                cpf = 999999999949;
            }
            Cliente Clt = Cadastro.CadCliente(nome, email, endereco, cpf); // Essa chamada do método pretente criar um objeto Cliente e retornar o nome do cliente na linha abaixo.
            if (this.IsPostBack)
            {



                dt.Columns.AddRange(new DataColumn[6] {
                new DataColumn("Id", typeof(int)),
                new DataColumn("Nome", typeof(string)),
                new DataColumn("Cpf",typeof(long)),
                new DataColumn("Endereço", typeof(string)),
                new DataColumn("E-mail", typeof(string)),
                new DataColumn("Delete", typeof(string))
                });
                int i = 1;

                StringBuilder sb = new StringBuilder();

                dt.Rows.Add(i, Clt.GetNome(), Clt.GetCpf(), Clt.GetEmail(), Clt.GetEndereco(), "<a href=\"/CadastroCliente\">delete</a>");

                
                


                                    
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
                        sb.Append("<div><p>O 'objeto' Cliente foi declarado com os dados acima através da classe abstrata Cadastro, e seu método CadClient(). Os valores podem ser acessados, por exemplo, pelo método GetNome() ou Get<Variavel> para qualquer outra variável</p></div>");
                        ltTable.Text = sb.ToString();



               
                    }
                }

            
        }
    
    }

