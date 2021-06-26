﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaMecanica
{
    public partial class Servico : System.Web.UI.Page
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-3LC8U27;Initial Catalog=ASPCRUD;Integrated Security=true");
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
            hfServicoID.Value = "";
            txtNomeserv.Text = txtDescricao.Text = txtValor.Text = "";
            lblMensagemSucesso.Text = lblMensagemErro.Text = "";
            btnSalvar.Text = "Salvar";
            btnDeletar.Text = "Deletar";
            btnDeletar.Enabled = false;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("ServicoCreateOrUpdate", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ServicoID", (hfServicoID.Value == "" ? 0 : Convert.ToInt64(hfServicoID.Value)));
            sqlCmd.Parameters.AddWithValue("@Nomeserv", txtNomeserv.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Valor", txtValor.Text.Trim());
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            string ServicoID = hfServicoID.Value;
            Clear();
            if (hfServicoID.Value == "")
                lblMensagemSucesso.Text = "Salvo com sucesso";
            else
                lblMensagemSucesso.Text = "Atualizado com sucesso";
            FillGridView();
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("ServicoDeletarPorID", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ServicoID", Convert.ToInt32(hfServicoID.Value));
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
            SqlDataAdapter sqlDa = new SqlDataAdapter("ServicoViewAll", sqlCon);
            sqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            gvServico.DataSource = dtbl;
            gvServico.DataBind();
        }


        protected void gvServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int ServicoID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ServicoViewPorID", sqlCon);
            sqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@ServicoID", ServicoID);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            hfServicoID.Value = ServicoID.ToString();
            txtNomeserv.Text = dtbl.Rows[0]["Nomeserv"].ToString();
            txtDescricao.Text = dtbl.Rows[0]["Descricao"].ToString();
            txtValor.Text = dtbl.Rows[0]["Valor"].ToString();

            btnSalvar.Text = "Atualizar";
            btnDeletar.Enabled = true;
        }
    }

}