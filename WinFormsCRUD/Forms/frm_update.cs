using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCRUD.Dados;
using WinFormsCRUD.Negocio;

namespace WinFormsCRUD.Forms
{
    public partial class frm_update : Form
    {
        public frm_update()
        {
            InitializeComponent();
        }

        private void btnBuscarEntidadeAtualizar_Click(object sender, EventArgs e)
        {            

            lblResultadoBuscarCliente.Text = "";
            if (mskBuscarEntidade.Text == "")
            {
                lblResultadoBuscarCliente.Text = "Informe o código do cliente!";
                lblResultadoBuscarCliente.ForeColor = Color.Red;
            }
            else
            {
                using (var contexto = new EntidadeContext())
                {
                    string Codigo = mskBuscarEntidade.Text;
                    var CodCliente = Convert.ToInt32(Codigo); //convertendo a string do código para int

                    Entidade entity = contexto.Entidades.FirstOrDefault(x => x.Id == CodCliente);
                    if (entity != null)
                    {
                        using (var context = new EntidadeContext())
                        {
                            var entidade = context.Entidades
                                .Where(e => e.Id == CodCliente)
                                .FirstOrDefault();

                            txtNome.Text = entidade.Nome;
                            txtLog.Text = entidade.Logradouro;
                            mskCep.Text = entidade.Cep;
                            txtBairro.Text = entidade.Bairro;
                            txtCidade.Text = entidade.Cidade;
                            txtUf.Text = entidade.Uf;
                            mskTel.Text = entidade.Telefone;

                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {           

            lblResultadoBuscarCliente.Text = "";
            if (mskBuscarEntidade.Text == "")
            {
                lblResultadoBuscarCliente.Text = "Informe o código do cliente!";
                lblResultadoBuscarCliente.ForeColor = Color.Red;
            }
            else
            {
                string Codigo = mskBuscarEntidade.Text;
                var CodCliente = Convert.ToInt32(Codigo); //convertendo a string do código para int

                using (var contexto = new EntidadeDAOEntity())
                {
                    Entidade entidade = new Entidade { Id = CodCliente };
                    entidade.Nome = txtNome.Text;
                    entidade.Logradouro = txtLog.Text;
                    entidade.Cep = mskCep.Text;
                    entidade.Bairro = txtBairro.Text;
                    entidade.Cidade = txtCidade.Text;
                    entidade.Uf = txtUf.Text;
                    entidade.Telefone = mskTel.Text;

                    contexto.Atualizar(entidade);
                }
                MessageBox.Show("Cliente atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }           

        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtLog.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskCep.Text = "";
            mskTel.Text = "";
            mskBuscarEntidade.Text = "";
        }
    }
}
