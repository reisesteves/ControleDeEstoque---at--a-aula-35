﻿namespace GUI
{
    partial class frmConfiguracaoBancoDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracaoBancoDados));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btTestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco de dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(11, 32);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(547, 20);
            this.txtServidor.TabIndex = 4;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(11, 95);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(547, 20);
            this.txtBanco.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(11, 167);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(547, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(11, 243);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(547, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(501, 295);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(56, 19);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btTestar
            // 
            this.btTestar.Location = new System.Drawing.Point(284, 295);
            this.btTestar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTestar.Name = "btTestar";
            this.btTestar.Size = new System.Drawing.Size(202, 19);
            this.btTestar.TabIndex = 9;
            this.btTestar.Text = "Testar conexão";
            this.btTestar.UseVisualStyleBackColor = true;
            this.btTestar.Click += new System.EventHandler(this.btTestar_Click);
            // 
            // frmConfiguracaoBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 338);
            this.Controls.Add(this.btTestar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConfiguracaoBancoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do banco de dados";
            this.Load += new System.EventHandler(this.frmConfiguracaoBancoDados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btTestar;
    }
}