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
            btnBuscarLivroNome = new FontAwesome.Sharp.IconButton();
            txtConsultaNomeLivro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtConsultaIsbnLivro = new TextBox();
            btnBuscarLivroIsbn = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnAtualizarConsultaLivro = new FontAwesome.Sharp.IconButton();
            listViewConsultaLivro = new ListView();
            btnLimparListaLivro = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnBuscarLivroNome.Click += this.btnBuscarLivroNome_Click;
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
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 126);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 9;
            label3.Text = "Busque por filtro:";
            
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 8;
            
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
            // 
            // listViewConsultaLivro
            // 
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
          
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtConsultaIsbnLivro);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnBuscarLivroIsbn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtConsultaNomeLivro);
            panel1.Controls.Add(btnBuscarLivroNome);
            panel1.Location = new Point(50, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 194);
            panel1.TabIndex = 10;
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
        private Label label3;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnAtualizarConsultaLivro;
        private ListView listViewConsultaLivro;
        private FontAwesome.Sharp.IconButton btnLimparListaLivro;
        private Panel panel1;
    }
}