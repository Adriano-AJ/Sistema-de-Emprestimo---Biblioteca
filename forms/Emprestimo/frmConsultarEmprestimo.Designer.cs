namespace Sistema_de_Emprestimo___Biblioteca.forms.Emprestimo
{
    partial class frmConsultarEmprestimo
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
            listEmprestimoAssociado = new ListView();
            Id = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            btnConsultarEmprestimo = new FontAwesome.Sharp.IconButton();
            btnDevolver = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtCPFAssociado = new TextBox();
            btnPagarMulta = new FontAwesome.Sharp.IconButton();
            txtValorMulta = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtIdEmprestimo = new TextBox();
            lblDate = new Label();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            dateSelectConsultar = new DateTimePicker();
            SuspendLayout();
            // 
            // listEmprestimoAssociado
            // 
            listEmprestimoAssociado.Columns.AddRange(new ColumnHeader[] { Id, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader8 });
            listEmprestimoAssociado.Cursor = Cursors.Hand;
            listEmprestimoAssociado.FullRowSelect = true;
            listEmprestimoAssociado.GridLines = true;
            listEmprestimoAssociado.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listEmprestimoAssociado.HoverSelection = true;
            listEmprestimoAssociado.Location = new Point(15, 120);
            listEmprestimoAssociado.Name = "listEmprestimoAssociado";
            listEmprestimoAssociado.Size = new Size(444, 128);
            listEmprestimoAssociado.TabIndex = 19;
            listEmprestimoAssociado.UseCompatibleStateImageBehavior = false;
            listEmprestimoAssociado.View = View.Details;
            listEmprestimoAssociado.SelectedIndexChanged += listEmprestimoAssociado_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CPF";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nome do Associado";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Livro";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Multa";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Data do emprestimo";
            columnHeader5.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Data de Devolução";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 102);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de Emprestimos";
            // 
            // btnConsultarEmprestimo
            // 
            btnConsultarEmprestimo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnConsultarEmprestimo.IconColor = Color.Black;
            btnConsultarEmprestimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultarEmprestimo.Location = new Point(180, 67);
            btnConsultarEmprestimo.Name = "btnConsultarEmprestimo";
            btnConsultarEmprestimo.Size = new Size(150, 23);
            btnConsultarEmprestimo.TabIndex = 2;
            btnConsultarEmprestimo.Text = "Consultar";
            btnConsultarEmprestimo.UseVisualStyleBackColor = true;
            btnConsultarEmprestimo.Click += btnConsultarEmprestimo_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDevolver.IconColor = Color.Black;
            btnDevolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDevolver.Location = new Point(223, 350);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(236, 40);
            btnDevolver.TabIndex = 3;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF DO ASSOCIADO";
            // 
            // txtCPFAssociado
            // 
            txtCPFAssociado.Location = new Point(180, 38);
            txtCPFAssociado.Name = "txtCPFAssociado";
            txtCPFAssociado.Size = new Size(150, 23);
            txtCPFAssociado.TabIndex = 5;
            // 
            // btnPagarMulta
            // 
            btnPagarMulta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPagarMulta.IconColor = Color.Black;
            btnPagarMulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPagarMulta.Location = new Point(223, 304);
            btnPagarMulta.Name = "btnPagarMulta";
            btnPagarMulta.Size = new Size(236, 40);
            btnPagarMulta.TabIndex = 6;
            btnPagarMulta.Text = "Pagar";
            btnPagarMulta.UseVisualStyleBackColor = true;
            btnPagarMulta.Click += btnPagarMulta_Click;
            // 
            // txtValorMulta
            // 
            txtValorMulta.Location = new Point(50, 337);
            txtValorMulta.Name = "txtValorMulta";
            txtValorMulta.Size = new Size(147, 23);
            txtValorMulta.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 317);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 273);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 10;
            label4.Text = "Id";
            // 
            // txtIdEmprestimo
            // 
            txtIdEmprestimo.Location = new Point(50, 291);
            txtIdEmprestimo.Name = "txtIdEmprestimo";
            txtIdEmprestimo.Size = new Size(147, 23);
            txtIdEmprestimo.TabIndex = 9;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(50, 363);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(105, 15);
            lblDate.TabIndex = 20;
            lblDate.Text = "Data de devolução";
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // dateSelectConsultar
            // 
            dateSelectConsultar.Location = new Point(50, 381);
            dateSelectConsultar.Name = "dateSelectConsultar";
            dateSelectConsultar.Size = new Size(147, 23);
            dateSelectConsultar.TabIndex = 21;
            dateSelectConsultar.ValueChanged += dateSelectConsultar_ValueChanged;
            // 
            // frmConsultarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 432);
            Controls.Add(dateSelectConsultar);
            Controls.Add(lblDate);
            Controls.Add(label4);
            Controls.Add(txtIdEmprestimo);
            Controls.Add(label3);
            Controls.Add(txtValorMulta);
            Controls.Add(btnPagarMulta);
            Controls.Add(txtCPFAssociado);
            Controls.Add(label2);
            Controls.Add(btnDevolver);
            Controls.Add(btnConsultarEmprestimo);
            Controls.Add(label1);
            Controls.Add(listEmprestimoAssociado);
            Name = "frmConsultarEmprestimo";
            Text = "frmConsultarEmprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listEmprestimoAssociado;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnConsultarEmprestimo;
        private FontAwesome.Sharp.IconButton btnDevolver;
        private Label label2;
        private TextBox txtCPFAssociado;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private FontAwesome.Sharp.IconButton btnPagarMulta;
        private TextBox txtValorMulta;
        private Label label3;
        private ColumnHeader Id;
        private Label label4;
        private TextBox txtIdEmprestimo;
        private ColumnHeader columnHeader8;
        private Label lblDate;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private DateTimePicker dateSelectConsultar;
    }
}