
namespace WinFormsCRUD.Forms
{
    partial class Excluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.lblResultadoExcluir = new System.Windows.Forms.Label();
            this.mskCodigoCliente = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código do cliente";
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluirCliente.Location = new System.Drawing.Point(133, 73);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(213, 34);
            this.btnExcluirCliente.TabIndex = 2;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // lblResultadoExcluir
            // 
            this.lblResultadoExcluir.AutoSize = true;
            this.lblResultadoExcluir.Location = new System.Drawing.Point(133, 16);
            this.lblResultadoExcluir.Name = "lblResultadoExcluir";
            this.lblResultadoExcluir.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoExcluir.TabIndex = 3;
            // 
            // mskCodigoCliente
            // 
            this.mskCodigoCliente.Location = new System.Drawing.Point(304, 30);
            this.mskCodigoCliente.Mask = "0000000";
            this.mskCodigoCliente.Name = "mskCodigoCliente";
            this.mskCodigoCliente.Size = new System.Drawing.Size(42, 23);
            this.mskCodigoCliente.TabIndex = 4;
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 148);
            this.Controls.Add(this.mskCodigoCliente);
            this.Controls.Add(this.lblResultadoExcluir);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Label lblResultadoExcluir;
        private System.Windows.Forms.MaskedTextBox mskCodigoCliente;
    }
}