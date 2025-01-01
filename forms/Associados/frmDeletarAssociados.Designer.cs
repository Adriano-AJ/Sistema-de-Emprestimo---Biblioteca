namespace Sistema_de_Emprestimo___Biblioteca.forms.Associados
{
    partial class frmDeletarAssociados
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
            btnAtualizarListaAssociado = new Button();
            btnExcluirAssociado = new Button();
            listAssociadosCadastrados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnAtualizarListaAssociado
            // 
            btnAtualizarListaAssociado.Location = new Point(52, 314);
            btnAtualizarListaAssociado.Name = "btnAtualizarListaAssociado";
            btnAtualizarListaAssociado.Size = new Size(193, 43);
            btnAtualizarListaAssociado.TabIndex = 24;
            btnAtualizarListaAssociado.Text = "Atualizar ";
            btnAtualizarListaAssociado.UseVisualStyleBackColor = true;
            btnAtualizarListaAssociado.Click += btnAtualizarListaAssociado_Click;
            // 
            // btnExcluirAssociado
            // 
            btnExcluirAssociado.Location = new Point(251, 314);
            btnExcluirAssociado.Name = "btnExcluirAssociado";
            btnExcluirAssociado.Size = new Size(205, 43);
            btnExcluirAssociado.TabIndex = 23;
            btnExcluirAssociado.Text = "Excluir";
            btnExcluirAssociado.UseVisualStyleBackColor = true;
            btnExcluirAssociado.Click += btnExcluirAssociado_Click;
            // 
            // listAssociadosCadastrados
            // 
            listAssociadosCadastrados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listAssociadosCadastrados.Cursor = Cursors.Hand;
            listAssociadosCadastrados.FullRowSelect = true;
            listAssociadosCadastrados.GridLines = true;
            listAssociadosCadastrados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listAssociadosCadastrados.HoverSelection = true;
            listAssociadosCadastrados.Location = new Point(52, 31);
            listAssociadosCadastrados.Name = "listAssociadosCadastrados";
            listAssociadosCadastrados.Size = new Size(404, 277);
            listAssociadosCadastrados.TabIndex = 22;
            listAssociadosCadastrados.UseCompatibleStateImageBehavior = false;
            listAssociadosCadastrados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOME";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CPF";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // frmDeletarAssociados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 396);
            Controls.Add(btnAtualizarListaAssociado);
            Controls.Add(btnExcluirAssociado);
            Controls.Add(listAssociadosCadastrados);
            Name = "frmDeletarAssociados";
            Text = "frmDeletarAssociados";
            Load += frmDeletarAssociados_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtualizarListaAssociado;
        private Button btnExcluirAssociado;
        private ListView listAssociadosCadastrados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}