namespace Sistema_de_Emprestimo___Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            associadosToolStripMenuItem = new ToolStripMenuItem();
            livrosToolStripMenuItem = new ToolStripMenuItem();
            emprestimosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            panelFormPrincipal = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { associadosToolStripMenuItem, livrosToolStripMenuItem, emprestimosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // associadosToolStripMenuItem
            // 
            associadosToolStripMenuItem.Name = "associadosToolStripMenuItem";
            associadosToolStripMenuItem.Size = new Size(78, 20);
            associadosToolStripMenuItem.Text = "Associados";
            associadosToolStripMenuItem.Click += associadosToolStripMenuItem_Click;
            // 
            // livrosToolStripMenuItem
            // 
            livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            livrosToolStripMenuItem.Size = new Size(50, 20);
            livrosToolStripMenuItem.Text = "Livros";
            livrosToolStripMenuItem.Click += livrosToolStripMenuItem_Click;
            // 
            // emprestimosToolStripMenuItem
            // 
            emprestimosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, consultarToolStripMenuItem });
            emprestimosToolStripMenuItem.Name = "emprestimosToolStripMenuItem";
            emprestimosToolStripMenuItem.Size = new Size(88, 20);
            emprestimosToolStripMenuItem.Text = "Emprestimos";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(180, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // panelFormPrincipal
            // 
            panelFormPrincipal.BackColor = Color.FromArgb(128, 64, 0);
            panelFormPrincipal.BackgroundImage = (Image)resources.GetObject("panelFormPrincipal.BackgroundImage");
            panelFormPrincipal.BackgroundImageLayout = ImageLayout.Zoom;
            panelFormPrincipal.Location = new Point(0, 27);
            panelFormPrincipal.Name = "panelFormPrincipal";
            panelFormPrincipal.Size = new Size(800, 454);
            panelFormPrincipal.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 480);
            Controls.Add(panelFormPrincipal);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Biblioteca";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem associadosToolStripMenuItem;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private Panel panelFormPrincipal;
        private ToolStripMenuItem emprestimosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
    }
}
