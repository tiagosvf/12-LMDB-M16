namespace LMDB
{
    partial class fr_consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_consultas));
            this.dgv_consultas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesDesteAnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nºDeParticipaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesDesteAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_consultas
            // 
            this.dgv_consultas.AllowUserToAddRows = false;
            this.dgv_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultas.Location = new System.Drawing.Point(0, 24);
            this.dgv_consultas.Name = "dgv_consultas";
            this.dgv_consultas.Size = new System.Drawing.Size(284, 238);
            this.dgv_consultas.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atoresToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.realiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atoresToolStripMenuItem
            // 
            this.atoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmesDesteAnoToolStripMenuItem1});
            this.atoresToolStripMenuItem.Name = "atoresToolStripMenuItem";
            this.atoresToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.atoresToolStripMenuItem.Text = "Filmes";
            // 
            // filmesDesteAnoToolStripMenuItem1
            // 
            this.filmesDesteAnoToolStripMenuItem1.Name = "filmesDesteAnoToolStripMenuItem1";
            this.filmesDesteAnoToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.filmesDesteAnoToolStripMenuItem1.Text = "Filmes deste ano";
            this.filmesDesteAnoToolStripMenuItem1.Click += new System.EventHandler(this.filmesDesteAnoToolStripMenuItem1_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.filmesToolStripMenuItem.Text = "Realizadores";
            // 
            // realiToolStripMenuItem
            // 
            this.realiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nºDeParticipaçõesToolStripMenuItem,
            this.filmesDesteAnoToolStripMenuItem});
            this.realiToolStripMenuItem.Name = "realiToolStripMenuItem";
            this.realiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.realiToolStripMenuItem.Text = "Atores";
            // 
            // nºDeParticipaçõesToolStripMenuItem
            // 
            this.nºDeParticipaçõesToolStripMenuItem.Name = "nºDeParticipaçõesToolStripMenuItem";
            this.nºDeParticipaçõesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nºDeParticipaçõesToolStripMenuItem.Text = "Nº de Participações";
            this.nºDeParticipaçõesToolStripMenuItem.Click += new System.EventHandler(this.nºDeParticipaçõesToolStripMenuItem_Click);
            // 
            // filmesDesteAnoToolStripMenuItem
            // 
            this.filmesDesteAnoToolStripMenuItem.Name = "filmesDesteAnoToolStripMenuItem";
            this.filmesDesteAnoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.filmesDesteAnoToolStripMenuItem.Text = "Filmes deste ano";
            this.filmesDesteAnoToolStripMenuItem.Click += new System.EventHandler(this.filmesDesteAnoToolStripMenuItem_Click);
            // 
            // fr_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgv_consultas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_consultas";
            this.Text = "[Consultas] LMDb - Local Movie Database";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consultas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesDesteAnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nºDeParticipaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesDesteAnoToolStripMenuItem;
    }
}