namespace Sistema_de_Emprestimo___Biblioteca.forms.Emprestimo
{
    partial class frmNovoEmprestimo
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
            ColumnHeader columnHeader11;
            ColumnHeader columnHeader2;
            label2 = new Label();
            label1 = new Label();
            txtCpfAssociadoEmprestimo = new TextBox();
            btnEfetivarEnprestimo = new Button();
            label3 = new Label();
            txtBuscaLivro = new TextBox();
            label4 = new Label();
            dateSelect = new DateTimePicker();
            listViewConsultaLivro = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            listLivrosSelecionados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "AUTOR";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "AUTOR";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 70);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 8;
            label1.Text = "Cpf do Associado";
            // 
            // txtCpfAssociadoEmprestimo
            // 
            txtCpfAssociadoEmprestimo.Location = new Point(134, 12);
            txtCpfAssociadoEmprestimo.Name = "txtCpfAssociadoEmprestimo";
            txtCpfAssociadoEmprestimo.Size = new Size(100, 23);
            txtCpfAssociadoEmprestimo.TabIndex = 7;
            // 
            // btnEfetivarEnprestimo
            // 
            btnEfetivarEnprestimo.Location = new Point(65, 76);
            btnEfetivarEnprestimo.Name = "btnEfetivarEnprestimo";
            btnEfetivarEnprestimo.Size = new Size(165, 48);
            btnEfetivarEnprestimo.TabIndex = 9;
            btnEfetivarEnprestimo.Text = "Efetivar Emprestimo";
            btnEfetivarEnprestimo.UseVisualStyleBackColor = true;
            btnEfetivarEnprestimo.Click += btnEfetivarEnprestimo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 20);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 13;
            label3.Text = "Buscar Livro";
            // 
            // txtBuscaLivro
            // 
            txtBuscaLivro.Location = new Point(331, 12);
            txtBuscaLivro.Name = "txtBuscaLivro";
            txtBuscaLivro.Size = new Size(155, 23);
            txtBuscaLivro.TabIndex = 14;
            txtBuscaLivro.TextChanged += txtBuscaLivro_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 53);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 16;
            label4.Text = "Data";
            // 
            // dateSelect
            // 
            dateSelect.Location = new Point(65, 47);
            dateSelect.Name = "dateSelect";
            dateSelect.Size = new Size(169, 23);
            dateSelect.TabIndex = 17;
            dateSelect.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // listViewConsultaLivro
            // 
            listViewConsultaLivro.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            listViewConsultaLivro.Cursor = Cursors.Hand;
            listViewConsultaLivro.FullRowSelect = true;
            listViewConsultaLivro.GridLines = true;
            listViewConsultaLivro.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewConsultaLivro.HoverSelection = true;
            listViewConsultaLivro.Location = new Point(254, 41);
            listViewConsultaLivro.Name = "listViewConsultaLivro";
            listViewConsultaLivro.Size = new Size(232, 233);
            listViewConsultaLivro.TabIndex = 19;
            listViewConsultaLivro.UseCompatibleStateImageBehavior = false;
            listViewConsultaLivro.View = View.Details;
            listViewConsultaLivro.DoubleClick += listLivroEmprestimo_DoubleClick;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "TITULO";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "EDITORA";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "ISBN";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            // 
            // listLivrosSelecionados
            // 
            listLivrosSelecionados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listLivrosSelecionados.Cursor = Cursors.Hand;
            listLivrosSelecionados.FullRowSelect = true;
            listLivrosSelecionados.GridLines = true;
            listLivrosSelecionados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listLivrosSelecionados.HoverSelection = true;
            listLivrosSelecionados.Location = new Point(12, 158);
            listLivrosSelecionados.Name = "listLivrosSelecionados";
            listLivrosSelecionados.Size = new Size(236, 116);
            listLivrosSelecionados.TabIndex = 20;
            listLivrosSelecionados.UseCompatibleStateImageBehavior = false;
            listLivrosSelecionados.View = View.Details;
            listLivrosSelecionados.DoubleClick += listCarrinhoLivros_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TITULO";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "EDITORA";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ISBN";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // frmNovoEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 286);
            Controls.Add(listLivrosSelecionados);
            Controls.Add(listViewConsultaLivro);
            Controls.Add(dateSelect);
            Controls.Add(label4);
            Controls.Add(txtBuscaLivro);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtCpfAssociadoEmprestimo);
            Controls.Add(btnEfetivarEnprestimo);
            Controls.Add(label2);
            Name = "frmNovoEmprestimo";
            Text = "frmNovoEmprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox txtCpfAssociadoEmprestimo;
        private Button btnEfetivarEnprestimo;
        private Label label3;
        private TextBox txtBuscaLivro;
        private Label label4;
        private DateTimePicker dateSelect;
        private ListView listViewConsultaLivro;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ListView listLivrosSelecionados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}