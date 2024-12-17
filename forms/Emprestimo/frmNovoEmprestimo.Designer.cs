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
            label2 = new Label();
            label1 = new Label();
            txtCpfAssociadoEmprestimo = new TextBox();
            button1 = new Button();
            listLivroEmprestimo = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label3 = new Label();
            txtBuscaLivro = new TextBox();
            label4 = new Label();
            dateSelect = new DateTimePicker();
            SuspendLayout();
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
            // button1
            // 
            button1.Location = new Point(54, 88);
            button1.Name = "button1";
            button1.Size = new Size(165, 48);
            button1.TabIndex = 9;
            button1.Text = "Efetivar Emprestimo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listLivroEmprestimo
            // 
            listLivroEmprestimo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listLivroEmprestimo.Location = new Point(254, 41);
            listLivroEmprestimo.Name = "listLivroEmprestimo";
            listLivroEmprestimo.Size = new Size(232, 233);
            listLivroEmprestimo.TabIndex = 12;
            listLivroEmprestimo.UseCompatibleStateImageBehavior = false;
            listLivroEmprestimo.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Isbn";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Autor";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Editora";
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
            // frmNovoEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 286);
            Controls.Add(dateSelect);
            Controls.Add(label4);
            Controls.Add(txtBuscaLivro);
            Controls.Add(label3);
            Controls.Add(listLivroEmprestimo);
            Controls.Add(label1);
            Controls.Add(txtCpfAssociadoEmprestimo);
            Controls.Add(button1);
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
        private Button button1;
        private ListView listLivroEmprestimo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label3;
        private TextBox txtBuscaLivro;
        private Label label4;
        private DateTimePicker dateSelect;
    }
}