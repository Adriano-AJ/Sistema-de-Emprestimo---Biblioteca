namespace Sistema_de_Emprestimo___Biblioteca
{
    partial class frmPageLivro
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
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnConsultaLivro = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(229, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 395);
            panel1.TabIndex = 5;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Black;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseOverBackColor = Color.Silver;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 36;
            iconButton4.Location = new Point(28, 246);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(166, 48);
            iconButton4.TabIndex = 20;
            iconButton4.Text = "Deletar";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Black;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseOverBackColor = Color.Silver;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 36;
            iconButton3.Location = new Point(28, 192);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(166, 48);
            iconButton3.TabIndex = 19;
            iconButton3.Text = "Cadastrar";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Black;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.Silver;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 36;
            iconButton2.Location = new Point(28, 369);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(166, 48);
            iconButton2.TabIndex = 18;
            iconButton2.Text = "Sair";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // btnConsultaLivro
            // 
            btnConsultaLivro.BackColor = Color.Black;
            btnConsultaLivro.FlatAppearance.BorderColor = Color.Black;
            btnConsultaLivro.FlatAppearance.BorderSize = 0;
            btnConsultaLivro.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnConsultaLivro.FlatStyle = FlatStyle.Flat;
            btnConsultaLivro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConsultaLivro.ForeColor = Color.White;
            btnConsultaLivro.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnConsultaLivro.IconColor = Color.White;
            btnConsultaLivro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaLivro.IconSize = 36;
            btnConsultaLivro.Location = new Point(28, 138);
            btnConsultaLivro.Name = "btnConsultaLivro";
            btnConsultaLivro.Size = new Size(166, 48);
            btnConsultaLivro.TabIndex = 17;
            btnConsultaLivro.Text = "Consultar";
            btnConsultaLivro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaLivro.UseVisualStyleBackColor = false;
            btnConsultaLivro.Click += iconButton1_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 89;
            iconPictureBox1.Location = new Point(70, 43);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(92, 89);
            iconPictureBox1.TabIndex = 21;
            iconPictureBox1.TabStop = false;
            // 
            // frmPageLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 431);
            Controls.Add(iconPictureBox1);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(btnConsultaLivro);
            Controls.Add(panel1);
            Name = "frmPageLivro";
            Text = "frmPageLivro";
            Load += frmPageLivro_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnConsultaLivro;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}