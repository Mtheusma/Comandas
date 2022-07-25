namespace Padarosa.Formularios
{
    partial class MenuPrincipal
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
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(114, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MENU - PRINCIPAL:PADAROSA";
            // 
            // btnComandas
            // 
            this.btnComandas.Location = new System.Drawing.Point(39, 148);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(378, 19);
            this.btnComandas.TabIndex = 1;
            this.btnComandas.Text = "COMANDAS";
            this.btnComandas.UseVisualStyleBackColor = true;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(39, 173);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(378, 21);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "PRODUTOS";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnUsuario.Location = new System.Drawing.Point(39, 200);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(378, 20);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "USUARIOS";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.BackColor = System.Drawing.Color.Transparent;
            this.lblPessoa.Font = new System.Drawing.Font("Yu Gothic Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblPessoa.ForeColor = System.Drawing.Color.White;
            this.lblPessoa.Location = new System.Drawing.Point(46, 64);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(288, 21);
            this.lblPessoa.TabIndex = 4;
            this.lblPessoa.Text = "Olá,Senhor(a)Escolha uma opção abaixo";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Padarosa.Properties.Resources.frederico_almeida_mOykUIdBYTo_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 276);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblPessoa;
    }
}