
namespace WinFormsCRUD.Forms
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNomeResultado = new System.Windows.Forms.Label();
            this.lblLogResultado = new System.Windows.Forms.Label();
            this.lblCepResultado = new System.Windows.Forms.Label();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(22, 125);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 23);
            this.mskCep.TabIndex = 3;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(22, 171);
            this.mskTel.Mask = "(00) 0 0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 23);
            this.mskTel.TabIndex = 7;
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Location = new System.Drawing.Point(492, 125);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(28, 23);
            this.txtUf.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(331, 125);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(147, 23);
            this.txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(129, 125);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(187, 23);
            this.txtBairro.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(22, 81);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(498, 23);
            this.txtLog.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(22, 152);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 15);
            this.lblTel.TabIndex = 26;
            this.lblTel.Text = "Telefone";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(492, 107);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 15);
            this.lblUf.TabIndex = 25;
            this.lblUf.Text = "UF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(331, 107);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(129, 107);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 15);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(22, 107);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(36, 15);
            this.lblCep.TabIndex = 22;
            this.lblCep.Text = "CEP *";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(22, 63);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(77, 15);
            this.lblLogradouro.TabIndex = 21;
            this.lblLogradouro.Text = "Logradouro *";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 15);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome *";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(129, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseCompatibleTextRendering = true;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNomeResultado
            // 
            this.lblNomeResultado.AutoSize = true;
            this.lblNomeResultado.Location = new System.Drawing.Point(69, 17);
            this.lblNomeResultado.Name = "lblNomeResultado";
            this.lblNomeResultado.Size = new System.Drawing.Size(0, 15);
            this.lblNomeResultado.TabIndex = 36;
            // 
            // lblLogResultado
            // 
            this.lblLogResultado.AutoSize = true;
            this.lblLogResultado.Location = new System.Drawing.Point(98, 63);
            this.lblLogResultado.Name = "lblLogResultado";
            this.lblLogResultado.Size = new System.Drawing.Size(0, 15);
            this.lblLogResultado.TabIndex = 37;
            // 
            // lblCepResultado
            // 
            this.lblCepResultado.AutoSize = true;
            this.lblCepResultado.Location = new System.Drawing.Point(53, 107);
            this.lblCepResultado.Name = "lblCepResultado";
            this.lblCepResultado.Size = new System.Drawing.Size(0, 15);
            this.lblCepResultado.TabIndex = 38;
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimparTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparTudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparTudo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparTudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparTudo.Location = new System.Drawing.Point(22, 222);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(100, 37);
            this.btnLimparTudo.TabIndex = 39;
            this.btnLimparTudo.Text = "Limpar tudo";
            this.btnLimparTudo.UseCompatibleTextRendering = true;
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 271);
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
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNomeResultado;
        private System.Windows.Forms.Label lblLogResultado;
        private System.Windows.Forms.Label lblCepResultado;
        private System.Windows.Forms.Button btnLimparTudo;
    }
}