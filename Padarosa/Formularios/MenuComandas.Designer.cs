namespace Padarosa.Formularios
{
    partial class MenuComandas
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
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblComanda = new System.Windows.Forms.Label();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProduro2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(251, 3);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.ReadOnly = true;
            this.dgvComandas.Size = new System.Drawing.Size(273, 379);
            this.dgvComandas.TabIndex = 5;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(3, 47);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(80, 15);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "COMANDA:";
            // 
            // txtComanda
            // 
            this.txtComanda.Location = new System.Drawing.Point(110, 47);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(100, 20);
            this.txtComanda.TabIndex = 1;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(110, 113);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(3, 118);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(77, 15);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.White;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(0, 151);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(222, 23);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txtComanda);
            this.grbInformacoes.Controls.Add(this.lblProduto);
            this.grbInformacoes.Controls.Add(this.txtProduto);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 3);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(222, 180);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "INFORMAÇÕES";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.lblQuantidade);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.textBox1);
            this.grbLancamento.Controls.Add(this.lblProduro2);
            this.grbLancamento.Controls.Add(this.textBox2);
            this.grbLancamento.Location = new System.Drawing.Point(12, 202);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(231, 180);
            this.grbLancamento.TabIndex = 7;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "LANÇAMENTO";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(3, 59);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(101, 15);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "QUANTIDADE:";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.White;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(0, 151);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(231, 23);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblProduro2
            // 
            this.lblProduro2.AutoSize = true;
            this.lblProduro2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduro2.Location = new System.Drawing.Point(6, 122);
            this.lblProduro2.Name = "lblProduro2";
            this.lblProduro2.Size = new System.Drawing.Size(77, 15);
            this.lblProduro2.TabIndex = 3;
            this.lblProduro2.Text = "PRODUTO:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // MenuComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 385);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvComandas);
            this.Name = "MenuComandas";
            this.Text = "MenuComandas";
            this.Load += new System.EventHandler(this.MenuComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProduro2;
        private System.Windows.Forms.TextBox textBox2;
    }
}