namespace Sistema_de_Emprestimo___Biblioteca.forms.Associados
{
    partial class frmConsultaAssociado
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
            label1 = new Label();
            txtConsultaCpfAssociado = new TextBox();
            btnBuscarAssociadoCpf = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtConsultaNomeAssociado = new TextBox();
            btnBuscarAssociadoNome = new FontAwesome.Sharp.IconButton();
            btnLimparListaAssociado = new FontAwesome.Sharp.IconButton();
            listViewConsultaAssociado = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnAtualizarConsultaAssociado = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtConsultaCpfAssociado);
            panel1.Controls.Add(btnBuscarAssociadoCpf);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtConsultaNomeAssociado);
            panel1.Controls.Add(btnBuscarAssociadoNome);
            panel1.Location = new Point(52, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 194);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome do Associado";
            // 
            // txtConsultaCpfAssociado
            // 
            txtConsultaCpfAssociado.Location = new Point(26, 83);
            txtConsultaCpfAssociado.Name = "txtConsultaCpfAssociado";
            txtConsultaCpfAssociado.Size = new Size(255, 23);
            txtConsultaCpfAssociado.TabIndex = 5;
            // 
            // btnBuscarAssociadoCpf
            // 
            btnBuscarAssociadoCpf.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarAssociadoCpf.IconColor = Color.Black;
            btnBuscarAssociadoCpf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarAssociadoCpf.Location = new Point(287, 83);
            btnBuscarAssociadoCpf.Name = "btnBuscarAssociadoCpf";
            btnBuscarAssociadoCpf.Size = new Size(75, 23);
            btnBuscarAssociadoCpf.TabIndex = 4;
            btnBuscarAssociadoCpf.Text = "Buscar";
            btnBuscarAssociadoCpf.UseVisualStyleBackColor = true;
            btnBuscarAssociadoCpf.Click += btnBuscarAssociadoCpf_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 6;
            label2.Text = "Cpf";
            // 
            // txtConsultaNomeAssociado
            // 
            txtConsultaNomeAssociado.Location = new Point(26, 39);
            txtConsultaNomeAssociado.Name = "txtConsultaNomeAssociado";
            txtConsultaNomeAssociado.Size = new Size(255, 23);
            txtConsultaNomeAssociado.TabIndex = 2;
            // 
            // btnBuscarAssociadoNome
            // 
            btnBuscarAssociadoNome.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarAssociadoNome.IconColor = Color.Black;
            btnBuscarAssociadoNome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarAssociadoNome.Location = new Point(287, 39);
            btnBuscarAssociadoNome.Name = "btnBuscarAssociadoNome";
            btnBuscarAssociadoNome.Size = new Size(75, 23);
            btnBuscarAssociadoNome.TabIndex = 1;
            btnBuscarAssociadoNome.Text = "Buscar";
            btnBuscarAssociadoNome.UseVisualStyleBackColor = true;
            btnBuscarAssociadoNome.Click += btnBuscarAssociadoNome_Click;
            // 
            // btnLimparListaAssociado
            // 
            btnLimparListaAssociado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLimparListaAssociado.IconColor = Color.Black;
            btnLimparListaAssociado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimparListaAssociado.Location = new Point(277, 330);
            btnLimparListaAssociado.Name = "btnLimparListaAssociado";
            btnLimparListaAssociado.Size = new Size(179, 37);
            btnLimparListaAssociado.TabIndex = 16;
            btnLimparListaAssociado.Text = "Limpar Lista";
            btnLimparListaAssociado.UseVisualStyleBackColor = true;
            btnLimparListaAssociado.Click += btnLimparListaAssociado_Click;
            // 
            // listViewConsultaAssociado
            // 
            listViewConsultaAssociado.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewConsultaAssociado.Cursor = Cursors.Hand;
            listViewConsultaAssociado.FullRowSelect = true;
            listViewConsultaAssociado.GridLines = true;
            listViewConsultaAssociado.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewConsultaAssociado.HoverSelection = true;
            listViewConsultaAssociado.Location = new Point(52, 230);
            listViewConsultaAssociado.Name = "listViewConsultaAssociado";
            listViewConsultaAssociado.Size = new Size(404, 94);
            listViewConsultaAssociado.TabIndex = 15;
            listViewConsultaAssociado.UseCompatibleStateImageBehavior = false;
            listViewConsultaAssociado.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nome";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CPF";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // btnAtualizarConsultaAssociado
            // 
            btnAtualizarConsultaAssociado.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAtualizarConsultaAssociado.IconColor = Color.Black;
            btnAtualizarConsultaAssociado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAtualizarConsultaAssociado.Location = new Point(52, 330);
            btnAtualizarConsultaAssociado.Name = "btnAtualizarConsultaAssociado";
            btnAtualizarConsultaAssociado.Size = new Size(203, 37);
            btnAtualizarConsultaAssociado.TabIndex = 14;
            btnAtualizarConsultaAssociado.Text = "Atualizar";
            btnAtualizarConsultaAssociado.UseVisualStyleBackColor = true;
            // 
            // frmConsultaAssociado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 396);
            Controls.Add(panel1);
            Controls.Add(btnLimparListaAssociado);
            Controls.Add(listViewConsultaAssociado);
            Controls.Add(btnAtualizarConsultaAssociado);
            Name = "frmConsultaAssociado";
            Text = "frmConsultaAssociado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtConsultaCpfAssociado;
        private FontAwesome.Sharp.IconButton btnBuscarAssociadoCpf;
        private Label label2;
        private TextBox txtConsultaNomeAssociado;
        private FontAwesome.Sharp.IconButton btnBuscarAssociadoNome;
        private FontAwesome.Sharp.IconButton btnLimparListaAssociado;
        private ListView listViewConsultaAssociado;
        private FontAwesome.Sharp.IconButton btnAtualizarConsultaAssociado;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}