﻿namespace PadariaEMerceariaDaFah.Forms.Estoque
{
    partial class EstoqueInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueInicio));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.go_ingredientes = new System.Windows.Forms.Button();
            this.go_produtos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.item_edicao = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtd_text = new System.Windows.Forms.TextBox();
            this.data_validade = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.linkProdutos = new System.Windows.Forms.LinkLabel();
            this.produtos_label = new System.Windows.Forms.Label();
            this.produto_nome = new System.Windows.Forms.TextBox();
            this.remove_item = new System.Windows.Forms.Button();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.save_edit_item = new System.Windows.Forms.Button();
            this.list_estoque = new System.Windows.Forms.ListBox();
            this.add_item = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.item_edicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.go_ingredientes);
            this.groupBox2.Controls.Add(this.go_produtos);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.add_item);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(647, 360);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estoque";
            // 
            // go_ingredientes
            // 
            this.go_ingredientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("go_ingredientes.BackgroundImage")));
            this.go_ingredientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_ingredientes.Location = new System.Drawing.Point(9, 20);
            this.go_ingredientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.go_ingredientes.Name = "go_ingredientes";
            this.go_ingredientes.Size = new System.Drawing.Size(172, 37);
            this.go_ingredientes.TabIndex = 4;
            this.go_ingredientes.Text = "Visualizar Ingredientes";
            this.go_ingredientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_ingredientes.UseVisualStyleBackColor = true;
            this.go_ingredientes.Click += new System.EventHandler(this.go_ingredientes_Click);
            // 
            // go_produtos
            // 
            this.go_produtos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("go_produtos.BackgroundImage")));
            this.go_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.go_produtos.Location = new System.Drawing.Point(219, 19);
            this.go_produtos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.go_produtos.Name = "go_produtos";
            this.go_produtos.Size = new System.Drawing.Size(148, 37);
            this.go_produtos.TabIndex = 3;
            this.go_produtos.Text = "Visualizar Produtos";
            this.go_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_produtos.UseVisualStyleBackColor = true;
            this.go_produtos.Click += new System.EventHandler(this.go_produtos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.item_edicao);
            this.groupBox1.Controls.Add(this.remove_item);
            this.groupBox1.Controls.Add(this.habilitar_edicao);
            this.groupBox1.Controls.Add(this.save_edit_item);
            this.groupBox1.Controls.Add(this.list_estoque);
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(639, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque Atual";
            // 
            // item_edicao
            // 
            this.item_edicao.BackColor = System.Drawing.Color.White;
            this.item_edicao.Controls.Add(this.label3);
            this.item_edicao.Controls.Add(this.qtd_text);
            this.item_edicao.Controls.Add(this.data_validade);
            this.item_edicao.Controls.Add(this.label2);
            this.item_edicao.Controls.Add(this.linkProdutos);
            this.item_edicao.Controls.Add(this.produtos_label);
            this.item_edicao.Controls.Add(this.produto_nome);
            this.item_edicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_edicao.Location = new System.Drawing.Point(175, 50);
            this.item_edicao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.item_edicao.Name = "item_edicao";
            this.item_edicao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.item_edicao.Size = new System.Drawing.Size(454, 176);
            this.item_edicao.TabIndex = 11;
            this.item_edicao.TabStop = false;
            this.item_edicao.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantidade:";
            // 
            // qtd_text
            // 
            this.qtd_text.Location = new System.Drawing.Point(98, 108);
            this.qtd_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qtd_text.Name = "qtd_text";
            this.qtd_text.Size = new System.Drawing.Size(47, 23);
            this.qtd_text.TabIndex = 26;
            // 
            // data_validade
            // 
            this.data_validade.Location = new System.Drawing.Point(91, 79);
            this.data_validade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_validade.Name = "data_validade";
            this.data_validade.Size = new System.Drawing.Size(274, 23);
            this.data_validade.TabIndex = 25;
            this.data_validade.Value = new System.DateTime(2019, 11, 16, 20, 13, 20, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Validade:";
            // 
            // linkProdutos
            // 
            this.linkProdutos.AutoSize = true;
            this.linkProdutos.Location = new System.Drawing.Point(203, 43);
            this.linkProdutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkProdutos.Name = "linkProdutos";
            this.linkProdutos.Size = new System.Drawing.Size(151, 17);
            this.linkProdutos.TabIndex = 20;
            this.linkProdutos.TabStop = true;
            this.linkProdutos.Text = "Selecione um produto";
            this.linkProdutos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProdutos_LinkClicked);
            // 
            // produtos_label
            // 
            this.produtos_label.AutoSize = true;
            this.produtos_label.Location = new System.Drawing.Point(2, 22);
            this.produtos_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.produtos_label.Name = "produtos_label";
            this.produtos_label.Size = new System.Drawing.Size(64, 17);
            this.produtos_label.TabIndex = 19;
            this.produtos_label.Text = "Produto:";
            // 
            // produto_nome
            // 
            this.produto_nome.Enabled = false;
            this.produto_nome.Location = new System.Drawing.Point(91, 20);
            this.produto_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.produto_nome.Name = "produto_nome";
            this.produto_nome.Size = new System.Drawing.Size(357, 23);
            this.produto_nome.TabIndex = 18;
            // 
            // remove_item
            // 
            this.remove_item.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.shopping_basket_remove_icon;
            this.remove_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remove_item.Location = new System.Drawing.Point(419, 228);
            this.remove_item.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_item.Name = "remove_item";
            this.remove_item.Size = new System.Drawing.Size(186, 50);
            this.remove_item.TabIndex = 8;
            this.remove_item.Text = "Remover Item";
            this.remove_item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_item.UseVisualStyleBackColor = true;
            this.remove_item.Click += new System.EventHandler(this.remove_item_Click);
            // 
            // habilitar_edicao
            // 
            this.habilitar_edicao.AutoSize = true;
            this.habilitar_edicao.Location = new System.Drawing.Point(184, 26);
            this.habilitar_edicao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.habilitar_edicao.Name = "habilitar_edicao";
            this.habilitar_edicao.Size = new System.Drawing.Size(130, 21);
            this.habilitar_edicao.TabIndex = 10;
            this.habilitar_edicao.Text = "Habilitar Edição";
            this.habilitar_edicao.UseVisualStyleBackColor = true;
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.habilitar_edicao_CheckedChanged);
            // 
            // save_edit_item
            // 
            this.save_edit_item.BackgroundImage = global::PadariaEMerceariaDaFah.Properties.Resources.edit_validated_icon;
            this.save_edit_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_edit_item.Location = new System.Drawing.Point(219, 228);
            this.save_edit_item.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save_edit_item.Name = "save_edit_item";
            this.save_edit_item.Size = new System.Drawing.Size(140, 52);
            this.save_edit_item.TabIndex = 7;
            this.save_edit_item.Text = "Salvar Edição";
            this.save_edit_item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_edit_item.UseVisualStyleBackColor = true;
            this.save_edit_item.Click += new System.EventHandler(this.save_edit_item_Click);
            // 
            // list_estoque
            // 
            this.list_estoque.FormattingEnabled = true;
            this.list_estoque.ItemHeight = 17;
            this.list_estoque.Location = new System.Drawing.Point(9, 17);
            this.list_estoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_estoque.Name = "list_estoque";
            this.list_estoque.Size = new System.Drawing.Size(162, 259);
            this.list_estoque.TabIndex = 1;
            this.list_estoque.SelectedValueChanged += new System.EventHandler(this.list_estoque_SelectedValueChanged);
            // 
            // add_item
            // 
            this.add_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_item.BackgroundImage")));
            this.add_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_item.Location = new System.Drawing.Point(381, 19);
            this.add_item.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(254, 37);
            this.add_item.TabIndex = 0;
            this.add_item.Text = "Cadastrar Novo Item no Estoque";
            this.add_item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // EstoqueInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 377);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EstoqueInicio";
            this.Text = "EstoqueInicio";
            this.Load += new System.EventHandler(this.EstoqueInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.item_edicao.ResumeLayout(false);
            this.item_edicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button remove_item;
        private System.Windows.Forms.CheckBox habilitar_edicao;
        private System.Windows.Forms.Button save_edit_item;
        private System.Windows.Forms.ListBox list_estoque;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button go_produtos;
        private System.Windows.Forms.GroupBox item_edicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtd_text;
        private System.Windows.Forms.DateTimePicker data_validade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkProdutos;
        private System.Windows.Forms.Label produtos_label;
        private System.Windows.Forms.TextBox produto_nome;
        private System.Windows.Forms.Button go_ingredientes;
    }
}