using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prova1.Views;
using Prova1.DAL;
using Prova1.Controller;

namespace Prova1.Views
{
    public partial class Funcionarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
            CarregarGrid();
        }

        protected void btnListarFunc_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            gvwFuncionarios.DataSource = FuncionariosController.ListarFunc();
            gvwFuncionarios.DataBind();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (!txtIdFunc.Text.Equals(""))
            {
                id = int.Parse(txtIdFunc.Text);
            }


            Funcionario f = new Funcionario();

            f = FuncionariosController.PesquisarFunc(id);

            if (f == null)
            {
                lblPesq.Text = "Funcionário não cadastrado";
                LimparCampos();
                btnCadastrar.Enabled = true;

            }
            else
            {
                txtNomeFunc.Text = f.Nome;
                txtDtNasc.Text = f.Nascimento.Date.ToString();
                txtTelefone.Text = f.Telefone;
                txtRG.Text = f.Rg;
                txtCPF.Text = f.Cpf;
                txtEndereco.Text = f.Endereco;
                txtCidade.Text = f.Cidade;
                txtDtAdmi.Text = f.Admissao.Date.ToString();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;
            }
        }




        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.Id = int.Parse(txtIdFunc.Text);
            f.Nome = txtNomeFunc.Text;
            f.Nascimento = Convert.ToDateTime(txtDtNasc.Text);
            f.Telefone = txtTelefone.Text;
            f.Rg = txtRG.Text;
            f.Cpf = txtCPF.Text;
            f.Endereco = txtEndereco.Text;
            f.Cidade = txtCidade.Text;
            f.Admissao = Convert.ToDateTime(txtDtAdmi.Text);

            try
            {
                FuncionariosController.AlterarFunc(f);
                lblPesq.Text = "Cadastro alterado com sucesso";
                CarregarGrid();
                LimparCampos();
            }
            catch (Exception erro)
            {
                lblPesq.Text = "Ocorreu um erro ao alterar os dados";
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (!txtIdFunc.Text.Equals(""))
            {
                id = int.Parse(txtIdFunc.Text);
            }

            if (FuncionariosController.PesquisarFunc(id) == null)
            {
                if (txtNomeFunc.Text.Equals("") || txtDtNasc.Text.Equals("") || txtCPF.Text.Equals(""))
                {
                    lblPesq.Text = "Preencha todos os campos";
                }
                else
                {
                    Funcionario f = new Funcionario();
                    f.Nome = txtNomeFunc.Text;
                    f.Nascimento = Convert.ToDateTime(txtDtNasc.Text);
                    f.Telefone = txtTelefone.Text;
                    f.Rg = txtRG.Text;
                    f.Cpf = txtCPF.Text;
                    f.Endereco = txtEndereco.Text;
                    f.Cidade = txtCidade.Text;
                    f.Admissao = Convert.ToDateTime(txtDtAdmi.Text);

                    try
                    {
                        FuncionariosController.AdicionarFunc(f);
                        lblPesq.Text = "Funcionário cadastrado com sucesso";
                        LimparCampos();
                    }
                    catch (Exception error)
                    {
                        lblPesq.Text = "Ocorreu um erro ao cadastrar este funcionário";
                    }
                }
            }
            else
            {
                lblPesq.Text = "O ID informado já possui um usuário cadastrado";
            }
        }

        protected void LimparCampos()
        {
            txtNomeFunc.Text = "";
            txtDtNasc.Text = "";
            txtTelefone.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtDtAdmi.Text = "";
            txtIdFunc.Text = "";
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.Id = int.Parse(txtIdFunc.Text);
            f.Nome = txtNomeFunc.Text;
            f.Nascimento = Convert.ToDateTime(txtDtNasc.Text);
            f.Telefone = txtTelefone.Text;
            f.Rg = txtRG.Text;
            f.Cpf = txtCPF.Text;
            f.Endereco = txtEndereco.Text;
            f.Cidade = txtCidade.Text;
            f.Admissao = Convert.ToDateTime(txtDtAdmi.Text);

            try
            {
                FuncionariosController.ExcluirFunc(f);
                lblPesq.Text = "Cadastro excluído com sucesso";
                LimparCampos();
            }
            catch (Exception erro)
            {
                lblPesq.Text = "Ocorreu um erro ao excluir os dados";
            }
        }
    }
}