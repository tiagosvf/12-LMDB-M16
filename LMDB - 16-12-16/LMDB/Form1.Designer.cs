namespace LMDB
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_realizador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome_a1 = new System.Windows.Forms.Label();
            this.lbl_nome_a2 = new System.Windows.Forms.Label();
            this.lbl_nome_a3 = new System.Windows.Forms.Label();
            this.lbl_nome_a4 = new System.Windows.Forms.Label();
            this.lbl_nome_p1 = new System.Windows.Forms.Label();
            this.lbl_nome_p2 = new System.Windows.Forms.Label();
            this.lbl_nome_p3 = new System.Windows.Forms.Label();
            this.lbl_nome_p4 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dgv_filmes = new System.Windows.Forms.DataGridView();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_capa = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.cb_realizador = new System.Windows.Forms.ComboBox();
            this.lbl_caminho = new System.Windows.Forms.Label();
            this.txt_ano = new System.Windows.Forms.MaskedTextBox();
            this.cb_atores = new System.Windows.Forms.ComboBox();
            this.txt_nome_personagem = new System.Windows.Forms.TextBox();
            this.lbl_filmes = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.ptb_filme6 = new System.Windows.Forms.PictureBox();
            this.ptb_filme5 = new System.Windows.Forms.PictureBox();
            this.ptb_filme3 = new System.Windows.Forms.PictureBox();
            this.ptb_filme2 = new System.Windows.Forms.PictureBox();
            this.ptb_filme4 = new System.Windows.Forms.PictureBox();
            this.ptb_filme1 = new System.Windows.Forms.PictureBox();
            this.btn_add_ator = new System.Windows.Forms.Button();
            this.btn_del_a4 = new System.Windows.Forms.Button();
            this.btn_del_a3 = new System.Windows.Forms.Button();
            this.btn_del_a2 = new System.Windows.Forms.Button();
            this.btn_del_a1 = new System.Windows.Forms.Button();
            this.ptb_ator_4 = new System.Windows.Forms.PictureBox();
            this.ptb_ator_3 = new System.Windows.Forms.PictureBox();
            this.ptb_ator_2 = new System.Windows.Forms.PictureBox();
            this.ptb_ator_1 = new System.Windows.Forms.PictureBox();
            this.ptb_capa = new System.Windows.Forms.PictureBox();
            this.lbl_erros = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmesToolStripMenuItem,
            this.realizadoresToolStripMenuItem,
            this.atoresToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // realizadoresToolStripMenuItem
            // 
            this.realizadoresToolStripMenuItem.Name = "realizadoresToolStripMenuItem";
            this.realizadoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.realizadoresToolStripMenuItem.Text = "Realizadores";
            this.realizadoresToolStripMenuItem.Click += new System.EventHandler(this.realizadoresToolStripMenuItem_Click);
            // 
            // atoresToolStripMenuItem
            // 
            this.atoresToolStripMenuItem.Name = "atoresToolStripMenuItem";
            this.atoresToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.atoresToolStripMenuItem.Text = "Atores";
            this.atoresToolStripMenuItem.Click += new System.EventHandler(this.atoresToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 54);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.Location = new System.Drawing.Point(204, 131);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(202, 219);
            this.lbl_descricao.TabIndex = 3;
            this.lbl_descricao.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Realizado por:";
            // 
            // lbl_realizador
            // 
            this.lbl_realizador.AutoSize = true;
            this.lbl_realizador.Location = new System.Drawing.Point(276, 101);
            this.lbl_realizador.Name = "lbl_realizador";
            this.lbl_realizador.Size = new System.Drawing.Size(103, 13);
            this.lbl_realizador.TabIndex = 5;
            this.lbl_realizador.Text = "Nome do Realizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elenco";
            // 
            // lbl_nome_a1
            // 
            this.lbl_nome_a1.AutoSize = true;
            this.lbl_nome_a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_a1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nome_a1.Location = new System.Drawing.Point(508, 116);
            this.lbl_nome_a1.Name = "lbl_nome_a1";
            this.lbl_nome_a1.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome_a1.TabIndex = 13;
            this.lbl_nome_a1.Text = "Nome";
            this.lbl_nome_a1.Click += new System.EventHandler(this.lbl_nome_a1_Click);
            // 
            // lbl_nome_a2
            // 
            this.lbl_nome_a2.AutoSize = true;
            this.lbl_nome_a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_a2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nome_a2.Location = new System.Drawing.Point(508, 186);
            this.lbl_nome_a2.Name = "lbl_nome_a2";
            this.lbl_nome_a2.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome_a2.TabIndex = 14;
            this.lbl_nome_a2.Text = "Nome";
            // 
            // lbl_nome_a3
            // 
            this.lbl_nome_a3.AutoSize = true;
            this.lbl_nome_a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_a3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nome_a3.Location = new System.Drawing.Point(508, 257);
            this.lbl_nome_a3.Name = "lbl_nome_a3";
            this.lbl_nome_a3.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome_a3.TabIndex = 15;
            this.lbl_nome_a3.Text = "Nome";
            // 
            // lbl_nome_a4
            // 
            this.lbl_nome_a4.AutoSize = true;
            this.lbl_nome_a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_a4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nome_a4.Location = new System.Drawing.Point(508, 324);
            this.lbl_nome_a4.Name = "lbl_nome_a4";
            this.lbl_nome_a4.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome_a4.TabIndex = 16;
            this.lbl_nome_a4.Text = "Nome";
            // 
            // lbl_nome_p1
            // 
            this.lbl_nome_p1.AutoSize = true;
            this.lbl_nome_p1.Location = new System.Drawing.Point(674, 116);
            this.lbl_nome_p1.Name = "lbl_nome_p1";
            this.lbl_nome_p1.Size = new System.Drawing.Size(66, 13);
            this.lbl_nome_p1.TabIndex = 17;
            this.lbl_nome_p1.Text = "Personagem";
            // 
            // lbl_nome_p2
            // 
            this.lbl_nome_p2.AutoSize = true;
            this.lbl_nome_p2.Location = new System.Drawing.Point(674, 186);
            this.lbl_nome_p2.Name = "lbl_nome_p2";
            this.lbl_nome_p2.Size = new System.Drawing.Size(66, 13);
            this.lbl_nome_p2.TabIndex = 18;
            this.lbl_nome_p2.Text = "Personagem";
            // 
            // lbl_nome_p3
            // 
            this.lbl_nome_p3.AutoSize = true;
            this.lbl_nome_p3.Location = new System.Drawing.Point(674, 257);
            this.lbl_nome_p3.Name = "lbl_nome_p3";
            this.lbl_nome_p3.Size = new System.Drawing.Size(66, 13);
            this.lbl_nome_p3.TabIndex = 19;
            this.lbl_nome_p3.Text = "Personagem";
            // 
            // lbl_nome_p4
            // 
            this.lbl_nome_p4.AutoSize = true;
            this.lbl_nome_p4.Location = new System.Drawing.Point(674, 324);
            this.lbl_nome_p4.Name = "lbl_nome_p4";
            this.lbl_nome_p4.Size = new System.Drawing.Size(66, 13);
            this.lbl_nome_p4.TabIndex = 20;
            this.lbl_nome_p4.Text = "Personagem";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(12, 383);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(207, 383);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(112, 383);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // dgv_filmes
            // 
            this.dgv_filmes.AllowUserToAddRows = false;
            this.dgv_filmes.AllowUserToDeleteRows = false;
            this.dgv_filmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_filmes.Location = new System.Drawing.Point(757, 55);
            this.dgv_filmes.MultiSelect = false;
            this.dgv_filmes.Name = "dgv_filmes";
            this.dgv_filmes.ReadOnly = true;
            this.dgv_filmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_filmes.Size = new System.Drawing.Size(228, 322);
            this.dgv_filmes.TabIndex = 1;
            this.dgv_filmes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_filmes_CellClick);
            this.dgv_filmes.SelectionChanged += new System.EventHandler(this.dgv_filmes_SelectionChanged);
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(12, 78);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(26, 13);
            this.lbl_ano.TabIndex = 28;
            this.lbl_ano.Text = "Ano";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(48, 50);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Click += new System.EventHandler(this.txt_nome_Click);
            // 
            // btn_capa
            // 
            this.btn_capa.Location = new System.Drawing.Point(207, 354);
            this.btn_capa.Name = "btn_capa";
            this.btn_capa.Size = new System.Drawing.Size(75, 23);
            this.btn_capa.TabIndex = 5;
            this.btn_capa.Text = "Selecionar Capa";
            this.btn_capa.UseVisualStyleBackColor = true;
            this.btn_capa.Click += new System.EventHandler(this.btn_capa_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(304, 383);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desc.Location = new System.Drawing.Point(207, 147);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(199, 201);
            this.txt_desc.TabIndex = 4;
            this.txt_desc.Text = "";
            this.txt_desc.Click += new System.EventHandler(this.txt_desc_Click);
            // 
            // cb_realizador
            // 
            this.cb_realizador.FormattingEnabled = true;
            this.cb_realizador.Location = new System.Drawing.Point(276, 98);
            this.cb_realizador.Name = "cb_realizador";
            this.cb_realizador.Size = new System.Drawing.Size(130, 21);
            this.cb_realizador.TabIndex = 3;
            // 
            // lbl_caminho
            // 
            this.lbl_caminho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_caminho.Location = new System.Drawing.Point(12, 358);
            this.lbl_caminho.Name = "lbl_caminho";
            this.lbl_caminho.Size = new System.Drawing.Size(189, 19);
            this.lbl_caminho.TabIndex = 35;
            this.lbl_caminho.Text = "Caminho";
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(48, 73);
            this.txt_ano.Mask = "0000";
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 2;
            // 
            // cb_atores
            // 
            this.cb_atores.FormattingEnabled = true;
            this.cb_atores.Location = new System.Drawing.Point(465, 71);
            this.cb_atores.Name = "cb_atores";
            this.cb_atores.Size = new System.Drawing.Size(145, 21);
            this.cb_atores.TabIndex = 7;
            // 
            // txt_nome_personagem
            // 
            this.txt_nome_personagem.Location = new System.Drawing.Point(616, 72);
            this.txt_nome_personagem.Name = "txt_nome_personagem";
            this.txt_nome_personagem.Size = new System.Drawing.Size(128, 20);
            this.txt_nome_personagem.TabIndex = 8;
            // 
            // lbl_filmes
            // 
            this.lbl_filmes.AutoSize = true;
            this.lbl_filmes.Location = new System.Drawing.Point(433, 55);
            this.lbl_filmes.Name = "lbl_filmes";
            this.lbl_filmes.Size = new System.Drawing.Size(36, 13);
            this.lbl_filmes.TabIndex = 50;
            this.lbl_filmes.Text = "Filmes";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(757, 385);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(199, 20);
            this.txt_pesquisar.TabIndex = 2;
            this.txt_pesquisar.Text = "Pesquisar...";
            this.txt_pesquisar.Click += new System.EventHandler(this.txt_pesquisar_Click);
            this.txt_pesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pesquisar_KeyDown);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackgroundImage = global::LMDB.Properties.Resources.plainicon_com_57215_256px_150;
            this.btn_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pesquisar.Location = new System.Drawing.Point(962, 383);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(23, 23);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // ptb_filme6
            // 
            this.ptb_filme6.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_filme6.Location = new System.Drawing.Point(656, 237);
            this.ptb_filme6.Name = "ptb_filme6";
            this.ptb_filme6.Size = new System.Drawing.Size(90, 129);
            this.ptb_filme6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_filme6.TabIndex = 49;
            this.ptb_filme6.TabStop = false;
            // 
            // ptb_filme5
            // 
            this.ptb_filme5.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_filme5.Location = new System.Drawing.Point(546, 237);
            this.ptb_filme5.Name = "ptb_filme5";
            this.ptb_filme5.Size = new System.Drawing.Size(90, 129);
            this.ptb_filme5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_filme5.TabIndex = 48;
            this.ptb_filme5.TabStop = false;
            // 
            // ptb_filme3
            // 
            this.ptb_filme3.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_filme3.Location = new System.Drawing.Point(656, 97);
            this.ptb_filme3.Name = "ptb_filme3";
            this.ptb_filme3.Size = new System.Drawing.Size(90, 129);
            this.ptb_filme3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_filme3.TabIndex = 47;
            this.ptb_filme3.TabStop = false;
            // 
            // ptb_filme2
            // 
            this.ptb_filme2.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_filme2.Location = new System.Drawing.Point(546, 97);
            this.ptb_filme2.Name = "ptb_filme2";
            this.ptb_filme2.Size = new System.Drawing.Size(90, 129);
            this.ptb_filme2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_filme2.TabIndex = 46;
            this.ptb_filme2.TabStop = false;
            // 
            // ptb_filme4
            // 
            this.ptb_filme4.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_filme4.Location = new System.Drawing.Point(436, 237);
            this.ptb_filme4.Name = "ptb_filme4";
            this.ptb_filme4.Size = new System.Drawing.Size(90, 129);
            this.ptb_filme4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_filme4.TabIndex = 45;
            this.ptb_filme4.TabStop = false;
            // 
            // ptb_filme1
            // 
            this.ptb_filme1.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_filme1.Location = new System.Drawing.Point(436, 97);
            this.ptb_filme1.Name = "ptb_filme1";
            this.ptb_filme1.Size = new System.Drawing.Size(90, 129);
            this.ptb_filme1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_filme1.TabIndex = 44;
            this.ptb_filme1.TabStop = false;
            // 
            // btn_add_ator
            // 
            this.btn_add_ator.BackgroundImage = global::LMDB.Properties.Resources.blue_plus;
            this.btn_add_ator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_ator.Location = new System.Drawing.Point(436, 70);
            this.btn_add_ator.Name = "btn_add_ator";
            this.btn_add_ator.Size = new System.Drawing.Size(23, 23);
            this.btn_add_ator.TabIndex = 6;
            this.btn_add_ator.UseVisualStyleBackColor = true;
            this.btn_add_ator.Click += new System.EventHandler(this.btn_add_ator_Click);
            // 
            // btn_del_a4
            // 
            this.btn_del_a4.BackgroundImage = global::LMDB.Properties.Resources.x_mark_4_512;
            this.btn_del_a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del_a4.Location = new System.Drawing.Point(436, 319);
            this.btn_del_a4.Name = "btn_del_a4";
            this.btn_del_a4.Size = new System.Drawing.Size(23, 23);
            this.btn_del_a4.TabIndex = 40;
            this.btn_del_a4.UseVisualStyleBackColor = true;
            this.btn_del_a4.Click += new System.EventHandler(this.btn_del_a4_Click);
            // 
            // btn_del_a3
            // 
            this.btn_del_a3.BackgroundImage = global::LMDB.Properties.Resources.x_mark_4_512;
            this.btn_del_a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del_a3.Location = new System.Drawing.Point(436, 252);
            this.btn_del_a3.Name = "btn_del_a3";
            this.btn_del_a3.Size = new System.Drawing.Size(23, 23);
            this.btn_del_a3.TabIndex = 39;
            this.btn_del_a3.UseVisualStyleBackColor = true;
            this.btn_del_a3.Click += new System.EventHandler(this.btn_del_a3_Click);
            // 
            // btn_del_a2
            // 
            this.btn_del_a2.BackgroundImage = global::LMDB.Properties.Resources.x_mark_4_512;
            this.btn_del_a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del_a2.Location = new System.Drawing.Point(436, 181);
            this.btn_del_a2.Name = "btn_del_a2";
            this.btn_del_a2.Size = new System.Drawing.Size(23, 23);
            this.btn_del_a2.TabIndex = 38;
            this.btn_del_a2.UseVisualStyleBackColor = true;
            this.btn_del_a2.Click += new System.EventHandler(this.btn_del_a2_Click);
            // 
            // btn_del_a1
            // 
            this.btn_del_a1.BackgroundImage = global::LMDB.Properties.Resources.x_mark_4_512;
            this.btn_del_a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del_a1.Location = new System.Drawing.Point(436, 111);
            this.btn_del_a1.Name = "btn_del_a1";
            this.btn_del_a1.Size = new System.Drawing.Size(23, 23);
            this.btn_del_a1.TabIndex = 37;
            this.btn_del_a1.UseVisualStyleBackColor = true;
            this.btn_del_a1.Click += new System.EventHandler(this.btn_del_a1_Click);
            // 
            // ptb_ator_4
            // 
            this.ptb_ator_4.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_ator_4.Location = new System.Drawing.Point(465, 307);
            this.ptb_ator_4.Name = "ptb_ator_4";
            this.ptb_ator_4.Size = new System.Drawing.Size(37, 53);
            this.ptb_ator_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ator_4.TabIndex = 12;
            this.ptb_ator_4.TabStop = false;
            // 
            // ptb_ator_3
            // 
            this.ptb_ator_3.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_ator_3.Location = new System.Drawing.Point(465, 237);
            this.ptb_ator_3.Name = "ptb_ator_3";
            this.ptb_ator_3.Size = new System.Drawing.Size(37, 53);
            this.ptb_ator_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ator_3.TabIndex = 10;
            this.ptb_ator_3.TabStop = false;
            // 
            // ptb_ator_2
            // 
            this.ptb_ator_2.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_ator_2.Location = new System.Drawing.Point(465, 167);
            this.ptb_ator_2.Name = "ptb_ator_2";
            this.ptb_ator_2.Size = new System.Drawing.Size(37, 53);
            this.ptb_ator_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ator_2.TabIndex = 8;
            this.ptb_ator_2.TabStop = false;
            // 
            // ptb_ator_1
            // 
            this.ptb_ator_1.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_ator_1.Location = new System.Drawing.Point(465, 97);
            this.ptb_ator_1.Name = "ptb_ator_1";
            this.ptb_ator_1.Size = new System.Drawing.Size(37, 53);
            this.ptb_ator_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ator_1.TabIndex = 7;
            this.ptb_ator_1.TabStop = false;
            // 
            // ptb_capa
            // 
            this.ptb_capa.ErrorImage = global::LMDB.Properties.Resources.Imagem_Erro2;
            this.ptb_capa.Location = new System.Drawing.Point(12, 97);
            this.ptb_capa.Name = "ptb_capa";
            this.ptb_capa.Size = new System.Drawing.Size(189, 280);
            this.ptb_capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_capa.TabIndex = 0;
            this.ptb_capa.TabStop = false;
            // 
            // lbl_erros
            // 
            this.lbl_erros.AutoSize = true;
            this.lbl_erros.ForeColor = System.Drawing.Color.Red;
            this.lbl_erros.Location = new System.Drawing.Point(433, 42);
            this.lbl_erros.Name = "lbl_erros";
            this.lbl_erros.Size = new System.Drawing.Size(34, 26);
            this.lbl_erros.TabIndex = 51;
            this.lbl_erros.Text = "\r\nErros:";
            this.lbl_erros.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 416);
            this.Controls.Add(this.lbl_erros);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_filmes);
            this.Controls.Add(this.ptb_filme6);
            this.Controls.Add(this.ptb_filme5);
            this.Controls.Add(this.ptb_filme3);
            this.Controls.Add(this.ptb_filme2);
            this.Controls.Add(this.ptb_filme4);
            this.Controls.Add(this.ptb_filme1);
            this.Controls.Add(this.btn_add_ator);
            this.Controls.Add(this.txt_nome_personagem);
            this.Controls.Add(this.cb_atores);
            this.Controls.Add(this.btn_del_a4);
            this.Controls.Add(this.btn_del_a3);
            this.Controls.Add(this.btn_del_a2);
            this.Controls.Add(this.btn_del_a1);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.lbl_caminho);
            this.Controls.Add(this.cb_realizador);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_capa);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.dgv_filmes);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lbl_nome_p4);
            this.Controls.Add(this.lbl_nome_p3);
            this.Controls.Add(this.lbl_nome_p2);
            this.Controls.Add(this.lbl_nome_p1);
            this.Controls.Add(this.lbl_nome_a4);
            this.Controls.Add(this.lbl_nome_a3);
            this.Controls.Add(this.lbl_nome_a2);
            this.Controls.Add(this.lbl_nome_a1);
            this.Controls.Add(this.ptb_ator_4);
            this.Controls.Add(this.ptb_ator_3);
            this.Controls.Add(this.ptb_ator_2);
            this.Controls.Add(this.ptb_ator_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_realizador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.ptb_capa);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "[Filmes] LMDb - Local Movie Database";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_filme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ator_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_capa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atoresToolStripMenuItem;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_realizador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb_ator_1;
        private System.Windows.Forms.PictureBox ptb_ator_2;
        private System.Windows.Forms.PictureBox ptb_ator_3;
        private System.Windows.Forms.PictureBox ptb_ator_4;
        private System.Windows.Forms.Label lbl_nome_a1;
        private System.Windows.Forms.Label lbl_nome_a2;
        private System.Windows.Forms.Label lbl_nome_a3;
        private System.Windows.Forms.Label lbl_nome_a4;
        private System.Windows.Forms.Label lbl_nome_p1;
        private System.Windows.Forms.Label lbl_nome_p2;
        private System.Windows.Forms.Label lbl_nome_p3;
        private System.Windows.Forms.Label lbl_nome_p4;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridView dgv_filmes;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_capa;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.ComboBox cb_realizador;
        private System.Windows.Forms.Label lbl_caminho;
        private System.Windows.Forms.MaskedTextBox txt_ano;
        private System.Windows.Forms.Button btn_del_a1;
        private System.Windows.Forms.Button btn_del_a2;
        private System.Windows.Forms.Button btn_del_a3;
        private System.Windows.Forms.Button btn_del_a4;
        private System.Windows.Forms.ComboBox cb_atores;
        private System.Windows.Forms.TextBox txt_nome_personagem;
        private System.Windows.Forms.Button btn_add_ator;
        private System.Windows.Forms.PictureBox ptb_filme1;
        private System.Windows.Forms.PictureBox ptb_filme4;
        private System.Windows.Forms.PictureBox ptb_filme2;
        private System.Windows.Forms.PictureBox ptb_filme3;
        private System.Windows.Forms.PictureBox ptb_filme5;
        private System.Windows.Forms.PictureBox ptb_filme6;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.Label lbl_filmes;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lbl_erros;
    }
}

