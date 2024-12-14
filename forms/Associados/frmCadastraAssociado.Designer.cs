namespace Sistema_de_Emprestimo___Biblioteca
{
    partial class frmCadastraAssociado
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
            btnAdicionarNovoAssociado = new Button();
            listAssociadosNovos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel1 = new Panel();
            label7 = new Label();
            txtNomeAssociado = new TextBox();
            txtLogradouroAssociado = new TextBox();
            txtPaisAssociado = new TextBox();
            label1 = new Label();
            label6 = new Label();
            txtCpfAssociado = new TextBox();
            label5 = new Label();
            cmbSexoAssociado = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEstadoAssociado = new TextBox();
            txtCidadeAssociado = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicionarNovoAssociado
            // 
            btnAdicionarNovoAssociado.BackColor = Color.Black;
            btnAdicionarNovoAssociado.FlatStyle = FlatStyle.Flat;
            btnAdicionarNovoAssociado.ForeColor = Color.White;
            btnAdicionarNovoAssociado.Location = new Point(24, 224);
            btnAdicionarNovoAssociado.Name = "btnAdicionarNovoAssociado";
            btnAdicionarNovoAssociado.Size = new Size(459, 48);
            btnAdicionarNovoAssociado.TabIndex = 3;
            btnAdicionarNovoAssociado.Text = "Adicionar";
            btnAdicionarNovoAssociado.UseVisualStyleBackColor = false;
            btnAdicionarNovoAssociado.Click += btnAdicionarNovoAssociado_Click;
            // 
            // listAssociadosNovos
            // 
            listAssociadosNovos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listAssociadosNovos.Location = new Point(24, 278);
            listAssociadosNovos.Name = "listAssociadosNovos";
            listAssociadosNovos.Size = new Size(459, 97);
            listAssociadosNovos.TabIndex = 15;
            listAssociadosNovos.UseCompatibleStateImageBehavior = false;
            listAssociadosNovos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOME";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CPF";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "SEXO";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "LOGRADOURO";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "CIDADE";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ESTADO";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "PAÍS";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtCidadeAssociado);
            panel1.Controls.Add(txtEstadoAssociado);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtNomeAssociado);
            panel1.Controls.Add(txtLogradouroAssociado);
            panel1.Controls.Add(txtPaisAssociado);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCpfAssociado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbSexoAssociado);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(24, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 206);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(257, 104);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 27;
            label7.Text = "Cidade";
            // 
            // txtNomeAssociado
            // 
            txtNomeAssociado.Location = new Point(34, 28);
            txtNomeAssociado.Name = "txtNomeAssociado";
            txtNomeAssociado.Size = new Size(166, 23);
            txtNomeAssociado.TabIndex = 14;
            // 
            // txtLogradouroAssociado
            // 
            txtLogradouroAssociado.Location = new Point(257, 28);
            txtLogradouroAssociado.Name = "txtLogradouroAssociado";
            txtLogradouroAssociado.Size = new Size(166, 23);
            txtLogradouroAssociado.TabIndex = 23;
            // 
            // txtPaisAssociado
            // 
            txtPaisAssociado.Location = new Point(257, 171);
            txtPaisAssociado.Name = "txtPaisAssociado";
            txtPaisAssociado.Size = new Size(166, 23);
            txtPaisAssociado.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 10);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Nome";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 153);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 21;
            label6.Text = "País";
            // 
            // txtCpfAssociado
            // 
            txtCpfAssociado.Location = new Point(34, 78);
            txtCpfAssociado.Name = "txtCpfAssociado";
            txtCpfAssociado.Size = new Size(166, 23);
            txtCpfAssociado.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 60);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 20;
            label5.Text = "Estado";
            // 
            // cmbSexoAssociado
            // 
            cmbSexoAssociado.FormattingEnabled = true;
            cmbSexoAssociado.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbSexoAssociado.Location = new Point(34, 136);
            cmbSexoAssociado.Name = "cmbSexoAssociado";
            cmbSexoAssociado.Size = new Size(166, 23);
            cmbSexoAssociado.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 10);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 19;
            label4.Text = "Logradouro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 60);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 17;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 118);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 18;
            label3.Text = "Sexo";
            // 
            // txtEstadoAssociado
            // 
            txtEstadoAssociado.Location = new Point(257, 78);
            txtEstadoAssociado.Name = "txtEstadoAssociado";
            txtEstadoAssociado.Size = new Size(166, 23);
            txtEstadoAssociado.TabIndex = 28;
            // 
            // txtCidadeAssociado
            // 
            txtCidadeAssociado.Location = new Point(257, 127);
            txtCidadeAssociado.Name = "txtCidadeAssociado";
            txtCidadeAssociado.Size = new Size(166, 23);
            txtCidadeAssociado.TabIndex = 29;
            // 
            // frmCadastraAssociado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(508, 396);
            Controls.Add(panel1);
            Controls.Add(listAssociadosNovos);
            Controls.Add(btnAdicionarNovoAssociado);
            Name = "frmCadastraAssociado";
            Text = "frmCadastraAssociado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdicionarNovoAssociado;
        private ListView listAssociadosNovos;
        private Panel panel1;
        private TextBox txtNomeAssociado;
        private TextBox txtLogradouroAssociado;
        private TextBox txtPaisAssociado;
        private Label label1;
        private Label label6;
        private TextBox txtCpfAssociado;
        private Label label5;
        private ComboBox cmbSexoAssociado;
        private Label label4;
        private Label label2;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label7;
        private ColumnHeader columnHeader8;
        private TextBox txtCidadeAssociado;
        private TextBox txtEstadoAssociado;
    }
}