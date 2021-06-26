using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SistemaMecanica
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(local);Initial Catalog=ASPCRUD;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDeletar.Enabled = false;
                FillGridView();
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            hfClienteID.Value = "";
            txtNome.Text = txtEmail.Text = txtCPF.Text = txtEndereco.Text = "";
            lblMensagemSucesso.Text = lblMensagemErro.Text = "";
            btnSalvar.Text = "Salvar";
            btnDeletar.Text = "Deletar";
            btnDeletar.Enabled = false;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("ClienteCreateOrUpdate", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ClienteID", (hfClienteID.Value == "" ? 0 : Convert.ToInt64(hfClienteID.Value)));
            sqlCmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text.Trim());
            sqlCmd.Parameters.AddWithValue("Cpf", txtCPF.Text.Trim());
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            string clienteID = hfClienteID.Value;
            Clear();
            if (hfClienteID.Value == "")
                lblMensagemSucesso.Text = "Salvo com sucesso";
            else
                lblMensagemSucesso.Text = "Atualizado com sucesso";
            FillGridView();

        }
        void FillGridView()
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ClienteViewAll", sqlCon);
            sqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            gvCliente.DataSource = dtbl;
            gvCliente.DataBind();
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int clienteID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ClienteViewPorID", sqlCon);
            sqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@ClienteID", clienteID);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            hfClienteID.Value = clienteID.ToString();
            txtNome.Text = dtbl.Rows[0]["Nome"].ToString();
            txtEmail.Text = dtbl.Rows[0]["Email"].ToString();
            txtEndereco.Text = dtbl.Rows[0]["Endereco"].ToString();
            txtCPF.Text = dtbl.Rows[0]["Cpf"].ToString();
            btnSalvar.Text = "Atualizar";
            btnDeletar.Enabled = true;
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("ClienteDeletarPorID", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ClienteID", Convert.ToInt32(hfClienteID.Value));
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            Clear();
            FillGridView();
            lblMensagemSucesso.Text = "Deletado com sucesso";
        }
    }
}