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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }
        

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            lblResultadoExcluir.Text = ""; 

            if (mskCodigoCliente.Text == "")
            {
                lblResultadoExcluir.Text = "Informe um código de cliente!";
                lblResultadoExcluir.ForeColor = Color.Red;
            }
            else if (MessageBox.Show($"Tem certeza que deseja excluir o cliente{mskCodigoCliente.Text} ?", "Excluir cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var contexto = new EntidadeContext())
                {
                    string Codigo = mskCodigoCliente.Text;
                    var CodCliente = Convert.ToInt32(Codigo); //convertendo a string do código para int

                    Entidade entity = contexto.Entidades.FirstOrDefault(x => x.Id == CodCliente);
                    if (entity != null)
                    {
                        using (var context = new EntidadeDAOEntity())
                        {
                            Entidade entidade = new Entidade { Id = CodCliente };
                            context.Remover(entidade);

                        }
                        MessageBox.Show("Cliente excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                this.Close();
            }            
            
              
        }
    }
}
