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
            listView1 = new ListView();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            textBox1 = new TextBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            Id = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, Id });
            listView1.Location = new Point(29, 120);
            listView1.Name = "listView1";
            listView1.Size = new Size(444, 128);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(180, 67);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 23);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Consultar";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(223, 327);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(236, 40);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Devolver";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF DO ASSOCIADO";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 5;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(223, 281);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(236, 40);
            iconButton3.TabIndex = 6;
            iconButton3.Text = "Pagar";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 1;
            columnHeader1.Text = "CPF";
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Nome do Associado";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 3;
            columnHeader3.Text = "Livro";
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 4;
            columnHeader4.Text = "Multa";
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 5;
            columnHeader5.Text = "Data do emprestimo";
            columnHeader5.Width = 120;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 337);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 7;
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
            // textBox3
            // 
            textBox3.Location = new Point(50, 291);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 9;
            // 
            // Id
            // 
            Id.DisplayIndex = 0;
            Id.Text = "Id";
            // 
            // frmConsultarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 407);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(iconButton3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "frmConsultarEmprestimo";
            Text = "frmConsultarEmprestimo";
            Load += frmConsultarEmprestimo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label2;
        private TextBox textBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox textBox2;
        private Label label3;
        private ColumnHeader Id;
        private Label label4;
        private TextBox textBox3;
    }
}