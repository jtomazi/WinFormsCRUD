
namespace WinFormsCRUD.Forms
{
    partial class frm_update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_update));
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.lblCepResultado = new System.Windows.Forms.Label();
            this.lblLogResultado = new System.Windows.Forms.Label();
            this.lblNomeResultado = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.mskBuscarEntidade = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscarEntidadeAtualizar = new System.Windows.Forms.Label();
            this.btnBuscarEntidadeAtualizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblResultadoBuscarCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimparTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparTudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparTudo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparTudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparTudo.Location = new System.Drawing.Point(18, 289);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(100, 37);
            this.btnLimparTudo.TabIndex = 58;
            this.btnLimparTudo.Text = "Limpar tudo";
            this.btnLimparTudo.UseCompatibleTextRendering = true;
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // lblCepResultado
            // 
            this.lblCepResultado.AutoSize = true;
            this.lblCepResultado.Location = new System.Drawing.Point(49, 174);
            this.lblCepResultado.Name = "lblCepResultado";
            this.lblCepResultado.Size = new System.Drawing.Size(0, 15);
            this.lblCepResultado.TabIndex = 57;
            // 
            // lblLogResultado
            // 
            this.lblLogResultado.AutoSize = true;
            this.lblLogResultado.Location = new System.Drawing.Point(94, 130);
            this.lblLogResultado.Name = "lblLogResultado";
            this.lblLogResultado.Size = new System.Drawing.Size(0, 15);
            this.lblLogResultado.TabIndex = 56;
            // 
            // lblNomeResultado
            // 
            this.lblNomeResultado.AutoSize = true;
            this.lblNomeResultado.Location = new System.Drawing.Point(65, 84);
            this.lblNomeResultado.Name = "lblNomeResultado";
            this.lblNomeResultado.Size = new System.Drawing.Size(0, 15);
            this.lblNomeResultado.TabIndex = 55;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(125, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseCompatibleTextRendering = true;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(18, 192);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 23);
            this.mskCep.TabIndex = 4;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(18, 238);
            this.mskTel.Mask = "(00) 0 0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 23);
            this.mskTel.TabIndex = 8;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(488, 192);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(28, 23);
            this.txtUf.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(327, 192);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(147, 23);
            this.txtCidade.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(125, 192);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(187, 23);
            this.txtBairro.TabIndex = 5;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(18, 148);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(498, 23);
            this.txtLog.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(18, 219);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 15);
            this.lblTel.TabIndex = 46;
            this.lblTel.Text = "Telefone";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(488, 174);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 15);
            this.lblUf.TabIndex = 45;
            this.lblUf.Text = "UF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(327, 174);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 44;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(125, 174);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 15);
            this.lblBairro.TabIndex = 43;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(18, 174);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(36, 15);
            this.lblCep.TabIndex = 42;
            this.lblCep.Text = "CEP *";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(18, 130);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(77, 15);
            this.lblLogradouro.TabIndex = 41;
            this.lblLogradouro.Text = "Logradouro *";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 15);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "Nome *";
            // 
            // mskBuscarEntidade
            // 
            this.mskBuscarEntidade.Location = new System.Drawing.Point(18, 37);
            this.mskBuscarEntidade.Mask = "000000";
            this.mskBuscarEntidade.Name = "mskBuscarEntidade";
            this.mskBuscarEntidade.Size = new System.Drawing.Size(36, 23);
            this.mskBuscarEntidade.TabIndex = 1;
            // 
            // lblBuscarEntidadeAtualizar
            // 
            this.lblBuscarEntidadeAtualizar.AutoSize = true;
            this.lblBuscarEntidadeAtualizar.Location = new System.Drawing.Point(18, 16);
            this.lblBuscarEntidadeAtualizar.Name = "lblBuscarEntidadeAtualizar";
            this.lblBuscarEntidadeAtualizar.Size = new System.Drawing.Size(88, 15);
            this.lblBuscarEntidadeAtualizar.TabIndex = 60;
            this.lblBuscarEntidadeAtualizar.Text = "Buscar cliente *";
            // 
            // btnBuscarEntidadeAtualizar
            // 
            this.btnBuscarEntidadeAtualizar.Location = new System.Drawing.Point(65, 37);
            this.btnBuscarEntidadeAtualizar.Name = "btnBuscarEntidadeAtualizar";
            this.btnBuscarEntidadeAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEntidadeAtualizar.TabIndex = 61;
            this.btnBuscarEntidadeAtualizar.Text = "Buscar";
            this.btnBuscarEntidadeAtualizar.UseVisualStyleBackColor = true;
            this.btnBuscarEntidadeAtualizar.Click += new System.EventHandler(this.btnBuscarEntidadeAtualizar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // lblResultadoBuscarCliente
            // 
            this.lblResultadoBuscarCliente.AutoSize = true;
            this.lblResultadoBuscarCliente.Location = new System.Drawing.Point(113, 16);
            this.lblResultadoBuscarCliente.Name = "lblResultadoBuscarCliente";
            this.lblResultadoBuscarCliente.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoBuscarCliente.TabIndex = 62;
            // 
            // frm_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 338);
            this.Controls.Add(this.lblResultadoBuscarCliente);
            this.Controls.Add(this.btnBuscarEntidadeAtualizar);
            this.Controls.Add(this.lblBuscarEntidadeAtualizar);
            this.Controls.Add(this.mskBuscarEntidade);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.lblCepResultado);
            this.Controls.Add(this.lblLogResultado);
            this.Controls.Add(this.lblNomeResultado);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Label lblCepResultado;
        private System.Windows.Forms.Label lblLogResultado;
        private System.Windows.Forms.Label lblNomeResultado;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mskBuscarEntidade;
        private System.Windows.Forms.Label lblBuscarEntidadeAtualizar;
        private System.Windows.Forms.Button btnBuscarEntidadeAtualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblResultadoBuscarCliente;
    }
}