using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prova1.DAL;
using Prova1.Controller;

namespace Prova1.Views
{
    public partial class HorasExtras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (txtIdFunc.Text.Equals("") && !txtDtPesq.Text.Equals(""))
            {
                DateTime dataPesq;
                dataPesq = Convert.ToDateTime(txtDtPesq.Text);
                gvwHorasExtras.DataSource = HoraExtraController.PesquisarHE(dataPesq);
                gvwHorasExtras.DataBind();
            }
            else
            {
                if (!txtIdFunc.Text.Equals(""))
                {
                    int id = 0;
                    id = int.Parse(txtIdFunc.Text);
                    
                    Funcionario f = new Funcionario();

                    f = FuncionariosController.PesquisarFunc(id);

                    if (f == null)
                    {
                        lblPesq.Text = "Funcionário não cadastrado";
                        LimparCampos();

                    }
                    else
                    {
                        txtNomeFunc.Text = f.Nome;


                        if (txtDtPesq.Text.Equals(""))
                        {
                            btnCadastrar.Enabled = true;
                        }
                        else
                        {
                            DateTime data;
                            data = Convert.ToDateTime(txtDtPesq.Text);
                            HorasExtra he = new HorasExtra();
                            he = HoraExtraController.PesquisarHEporIDeData(data, id);
                            if (he == null)
                            {
                                btnCadastrar.Enabled = true;
                                lblPesq.Text = "Este funcionário informado não possui hora extra para a data informada";

                            }
                            else
                            {
                                txtDataHe.Text = he.Data.Date.ToString();
                                txtDtInicio.Text = he.Inicio.TimeOfDay.ToString();
                                txtDtFim.Text = he.Fim.TimeOfDay.ToString();
                                string hr;
                                hr = he.Horas.Hour.ToString();
                                lblPesq.Text = "Este funcionário solicitou " + hr + " horas extras para este dia.";
                                txtDtTotal.Text = he.Horas.TimeOfDay.ToString();
                                btnCadastrar.Enabled = false;
                                btnAlterar.Enabled = true;
                                btnExcluir.Enabled = true;
                                txtIdFunc.Enabled = false;
                                txtNomeFunc.Enabled = false;
                            }
                        }

                    }
                }
            }
            

        }

        protected void LimparCampos()
        {
            txtIdFunc.Text = "";
            txtNomeFunc.Text = "";
            txtDataHe.Text = "";
            txtDtInicio.Text = "";
            txtDtFim.Text = "";
            txtDtTotal.Text = "";
            txtDtPesq.Text = "";
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        protected void btnListarHe_Click(object sender, EventArgs e)
        {
           /* if (txtDtPesq.Text.Equals(""))
            {*/
                gvwHorasExtras.DataSource = HoraExtraController.ListarHE();
                gvwHorasExtras.DataBind();
           /* }
            else
            {
                DateTime dataPesq;
                dataPesq = Convert.ToDateTime(txtDtPesq.Text);
                gvwHorasExtras.DataSource = HoraExtraController.PesquisarHE(dataPesq);
                gvwHorasExtras.DataBind();
            }*/
        }



        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            /*
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

            }
            else
            {
                txtNomeFunc.Text = f.Nome;

                DateTime ini, fim, total, data;

                if (!txtDataHe.Text.Equals(""))
                {
                    if (!txtDtInicio.Text.Equals("") && !txtDtFim.Text.Equals(""))
                    {
                        ini = Convert.ToDateTime(txtDtInicio.Text);

                        fim = Convert.ToDateTime(txtDtFim.Text);

                        if (fim >= ini)
                        {
                            string hr;
                            hr = (fim - ini).ToString();
                            data = Convert.ToDateTime(txtDataHe.Text);

                            HorasExtra he = new HorasExtra();
                            he.Funcionario = f;
                            he.Data = data;
                            he.Inicio = ini;
                            he.Fim = fim;
                            he.Horas = Convert.ToDateTime(hr);
                            he.Funcionario_Id = id;

                            try
                            {
                                HoraExtraController.AdicionarHE(he);
                                lblPesq.Text = "Foram cadastradas " + he.Horas.TimeOfDay.ToString() + " horas extras com sucesso";
                                LimparCampos();
                            }
                            catch (Exception erro)
                            {
                                lblPesq.Text = "Ocorreu um erro ao salvar as horas extras";
                            }
                        }
                        else
                        {
                            lblPesq.Text = "O horário final deve ser maior do que o inicial";
                        }
                    }
                    else
                    {
                        lblPesq.Text = "Por favor, preencha os horários para a hora extra";
                    }
                }
                else
                {
                    lblPesq.Text = "Por favor, preencha a data para a hora extra";

                }

            }*/

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

            }
            else
            {
                txtNomeFunc.Text = f.Nome;

                DateTime ini, fim, total, data;

                if (!txtDataHe.Text.Equals(""))
                {
                    if (!txtDtInicio.Text.Equals("") && !txtDtFim.Text.Equals(""))
                    {
                        ini = Convert.ToDateTime(txtDtInicio.Text);

                        fim = Convert.ToDateTime(txtDtFim.Text);

                        if (fim >= ini)
                        {
                            string hr;
                            hr = (fim - ini).ToString();
                            data = Convert.ToDateTime(txtDataHe.Text);

                            HorasExtra he = new HorasExtra();
                            he.Funcionario = f;
                            he.Data = data;
                            he.Inicio = ini;
                            he.Fim = fim;
                            he.Horas = Convert.ToDateTime(hr);
                            he.Funcionario_Id = f.Id;

                            try
                            {
                                HoraExtraController.AdicionarHE(he);
                                lblPesq.Text = "Foram cadastradas " + hr + " horas extras com sucesso";
                            }
                            catch (Exception erro)
                            {
                                lblPesq.Text = "Ocorreu um erro ao salvar as horas extras";
                            }
                        }
                        else
                        {
                            lblPesq.Text = "O horário final deve ser maior do que o inicial";
                        }
                    }
                    else
                    {
                        lblPesq.Text = "Por favor, preencha os horários para a hora extra";
                    }
                }
                else
                {
                    lblPesq.Text = "Por favor, preencha a data para a hora extra";

                }

            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            int id = 0;

            id = int.Parse(txtIdFunc.Text);
            
                DateTime ini, fim, data, dataOrig;

                if (!txtDataHe.Text.Equals(""))
                {
                    if (!txtDtInicio.Text.Equals("") && !txtDtFim.Text.Equals(""))
                    {
                        ini = Convert.ToDateTime(txtDtInicio.Text);

                        fim = Convert.ToDateTime(txtDtFim.Text);

                        if (fim >= ini)
                        {
                            data = Convert.ToDateTime(txtDataHe.Text);
                            dataOrig = Convert.ToDateTime(txtDtPesq.Text);

                            if (HoraExtraController.PesquisarHEporIDeData(data, id) != null)
                            {
                                
                                string hr;
                                hr = (fim - ini).ToString();
                                
                                HorasExtra he = new HorasExtra();

                                he = HoraExtraController.PesquisarHEporIDeData(dataOrig, id);
                                he.Data = data;
                                he.Inicio = ini;
                                he.Fim = fim;
                                he.Horas = Convert.ToDateTime(hr);
                                he.Funcionario_Id = id;

                                try
                                {
                                    HoraExtraController.AlterarHE(he);
                                    lblPesq.Text = "Hora extra alterada com sucesso";
                                    LimparCampos();
                                }
                                catch (Exception erro)
                                {
                                    lblPesq.Text = "Ocorreu um erro ao alterar as horas extras";
                                }
                             }
                            else
                            {
                                lblPesq.Text = "Este funcionário já possui horas extras cadastradas nesta nova data";
                            }
                        }
                        else
                        {
                            lblPesq.Text = "O horário final deve ser maior do que o inicial";
                        }
                    }
                    else
                    {
                        lblPesq.Text = "Por favor, preencha os horários para a hora extra";
                    }
                }
                else
                {
                    lblPesq.Text = "Por favor, preencha a data para a hora extra";

                }

            }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            HorasExtra he = new HorasExtra();
            int id = int.Parse(txtIdFunc.Text);
            DateTime data = Convert.ToDateTime(txtDtPesq.Text);
            he = HoraExtraController.PesquisarHEporIDeData(data, id);

            try
            {
                HoraExtraController.ExcluirHE(he);
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
