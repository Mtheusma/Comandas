namespace Padarosa.Formularios
{
    partial class MenuUsuarios
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.lblCad = new System.Windows.Forms.Label();
            this.grbEdicao = new System.Windows.Forms.GroupBox();
            this.btnEdicao = new System.Windows.Forms.Button();
            this.txtEmailEd = new System.Windows.Forms.TextBox();
            this.lblEmailEd = new System.Windows.Forms.Label();
            this.lblNomeCompletoEd = new System.Windows.Forms.Label();
            this.txtNomeCompletoEd = new System.Windows.Forms.TextBox();
            this.txtNovaSenhaEd = new System.Windows.Forms.TextBox();
            this.lblNovaSenhaEd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEdicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(266, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GERENCIAMENTOS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(14, 61);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(614, 212);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txtSenhaCad);
            this.grbCadastro.Controls.Add(this.lblSenhaCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.txtEmailCad);
            this.grbCadastro.Controls.Add(this.txtCad);
            this.grbCadastro.Controls.Add(this.lblCad);
            this.grbCadastro.Location = new System.Drawing.Point(14, 279);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(216, 177);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            this.grbCadastro.Enter += new System.EventHandler(this.grbCadastro_Enter);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(62, 148);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(116, 81);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaCad.TabIndex = 5;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(0, 88);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaCad.TabIndex = 4;
            this.lblSenhaCad.Text = "Senha";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(0, 50);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(32, 13);
            this.lblEmailCad.TabIndex = 3;
            this.lblEmailCad.Text = "Email";
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Location = new System.Drawing.Point(116, 47);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(100, 20);
            this.txtEmailCad.TabIndex = 2;
            // 
            // txtCad
            // 
            this.txtCad.Location = new System.Drawing.Point(116, 118);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(100, 20);
            this.txtCad.TabIndex = 1;
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.Location = new System.Drawing.Point(0, 121);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(82, 13);
            this.lblCad.TabIndex = 0;
            this.lblCad.Text = "Nome Completo";
            // 
            // grbEdicao
            // 
            this.grbEdicao.Controls.Add(this.btnEdicao);
            this.grbEdicao.Controls.Add(this.txtEmailEd);
            this.grbEdicao.Controls.Add(this.lblEmailEd);
            this.grbEdicao.Controls.Add(this.lblNomeCompletoEd);
            this.grbEdicao.Controls.Add(this.txtNomeCompletoEd);
            this.grbEdicao.Controls.Add(this.txtNovaSenhaEd);
            this.grbEdicao.Controls.Add(this.lblNovaSenhaEd);
            this.grbEdicao.Location = new System.Drawing.Point(412, 288);
            this.grbEdicao.Name = "grbEdicao";
            this.grbEdicao.Size = new System.Drawing.Size(216, 177);
            this.grbEdicao.TabIndex = 3;
            this.grbEdicao.TabStop = false;
            this.grbEdicao.Text = "Edição";
            // 
            // btnEdicao
            // 
            this.btnEdicao.Location = new System.Drawing.Point(62, 148);
            this.btnEdicao.Name = "btnEdicao";
            this.btnEdicao.Size = new System.Drawing.Size(100, 23);
            this.btnEdicao.TabIndex = 6;
            this.btnEdicao.Text = "EDITAR";
            this.btnEdicao.UseVisualStyleBackColor = true;
            this.btnEdicao.Click += new System.EventHandler(this.btnEdicao_Click);
            // 
            // txtEmailEd
            // 
            this.txtEmailEd.Location = new System.Drawing.Point(116, 81);
            this.txtEmailEd.Name = "txtEmailEd";
            this.txtEmailEd.Size = new System.Drawing.Size(100, 20);
            this.txtEmailEd.TabIndex = 5;
            // 
            // lblEmailEd
            // 
            this.lblEmailEd.AutoSize = true;
            this.lblEmailEd.Location = new System.Drawing.Point(0, 88);
            this.lblEmailEd.Name = "lblEmailEd";
            this.lblEmailEd.Size = new System.Drawing.Size(32, 13);
            this.lblEmailEd.TabIndex = 4;
            this.lblEmailEd.Text = "Email";
            this.lblEmailEd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNomeCompletoEd
            // 
            this.lblNomeCompletoEd.AutoSize = true;
            this.lblNomeCompletoEd.Location = new System.Drawing.Point(0, 50);
            this.lblNomeCompletoEd.Name = "lblNomeCompletoEd";
            this.lblNomeCompletoEd.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompletoEd.TabIndex = 3;
            this.lblNomeCompletoEd.Text = "Nome Completo";
            // 
            // txtNomeCompletoEd
            // 
            this.txtNomeCompletoEd.Location = new System.Drawing.Point(116, 47);
            this.txtNomeCompletoEd.Name = "txtNomeCompletoEd";
            this.txtNomeCompletoEd.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCompletoEd.TabIndex = 2;
            // 
            // txtNovaSenhaEd
            // 
            this.txtNovaSenhaEd.Location = new System.Drawing.Point(116, 118);
            this.txtNovaSenhaEd.Name = "txtNovaSenhaEd";
            this.txtNovaSenhaEd.Size = new System.Drawing.Size(100, 20);
            this.txtNovaSenhaEd.TabIndex = 1;
            // 
            // lblNovaSenhaEd
            // 
            this.lblNovaSenhaEd.AutoSize = true;
            this.lblNovaSenhaEd.Location = new System.Drawing.Point(0, 121);
            this.lblNovaSenhaEd.Name = "lblNovaSenhaEd";
            this.lblNovaSenhaEd.Size = new System.Drawing.Size(67, 13);
            this.lblNovaSenhaEd.TabIndex = 0;
            this.lblNovaSenhaEd.Text = "Nova Senha";
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 538);
            this.Controls.Add(this.grbEdicao);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuUsuarios";
            this.Text = "GERENCIAMENTOS";
            this.Load += new System.EventHandler(this.MenuUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEdicao.ResumeLayout(false);
            this.grbEdicao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.GroupBox grbEdicao;
        private System.Windows.Forms.Button btnEdicao;
        private System.Windows.Forms.TextBox txtEmailEd;
        private System.Windows.Forms.Label lblEmailEd;
        private System.Windows.Forms.Label lblNomeCompletoEd;
        private System.Windows.Forms.TextBox txtNomeCompletoEd;
        private System.Windows.Forms.TextBox txtNovaSenhaEd;
        private System.Windows.Forms.Label lblNovaSenhaEd;
    }
}