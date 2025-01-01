namespace Sistema_de_Emprestimo___Biblioteca
{
    partial class frmDeletaLivro
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
            listLivrosCadastrados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnExcluirLivro = new Button();
            btnAtualizarLista = new Button();
            SuspendLayout();
            // 
            // listLivrosCadastrados
            // 
            listLivrosCadastrados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listLivrosCadastrados.Cursor = Cursors.Hand;
            listLivrosCadastrados.FullRowSelect = true;
            listLivrosCadastrados.GridLines = true;
            listLivrosCadastrados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listLivrosCadastrados.HoverSelection = true;
            listLivrosCadastrados.Location = new Point(52, 31);
            listLivrosCadastrados.Name = "listLivrosCadastrados";
            listLivrosCadastrados.Size = new Size(404, 277);
            listLivrosCadastrados.TabIndex = 19;
            listLivrosCadastrados.UseCompatibleStateImageBehavior = false;
            listLivrosCadastrados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TITULO";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "AUTOR";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "EDITORA";
            // 
            // btnExcluirLivro
            // 
            btnExcluirLivro.Location = new Point(251, 314);
            btnExcluirLivro.Name = "btnExcluirLivro";
            btnExcluirLivro.Size = new Size(205, 43);
            btnExcluirLivro.TabIndex = 20;
            btnExcluirLivro.Text = "Excluir";
            btnExcluirLivro.UseVisualStyleBackColor = true;
            btnExcluirLivro.Click += btnExcluirLivro_Click;
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.Location = new Point(52, 314);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(193, 43);
            btnAtualizarLista.TabIndex = 21;
            btnAtualizarLista.Text = "Atualizar ";
            btnAtualizarLista.UseVisualStyleBackColor = true;
            btnAtualizarLista.Click += btnAtualizarLista_Click;
            // 
            // frmDeletaLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 396);
            Controls.Add(btnAtualizarLista);
            Controls.Add(btnExcluirLivro);
            Controls.Add(listLivrosCadastrados);
            Name = "frmDeletaLivro";
            Text = "frmDeletaLivro";
            ResumeLayout(false);
        }

        #endregion

        private ListView listLivrosCadastrados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnExcluirLivro;
        private Button btnAtualizarLista;
    }
}