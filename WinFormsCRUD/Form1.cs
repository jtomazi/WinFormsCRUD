using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsCRUD.Dados;
using Microsoft.EntityFrameworkCore;
using WinFormsCRUD.Forms;

namespace WinFormsCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                using (var contexto = new EntidadeContext())
                {
                    var entidades = contexto.Entidades.Take(20);
                    txtMsg.Text = "";
                    foreach (var entidade in entidades)
                    {
                        txtMsg.AppendText("\r\n" + entidade.ToString() + "\r\n");
                    }
                }
            }
            else
            {
                txtMsg.Text = "";
                using (var contexto = new EntidadeContext())
                {
                    var result = contexto.Entidades
                        .Where(r => EF.Functions.Like(r.Nome, $"%{txtBuscar.Text}%")).ToList();

                    foreach (var entidade in result)
                    {
                        txtMsg.AppendText("\r\n" + entidade.ToString() + "\r\n");
                    }
                                            
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro frm_Register = new Cadastro();
            frm_Register.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir frm_Delete = new Excluir();
            frm_Delete.ShowDialog();
        }
        private void txtAlterar_Click(object sender, EventArgs e)
        {
            frm_update frm_Update = new frm_update();
            frm_Update.ShowDialog();
        }       

        
    }
}
