using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SistemaMecanica
{
    public partial class Veiculo : System.Web.UI.Page
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
            hfVeiculoID.Value = "";
            txtPlaca.Text = txtTipo.Text = txtModelo.Text = txtMarca.Text = txtAnomodelo.Text = txtAnofabricacao.Text = "";
            lblMensagemSucesso.Text = lblMensagemErro.Text = "";
            btnSalvar.Text = "Salvar";
            btnDeletar.Text = "Deletar";
            btnDeletar.Enabled = false;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("VeiculoCreateOrUpdate", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@VeiculoID", (hfVeiculoID.Value == "" ? 0 : Convert.ToInt64(hfVeiculoID.Value)));
            sqlCmd.Parameters.AddWithValue("@Placa", txtPlaca.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Tipo", txtTipo.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Modelo", txtModelo.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Marca", txtMarca.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Anomodelo", txtAnomodelo.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Anofabricacao", txtAnofabricacao.Text.Trim());
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            string VeiculoID = hfVeiculoID.Value;
            Clear();
            if (hfVeiculoID.Value == "")
                lblMensagemSucesso.Text = "Salvo com sucesso";
            else
                lblMensagemSucesso.Text = "Atualizado com sucesso";
            FillGridView();
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("VeiculoDeletarPorID", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@VeiculoID", Convert.ToInt32(hfVeiculoID.Value));
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            Clear();
            FillGridView();
            lblMensagemSucesso.Text = "Deletado com sucesso";
        }

        void FillGridView()
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("VeiculoViewAll", sqlCon);
            sqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            gvVeiculo.DataSource = dtbl;
            gvVeiculo.DataBind();
        }


        protected void gvVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int VeiculoID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("VeiculoViewPorID", sqlCon);
            sqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@VeiculoID", VeiculoID);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            hfVeiculoID.Value = VeiculoID.ToString();
            txtPlaca.Text = dtbl.Rows[0]["Placa"].ToString();
            txtTipo.Text = dtbl.Rows[0]["Tipo"].ToString();
            txtModelo.Text = dtbl.Rows[0]["Modelo"].ToString();
            txtMarca.Text = dtbl.Rows[0]["Marca"].ToString();
            txtAnomodelo.Text = dtbl.Rows[0]["Anomodelo"].ToString();
            txtAnofabricacao.Text = dtbl.Rows[0]["Anofabricacao"].ToString();
            btnSalvar.Text = "Atualizar";
            btnDeletar.Enabled = true;
        }
    }

}