using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCRUD.Negocio;

namespace WinFormsCRUD.Forms
{
    public partial class Cadastro : Form
    {        
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblCepResultado.Text = "";
            lblNomeResultado.Text = "";
            lblLogResultado.Text = "";
            using (var contexto = new EntidadeDAOEntity())
            {
                Entidade newEntidade = new Entidade();
                newEntidade.Nome = txtNome.Text;
                newEntidade.Logradouro = txtLog.Text;
                newEntidade.Cep = mskCep.Text;
                newEntidade.Bairro = txtBairro.Text;
                newEntidade.Cidade = txtCidade.Text;
                newEntidade.Uf = txtUf.Text;
                newEntidade.Telefone = mskTel.Text;

                string conteudoCep = mskCep.Text;

                conteudoCep = conteudoCep.Replace("-", "").Trim();

                if (txtNome.Text == "")
                {
                    MessageBox.Show("Você deve digitar um nome!", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lblNomeResultado.Text = "Nome é obrigatório!";
                    lblNomeResultado.ForeColor = Color.Red;
                }
                else if (txtLog.Text == "")
                {
                    MessageBox.Show("Você deve digitar o endereço!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblLogResultado.Text = "Endereço é obrigatório!";
                    lblLogResultado.ForeColor = Color.Red;
                }
                else if (conteudoCep == "")
                {
                    MessageBox.Show("Você deve digitar um CEP", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblCepResultado.Text = "Digite o CEP!";
                    lblCepResultado.ForeColor = Color.Red;
                }
                else
                {
                    contexto.Adicionar(newEntidade);
                    MessageBox.Show("Cliente cadastro com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
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
        }
    }
}
