namespace Sistema_de_Emprestimo___Biblioteca
{
    partial class frmCadastraLivro
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
            panel1 = new Panel();
            txtIsbnLivro = new TextBox();
            label4 = new Label();
            txtNomeEditoraLivro = new TextBox();
            txtTituloLivro = new TextBox();
            label1 = new Label();
            txtNomeAutorLivro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listLivrosCadastrados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnAdicionarNovoLivro = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtIsbnLivro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNomeEditoraLivro);
            panel1.Controls.Add(txtTituloLivro);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNomeAutorLivro);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(50, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 194);
            panel1.TabIndex = 19;
            // 
            // txtIsbnLivro
            // 
            txtIsbnLivro.Location = new Point(107, 151);
            txtIsbnLivro.Name = "txtIsbnLivro";
            txtIsbnLivro.Size = new Size(223, 23);
            txtIsbnLivro.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 154);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 26;
            label4.Text = "Isbn";
            // 
            // txtNomeEditoraLivro
            // 
            txtNomeEditoraLivro.Location = new Point(107, 107);
            txtNomeEditoraLivro.Name = "txtNomeEditoraLivro";
            txtNomeEditoraLivro.Size = new Size(223, 23);
            txtNomeEditoraLivro.TabIndex = 25;
            // 
            // txtTituloLivro
            // 
            txtTituloLivro.Location = new Point(107, 18);
            txtTituloLivro.Name = "txtTituloLivro";
            txtTituloLivro.Size = new Size(223, 23);
            txtTituloLivro.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 21);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 15;
            label1.Text = "Titulo";
            // 
            // txtNomeAutorLivro
            // 
            txtNomeAutorLivro.Location = new Point(107, 62);
            txtNomeAutorLivro.Name = "txtNomeAutorLivro";
            txtNomeAutorLivro.Size = new Size(223, 23);
            txtNomeAutorLivro.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 65);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 17;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 110);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 18;
            label3.Text = "Editora";
            // 
            // listLivrosCadastrados
            // 
            listLivrosCadastrados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listLivrosCadastrados.Cursor = Cursors.Hand;
            listLivrosCadastrados.FullRowSelect = true;
            listLivrosCadastrados.GridLines = true;
            listLivrosCadastrados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listLivrosCadastrados.HoverSelection = true;
            listLivrosCadastrados.Location = new Point(50, 276);
            listLivrosCadastrados.Name = "listLivrosCadastrados";
            listLivrosCadastrados.Size = new Size(404, 97);
            listLivrosCadastrados.TabIndex = 18;
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
            // btnAdicionarNovoLivro
            // 
            btnAdicionarNovoLivro.BackColor = Color.Black;
            btnAdicionarNovoLivro.FlatStyle = FlatStyle.Flat;
            btnAdicionarNovoLivro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionarNovoLivro.ForeColor = Color.White;
            btnAdicionarNovoLivro.Location = new Point(50, 227);
            btnAdicionarNovoLivro.Name = "btnAdicionarNovoLivro";
            btnAdicionarNovoLivro.Size = new Size(404, 43);
            btnAdicionarNovoLivro.TabIndex = 17;
            btnAdicionarNovoLivro.Text = "ADICIONAR";
            btnAdicionarNovoLivro.UseVisualStyleBackColor = false;
            btnAdicionarNovoLivro.Click += btnSalvarLivro_Click;
            // 
            // frmCadastraLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 396);
            Controls.Add(panel1);
            Controls.Add(listLivrosCadastrados);
            Controls.Add(btnAdicionarNovoLivro);
            Name = "frmCadastraLivro";
            Text = "frmCadastraLivro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTituloLivro;
        private Label label1;
        private TextBox txtNomeAutorLivro;
        private Label label2;
        private Label label3;
        private ListView listLivrosCadastrados;
        private Button btnAdicionarNovoLivro;
        private TextBox txtNomeEditoraLivro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtIsbnLivro;
        private Label label4;
    }
}