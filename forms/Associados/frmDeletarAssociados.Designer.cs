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
            button1 = new Button();
            btnSalvarLivro = new Button();
            listLivrosCadastrados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(52, 314);
            button1.Name = "button1";
            button1.Size = new Size(193, 43);
            button1.TabIndex = 24;
            button1.Text = "Atualizar ";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvarLivro
            // 
            btnSalvarLivro.Location = new Point(251, 314);
            btnSalvarLivro.Name = "btnSalvarLivro";
            btnSalvarLivro.Size = new Size(205, 43);
            btnSalvarLivro.TabIndex = 23;
            btnSalvarLivro.Text = "Excluir";
            btnSalvarLivro.UseVisualStyleBackColor = true;
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
            listLivrosCadastrados.TabIndex = 22;
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
            // frmDeletarAssociados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 396);
            Controls.Add(button1);
            Controls.Add(btnSalvarLivro);
            Controls.Add(listLivrosCadastrados);
            Name = "frmDeletarAssociados";
            Text = "frmDeletarAssociados";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnSalvarLivro;
        private ListView listLivrosCadastrados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}