namespace Sistema_de_Emprestimo___Biblioteca
{
    partial class frmConsultaLivro
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
            ColumnHeader columnHeader3;
            btnBuscarLivroNome = new FontAwesome.Sharp.IconButton();
            txtConsultaNomeLivro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtConsultaIsbnLivro = new TextBox();
            btnBuscarLivroIsbn = new FontAwesome.Sharp.IconButton();
            btnAtualizarConsultaLivro = new FontAwesome.Sharp.IconButton();
            listViewConsultaLivro = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnLimparListaLivro = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            columnHeader6 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "AUTOR";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscarLivroNome
            // 
            btnBuscarLivroNome.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarLivroNome.IconColor = Color.Black;
            btnBuscarLivroNome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarLivroNome.Location = new Point(287, 39);
            btnBuscarLivroNome.Name = "btnBuscarLivroNome";
            btnBuscarLivroNome.Size = new Size(75, 23);
            btnBuscarLivroNome.TabIndex = 1;
            btnBuscarLivroNome.Text = "Buscar";
            btnBuscarLivroNome.UseVisualStyleBackColor = true;
            btnBuscarLivroNome.Click += btnBuscarLivroNome_Click;
            // 
            // txtConsultaNomeLivro
            // 
            txtConsultaNomeLivro.Location = new Point(26, 39);
            txtConsultaNomeLivro.Name = "txtConsultaNomeLivro";
            txtConsultaNomeLivro.Size = new Size(255, 23);
            txtConsultaNomeLivro.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome do livro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Isbn do livro";
            // 
            // txtConsultaIsbnLivro
            // 
            txtConsultaIsbnLivro.Location = new Point(26, 83);
            txtConsultaIsbnLivro.Name = "txtConsultaIsbnLivro";
            txtConsultaIsbnLivro.Size = new Size(255, 23);
            txtConsultaIsbnLivro.TabIndex = 5;
            // 
            // btnBuscarLivroIsbn
            // 
            btnBuscarLivroIsbn.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarLivroIsbn.IconColor = Color.Black;
            btnBuscarLivroIsbn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarLivroIsbn.Location = new Point(287, 83);
            btnBuscarLivroIsbn.Name = "btnBuscarLivroIsbn";
            btnBuscarLivroIsbn.Size = new Size(75, 23);
            btnBuscarLivroIsbn.TabIndex = 4;
            btnBuscarLivroIsbn.Text = "Buscar";
            btnBuscarLivroIsbn.UseVisualStyleBackColor = true;
            btnBuscarLivroIsbn.Click += btnBuscarLivroIsbn_Click;
            // 
            // btnAtualizarConsultaLivro
            // 
            btnAtualizarConsultaLivro.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAtualizarConsultaLivro.IconColor = Color.Black;
            btnAtualizarConsultaLivro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAtualizarConsultaLivro.Location = new Point(50, 327);
            btnAtualizarConsultaLivro.Name = "btnAtualizarConsultaLivro";
            btnAtualizarConsultaLivro.Size = new Size(203, 37);
            btnAtualizarConsultaLivro.TabIndex = 10;
            btnAtualizarConsultaLivro.Text = "Atualizar";
            btnAtualizarConsultaLivro.UseVisualStyleBackColor = true;
            btnAtualizarConsultaLivro.Click += btnAtualizarConsultaLivro_Click;
            // 
            // listViewConsultaLivro
            // 
            listViewConsultaLivro.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewConsultaLivro.Cursor = Cursors.Hand;
            listViewConsultaLivro.FullRowSelect = true;
            listViewConsultaLivro.GridLines = true;
            listViewConsultaLivro.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewConsultaLivro.HoverSelection = true;
            listViewConsultaLivro.Location = new Point(50, 227);
            listViewConsultaLivro.Name = "listViewConsultaLivro";
            listViewConsultaLivro.Size = new Size(404, 94);
            listViewConsultaLivro.TabIndex = 11;
            listViewConsultaLivro.UseCompatibleStateImageBehavior = false;
            listViewConsultaLivro.View = View.Details;
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
            columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "EDITORA";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ISBN";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLimparListaLivro
            // 
            btnLimparListaLivro.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLimparListaLivro.IconColor = Color.Black;
            btnLimparListaLivro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimparListaLivro.Location = new Point(275, 327);
            btnLimparListaLivro.Name = "btnLimparListaLivro";
            btnLimparListaLivro.Size = new Size(179, 37);
            btnLimparListaLivro.TabIndex = 12;
            btnLimparListaLivro.Text = "Limpar Lista";
            btnLimparListaLivro.UseVisualStyleBackColor = true;
            btnLimparListaLivro.Click += btnLimparListaLivro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtConsultaIsbnLivro);
            panel1.Controls.Add(btnBuscarLivroIsbn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtConsultaNomeLivro);
            panel1.Controls.Add(btnBuscarLivroNome);
            panel1.Location = new Point(50, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 194);
            panel1.TabIndex = 10;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            // 
            // frmConsultaLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 396);
            Controls.Add(panel1);
            Controls.Add(btnLimparListaLivro);
            Controls.Add(listViewConsultaLivro);
            Controls.Add(btnAtualizarConsultaLivro);
            Name = "frmConsultaLivro";
            Text = "frmConsultaLivro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBuscarLivroNome;
        private TextBox txtConsultaNomeLivro;
        private Label label1;
        private Label label2;
        private TextBox txtConsultaIsbnLivro;
        private FontAwesome.Sharp.IconButton btnBuscarLivroIsbn;
        private FontAwesome.Sharp.IconButton btnAtualizarConsultaLivro;
        private ListView listViewConsultaLivro;
        private FontAwesome.Sharp.IconButton btnLimparListaLivro;
        private Panel panel1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}