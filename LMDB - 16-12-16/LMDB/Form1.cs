using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.IO;


namespace LMDB
{
    public partial class FormPrincipal : Form
    {
        int cod_filme_n = 2, cod_realizador_n = 2, cod_ator_n = 2, retirar = 0, n_atores = 0, cod_realizador_cb=0, n_filmes=0;
        bool aRefrescar = false;
        public FormPrincipal()
        {
            InitializeComponent();

           // int cod_filme_n = 0;

            if (System.IO.File.Exists(Application.StartupPath + @"\bd\filmes_bd.mdf") == false)
                BaseDados.criarBD(Application.StartupPath + @"\bd\filmes_bd.mdf");

            filmesToolStripMenuItem.Enabled = false;

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            ptb_ator_1.Visible = false;
            ptb_ator_2.Visible = false;
            ptb_ator_3.Visible = false;
            ptb_ator_4.Visible = false;

            lbl_nome_a1.Visible = false;
            lbl_nome_a2.Visible = false;
            lbl_nome_a3.Visible = false;
            lbl_nome_a4.Visible = false;

            lbl_nome_p1.Visible = false;
            lbl_nome_p2.Visible = false;
            lbl_nome_p3.Visible = false;
            lbl_nome_p4.Visible = false;

            btn_capa.Visible = false;
            btn_cancelar.Visible = false;

            txt_nome.Visible = false;
            txt_ano.Visible = false;
            txt_desc.Visible = false;

            lbl_caminho.Visible = false;
            cb_realizador.Visible = false;

            btn_add_ator.Visible = false;
            cb_atores.Visible = false;
            txt_nome_personagem.Visible = false;


            if (this.Text == "[Filmes] LMDb - Local Movie Database")
            {

                esconder_filmes();

                label2.Visible = true;
                lbl_ano.Visible = true;
                lbl_realizador.Visible = true;


              //  iniciar_filmes();
                atualizarGrelha();
                lerDGV(retirar);

            }
            else if (this.Text == "[Atores] LMDb - Local Movie Database")
            {
                label2.Visible = false;
                lbl_ano.Visible = false;
                mostrar_filmes();
                lbl_realizador.Visible = false;
               

                atualizarGrelha();

                lerDGV(retirar);
            }
            else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
            {
                label2.Visible = false;
                lbl_ano.Visible = false;
                mostrar_filmes();
                lbl_realizador.Visible = false;
              

                atualizarGrelha();

                lerDGV(retirar);

            }

        }

        private void atualizarGrelha()
        {



            aRefrescar = true;
            if (this.Text == "[Filmes] LMDb - Local Movie Database")
            {

                dgv_filmes.DataSource = BaseDados.Instance.listarTodosFilmes();
            }
            else if (this.Text == "[Atores] LMDb - Local Movie Database")
            {
                dgv_filmes.DataSource = BaseDados.Instance.listarTodosAtores();

            }
            else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
            {
                dgv_filmes.DataSource = BaseDados.Instance.listarTodosRealizadores();

            }
            aRefrescar = false;
        }

        private void iniciar_realizadores()
        {
            esconder_filmes();
            DataTable dados_realizador = BaseDados.Instance.listar1Realizador(cod_realizador_n);

            lbl_nome.Text = dados_realizador.Rows[0][0].ToString();

            try
            {


                ptb_capa.Image = Image.FromFile(Application.StartupPath + dados_realizador.Rows[0][2].ToString());
                lbl_caminho.Text = Application.StartupPath + dados_realizador.Rows[0][2].ToString();

            }
            catch (Exception)
            {
                ptb_capa.Image = ptb_capa.ErrorImage;
            }

            lbl_descricao.Text = dados_realizador.Rows[0][1].ToString();

            DataTable filmes_real = BaseDados.Instance.nfilmesRealizador(cod_realizador_n);
            label1.Text = "Filmes realizados: " + filmes_real.Rows[0][0].ToString();


            txt_desc.Text = "";
            txt_nome.Text = "";

            DataTable filmes = BaseDados.Instance.filmesRealizador(cod_realizador_n);
            n_filmes = filmes.Rows.Count;

            if (n_filmes >= 1)
            {
                lbl_filmes.Visible = true;
                ptb_filme1.Visible = true;

                try
                {
                    ptb_filme1.Image = Image.FromFile(Application.StartupPath + filmes.Rows[0][0].ToString());
                }
                catch (Exception)
                {
                    ptb_filme1.Image = ptb_filme1.ErrorImage;
                }



                if (n_filmes >= 2)
                {
                    ptb_filme2.Visible = true;

                    try
                    {
                        ptb_filme2.Image = Image.FromFile(Application.StartupPath + filmes.Rows[1][0].ToString());
                    }
                    catch (Exception)
                    {
                        ptb_filme2.Image = ptb_filme2.ErrorImage;
                    }



                    if (n_filmes >= 3)
                    {
                        ptb_filme3.Visible = true;

                        try
                        {
                            ptb_filme3.Image = Image.FromFile(Application.StartupPath + filmes.Rows[2][0].ToString());
                        }
                        catch (Exception)
                        {
                            ptb_filme3.Image = ptb_filme3.ErrorImage;
                        }

                        if (n_filmes >= 4)
                        {
                            ptb_filme4.Visible = true;


                            try
                            {
                                ptb_filme4.Image = Image.FromFile(Application.StartupPath + filmes.Rows[3][0].ToString());
                            }
                            catch (Exception)
                            {
                                ptb_filme4.Image = ptb_filme4.ErrorImage;
                            }

                            if (n_filmes >= 5)
                            {
                                ptb_filme5.Visible = true;


                                try
                                {
                                    ptb_filme5.Image = Image.FromFile(Application.StartupPath + filmes.Rows[3][0].ToString());
                                }
                                catch (Exception)
                                {
                                    ptb_filme5.Image = ptb_filme5.ErrorImage;
                                }

                                if (n_filmes >= 6)
                                {
                                    ptb_filme6.Visible = true;


                                    try
                                    {
                                        ptb_filme6.Image = Image.FromFile(Application.StartupPath + filmes.Rows[3][0].ToString());
                                    }
                                    catch (Exception)
                                    {
                                        ptb_filme6.Image = ptb_filme6.ErrorImage;
                                    }



                                }

                            }

                        }
                    }
                }

            }

        }

        private void iniciar_atores()
        {
            DataTable dados_ator = BaseDados.Instance.listar1Ator(cod_ator_n);

            lbl_nome.Text = dados_ator.Rows[0][0].ToString();

            esconder_filmes();

            try
            {


                ptb_capa.Image = Image.FromFile(Application.StartupPath + dados_ator.Rows[0][2].ToString());
                lbl_caminho.Text = Application.StartupPath + dados_ator.Rows[0][2].ToString();

            }
            catch (Exception)
            {
                ptb_capa.Image = ptb_capa.ErrorImage;
            }

            lbl_descricao.Text = dados_ator.Rows[0][1].ToString();

            DataTable filmes_ator = BaseDados.Instance.participacoesAtor(cod_ator_n);
            label1.Text = "Participações: " + filmes_ator.Rows[0][0].ToString();

            txt_desc.Text = "";
            txt_nome.Text = "";

            
            DataTable filmes = BaseDados.Instance.filmesAtor(cod_ator_n);
            n_filmes = filmes.Rows.Count;

            if (n_filmes >= 1)
            {
                lbl_filmes.Visible = true;
                ptb_filme1.Visible = true;
              
                try
                {
                    ptb_filme1.Image = Image.FromFile(Application.StartupPath + filmes.Rows[0][0].ToString());
                }
                catch (Exception )
                {
                    ptb_filme1.Image = ptb_filme1.ErrorImage;
                }

               

                if (n_filmes >= 2)
                {
                    ptb_filme2.Visible = true;
                  
                    try
                    {
                        ptb_filme2.Image = Image.FromFile(Application.StartupPath + filmes.Rows[1][0].ToString());
                    }
                    catch (Exception )
                    {
                        ptb_filme2.Image = ptb_filme2.ErrorImage;
                    }

               

                    if (n_filmes >= 3)
                    {
                        ptb_filme3.Visible = true;
                       
                        try
                        {
                            ptb_filme3.Image = Image.FromFile(Application.StartupPath + filmes.Rows[2][0].ToString());
                        }
                        catch (Exception )
                        {
                            ptb_filme3.Image = ptb_filme3.ErrorImage;
                        }

                        if (n_filmes >= 4)
                        {
                            ptb_filme4.Visible = true;
                           

                            try
                            {
                                ptb_filme4.Image = Image.FromFile(Application.StartupPath + filmes.Rows[3][0].ToString());
                            }
                            catch (Exception )
                            {
                                ptb_filme4.Image = ptb_filme4.ErrorImage;
                            }

                            if (n_filmes >= 5)
                            {
                                ptb_filme5.Visible = true;


                                try
                                {
                                    ptb_filme5.Image = Image.FromFile(Application.StartupPath + filmes.Rows[3][0].ToString());
                                }
                                catch (Exception )
                                {
                                    ptb_filme5.Image = ptb_filme5.ErrorImage;
                                }

                                if (n_filmes >= 6)
                                {
                                    ptb_filme6.Visible = true;


                                    try
                                    {
                                        ptb_filme6.Image = Image.FromFile(Application.StartupPath + filmes.Rows[3][0].ToString());
                                    }
                                    catch (Exception )
                                    {
                                        ptb_filme6.Image = ptb_filme6.ErrorImage;
                                    }



                                }

                            }

                        }
                    }
                }

            }
            

        }



        private void iniciar_filmes()
        {
            DataTable dados_filme = BaseDados.Instance.listar1Filme(cod_filme_n);
            DataTable cod_realizador_filme = BaseDados.Instance.cod_realizadorFilme(cod_filme_n);
            label2.Visible = false;
            lbl_nome.Text = dados_filme.Rows[0][0].ToString();

       //     string cenas = Application.StartupPath + dados_filme.Rows[0][1].ToString();
            try
            {

                //ptb_capa.ImageLocation = Application.StartupPath + dados_filme.Rows[0][1].ToString();
                ptb_capa.Image = Image.FromFile(Application.StartupPath+dados_filme.Rows[0][1].ToString());
                lbl_caminho.Text = Application.StartupPath + dados_filme.Rows[0][1].ToString();
               // ptb_capa.SizeMode =PictureBoxSizeMode.StretchImage;
            }
            catch (Exception e)
            {
                ptb_capa.Image = ptb_capa.ErrorImage;
            }
            lbl_descricao.Text = dados_filme.Rows[0][2].ToString();
            label1.Text = "Realizado por:";

            lbl_realizador.Text = dados_filme.Rows[0][3].ToString();
            lbl_ano.Text = dados_filme.Rows[0][5].ToString();

            cod_realizador_cb = Convert.ToInt32(cod_realizador_filme.Rows[0][0].ToString());

        //    cod_filme_n = Convert.ToInt32(dados_filme.Rows[0][4].ToString());

            DataTable atores = BaseDados.Instance.atoresFilme(cod_filme_n);
            //   int n_paginas = atores.Rows.Count/5;

            txt_ano.Text = "";
            txt_desc.Text = "";
            txt_nome.Text = "";
           // lbl_caminho.Text = "";
            cb_realizador.SelectedIndex = -1;

            enable_atores();
            ptb_ator_1.Visible = false;
            ptb_ator_2.Visible = false;
            ptb_ator_3.Visible = false;
            ptb_ator_4.Visible = false;

            lbl_nome_a1.Visible = false;
            lbl_nome_a2.Visible = false;
            lbl_nome_a3.Visible = false;
            lbl_nome_a4.Visible = false;

            lbl_nome_p1.Visible = false;
            lbl_nome_p2.Visible = false;
            lbl_nome_p3.Visible = false;
            lbl_nome_p4.Visible = false;

            btn_del_a1.Visible = false;
            btn_del_a2.Visible = false;
            btn_del_a3.Visible = false;
            btn_del_a4.Visible = false;

            btn_add_ator.Visible = false;
            cb_atores.Visible = false;
            txt_nome_personagem.Visible = false;


           
            n_atores = atores.Rows.Count;

            if (n_atores >= 1)
            {
                label2.Visible = true;
                ptb_ator_1.Visible = true;
                lbl_nome_a1.Visible = true;
                lbl_nome_p1.Visible = true;

                try
                {
                    ptb_ator_1.Image = Image.FromFile(Application.StartupPath + atores.Rows[0][0].ToString());
                }
                catch (Exception e)
                {
                    ptb_ator_1.Image = ptb_ator_1.ErrorImage;
                }

                lbl_nome_a1.Text = atores.Rows[0][1].ToString();
                lbl_nome_p1.Text = atores.Rows[0][2].ToString();

                if(n_atores >= 2)
                {
                    ptb_ator_2.Visible = true;
                    lbl_nome_a2.Visible = true;
                    lbl_nome_p2.Visible = true;

                    try
                    {
                        ptb_ator_2.Image = Image.FromFile(Application.StartupPath + atores.Rows[1][0].ToString());
                    }
                    catch (Exception e)
                    {
                        ptb_ator_2.Image = ptb_ator_2.ErrorImage;
                    }

                    lbl_nome_a2.Text = atores.Rows[1][1].ToString();
                    lbl_nome_p2.Text = atores.Rows[1][2].ToString();

                    if (n_atores >= 3)
                    {
                        ptb_ator_3.Visible = true;
                        lbl_nome_a3.Visible = true;
                        lbl_nome_p3.Visible = true;

                        try
                        {
                            ptb_ator_3.Image = Image.FromFile(Application.StartupPath + atores.Rows[2][0].ToString());
                        }
                        catch (Exception e)
                        {
                            ptb_ator_3.Image = ptb_ator_3.ErrorImage;
                        }

                        lbl_nome_a3.Text = atores.Rows[2][1].ToString();
                        lbl_nome_p3.Text = atores.Rows[2][2].ToString();

                        if (n_atores >= 4)
                        {
                            ptb_ator_4.Visible = true;
                            lbl_nome_a4.Visible = true;
                            lbl_nome_p4.Visible = true;

                            try
                            {
                                ptb_ator_4.Image = Image.FromFile(Application.StartupPath + atores.Rows[3][0].ToString());
                            }
                            catch (Exception e)
                            {
                                ptb_ator_4.Image = ptb_ator_4.ErrorImage;
                            }

                            lbl_nome_a4.Text = atores.Rows[3][1].ToString();
                            lbl_nome_p4.Text = atores.Rows[3][2].ToString();

                           
                        }
                    }
                }
              
            }
         




        }

        private void dgv_filmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            lerDGV(retirar);
        }
        
      

        private void lerDGV(int retirar_)
        {
            if (dgv_filmes.CurrentCell == null)
                return;

            if (this.Text == "[Filmes] LMDb - Local Movie Database")
            {
                int nlinha = dgv_filmes.CurrentCell.RowIndex - retirar_;
                int cod_filme_teste = int.Parse(dgv_filmes.Rows[nlinha].Cells[4].Value.ToString());
                DataTable min_cod_filme = BaseDados.Instance.minCodFilme();
                DataTable max_cod_filme = BaseDados.Instance.maxCodFilme();

                if (cod_filme_teste >= Convert.ToInt32(min_cod_filme.Rows[0][0].ToString()) && cod_filme_teste <= Convert.ToInt32(max_cod_filme.Rows[0][0].ToString()))
                {
                    cod_filme_n = cod_filme_teste;
                    iniciar_filmes();
                }
                retirar = 0;
            }

            else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
            {
                int nlinha = dgv_filmes.CurrentCell.RowIndex - retirar_;
                int cod_realizador_teste = int.Parse(dgv_filmes.Rows[nlinha].Cells[3].Value.ToString());

                DataTable min_cod_realizador = BaseDados.Instance.minCodRealizador();
                DataTable max_cod_realizador = BaseDados.Instance.maxCodRealizador();

                if (cod_realizador_teste >= Convert.ToInt32(min_cod_realizador.Rows[0][0].ToString()) && cod_realizador_teste <= Convert.ToInt32(max_cod_realizador.Rows[0][0].ToString()))
                {
                    cod_realizador_n = cod_realizador_teste;
                    iniciar_realizadores();
                }

            }


            else if (this.Text == "[Atores] LMDb - Local Movie Database")
            {
                int nlinha = dgv_filmes.CurrentCell.RowIndex-retirar_;
                int cod_ator_teste = int.Parse(dgv_filmes.Rows[nlinha].Cells[3].Value.ToString());

                DataTable min_cod_ator = BaseDados.Instance.minCodAtor();
                DataTable max_cod_ator = BaseDados.Instance.maxCodAtor();

                if (cod_ator_teste >= Convert.ToInt32(min_cod_ator.Rows[0][0].ToString()) && cod_ator_teste <= Convert.ToInt32(max_cod_ator.Rows[0][0].ToString()))
                {
                    cod_ator_n = cod_ator_teste;
                    iniciar_atores();
                }

            }

        }


        private void limpar_campos()
        {

            ptb_ator_1.Visible = false;
            ptb_ator_2.Visible = false;
            ptb_ator_3.Visible = false;
            ptb_ator_4.Visible = false;

            lbl_nome_a1.Visible = false;
            lbl_nome_a2.Visible = false;
            lbl_nome_a3.Visible = false;
            lbl_nome_a4.Visible = false;

            lbl_nome_p1.Visible = false;
            lbl_nome_p2.Visible = false;
            lbl_nome_p3.Visible = false;
            lbl_nome_p4.Visible = false;

            ptb_capa.Image = ptb_capa.ErrorImage;

        }

        private void esconder_filmes()
        {

            ptb_filme1.Visible = false;
            ptb_filme2.Visible = false;
            ptb_filme3.Visible = false;
            ptb_filme4.Visible = false;
            ptb_filme5.Visible = false;
            ptb_filme6.Visible = false;

            lbl_filmes.Visible = false;

        }
        private void mostrar_filmes()
        {

            ptb_filme1.Visible = true;
            ptb_filme2.Visible = true;
            ptb_filme3.Visible = true;
            ptb_filme4.Visible = true;
            ptb_filme5.Visible = true;
            ptb_filme6.Visible = true;

            lbl_filmes.Visible = true;

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (btn_adicionar.Text == "Adicionar")
            {

                menuStrip1.Enabled = false;
                lbl_caminho.Text = "";
                lbl_nome.Text = "Nome:";

                lbl_descricao.Text = "Descrição:";


                btn_capa.Visible = true;
                btn_cancelar.Visible = true;


                txt_nome.Visible = true;

                txt_desc.Visible = true;
                lbl_caminho.Visible = true;

                btn_adicionar.Text = "Guardar";

                btn_editar.Enabled = false;

                btn_eliminar.Enabled = false;

                if (this.Text == "[Filmes] LMDb - Local Movie Database")
                {
                    lbl_ano.Text = "Ano:";
                    txt_ano.Visible = true;

                    cb_realizador.Visible = true;
                    txt_ano.Text = "";
                    atualizarCB();
                    dgv_filmes.Enabled = false;
                    txt_pesquisar.Enabled = false;
                    btn_pesquisar.Enabled = false;

                    limpar_campos();
                }

             else   if (this.Text == "[Realizadores] LMDb - Local Movie Database" || this.Text== "[Atores] LMDb - Local Movie Database")
                {

                    label1.Visible = false;
                    ptb_filme1.Visible = false;
                    ptb_filme2.Visible = false;
                    ptb_filme3.Visible = false;
                    ptb_filme4.Visible = false;
                    ptb_filme5.Visible = false;
                    ptb_filme6.Visible = false;

                    ptb_capa.Image = ptb_capa.ErrorImage;

                }
            }

           
            else
            {
                bool ok_final = false;

                if (this.Text == "[Filmes] LMDb - Local Movie Database")
                {

                    lbl_erros.Text = "\nErros:";
                    int codigo_realizador=0;
                    int ok = 0;

                    if (txt_ano.Text.Length == 4)
                        ok = 1;
                    else
                    {
                        lbl_erros.Visible = true;
                        lbl_erros.Text += "\n*Escreva um ano.";
                        ok = 0;
                    }

                    if (txt_nome.Text.Length > 1)
                        ok = 1;
                    else
                    {
                        lbl_erros.Visible = true;
                        lbl_erros.Text += "\n*Escreva um nome.";
                        ok = 0;
                    }

                    try
                    {
                       codigo_realizador = ((Elementos)cb_realizador.SelectedItem).id;

                    }
                    catch (Exception)
                    {

                        lbl_erros.Visible = true;
                        lbl_erros.Text += "\n*Selecione um realizador.";
                        ok = 0;
                    }
                 
                    if (ok == 1)
                    {
                        ok_final = true;
                        string nome = txt_nome.Text, ano = txt_ano.Text;

                        string caminho_original = lbl_caminho.Text;
                        string caminho_capa = Application.StartupPath + @"\filmes\capa\";
                        if (!Directory.Exists(caminho_capa))
                            Directory.CreateDirectory(caminho_capa);

                        int index_ultima_barra = caminho_original.LastIndexOf(@"\");
                        // string nome_imagem = caminho_original.Substring(index_ultima_barra + 1, caminho_original.Length - index_ultima_barra - 1);
                        string prox_cod_filme = (Convert.ToInt32(BaseDados.Instance.maxCodFilme().Rows[0][0].ToString()) + 1).ToString();

                        string imagem = null;
                        if (lbl_caminho.Text != "" && lbl_caminho.Text != null)
                        {
                            if (!File.Exists(caminho_capa + prox_cod_filme + "-" + nome + "-" + ano /* + "-" + nome_imagem*/))
                                File.Copy(caminho_original, caminho_capa + prox_cod_filme + "-" + nome + "-" + ano  /* + "-" + nome_imagem*/);

                            imagem = @"\filmes\capa\" + prox_cod_filme + "-" + nome + "-" + ano /*  "-" + nome_imagem*/;
                        }
                        else
                            imagem = "";

                   //     int codigo_realizador = ((Elementos)cb_realizador.SelectedItem).id;
                        BaseDados.Instance.adicionarFilme(codigo_realizador, nome, txt_desc.Text, Convert.ToInt32(ano), imagem);
                        /*   if (lbl_caminho == "")
                               BaseDados.Instance.adicionarRealizador("", "");
                           else
                               BaseDados.Instance.adicionarRealizador("", "","");*/

                        int selected_row = Convert.ToInt32(dgv_filmes.CurrentCell.RowIndex);
                        iniciar_filmes();
                        atualizarGrelha();
                        try
                        {
                            dgv_filmes.CurrentCell = dgv_filmes.Rows[selected_row].Cells[0];
                        }
                        catch (Exception)
                        {
                            dgv_filmes.CurrentCell = dgv_filmes.Rows[0].Cells[0];

                        }

                    }
                }
                else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
                {

                    lbl_erros.Text = "\nErros:";
                    
                    int ok = 0;


                    if (txt_nome.Text.Length > 1)
                        ok = 1;
                    else
                    {
                        lbl_erros.Visible = true;
                        lbl_erros.Text += "\n*Escreva um nome.";
                        ok = 0;
                    }

                    if (ok == 1)
                    {
                        ok_final = true;
                        string nome = txt_nome.Text;

                        string caminho_original = lbl_caminho.Text;
                        string caminho_fotografia = Application.StartupPath + @"\realizadores\fotografia\";
                        if (!Directory.Exists(caminho_fotografia))
                            Directory.CreateDirectory(caminho_fotografia);

                        int index_ultima_barra = caminho_original.LastIndexOf(@"\");


                        string prox_cod_realizador = (Convert.ToInt32(BaseDados.Instance.maxCodRealizador().Rows[0][0].ToString()) + 1).ToString();

                        string imagem = null;
                        if (lbl_caminho.Text != "" && lbl_caminho.Text != null)
                        {
                            if (!File.Exists(caminho_fotografia + prox_cod_realizador + "-" + nome))
                                File.Copy(caminho_original, caminho_fotografia + prox_cod_realizador + "-" + nome);

                            imagem = @"\realizadores\fotografia\" + prox_cod_realizador + "-" + nome;
                        }

                        if (imagem == null)
                            BaseDados.Instance.adicionarRealizador(nome, txt_desc.Text);
                        else
                            BaseDados.Instance.adicionarRealizador(nome, txt_desc.Text, imagem);


                        int selected_row = Convert.ToInt32(dgv_filmes.CurrentCell.RowIndex);
                        iniciar_realizadores();
                        atualizarGrelha();
                        try
                        {
                            dgv_filmes.CurrentCell = dgv_filmes.Rows[selected_row - 1].Cells[0];
                        }
                        catch (Exception)
                        {
                            dgv_filmes.CurrentCell = dgv_filmes.Rows[0].Cells[0];

                        }
                    }

                }

                else if (this.Text == "[Atores] LMDb - Local Movie Database")
                {
                    lbl_erros.Text = "\nErros:";

                    int ok = 0;


                    if (txt_nome.Text.Length > 1)
                        ok = 1;
                    else
                    {
                        lbl_erros.Visible = true;
                        lbl_erros.Text += "\n*Escreva um nome.";
                        ok = 0;
                    }

                    if (ok == 1)
                    {
                        string nome = txt_nome.Text;

                        string caminho_original = lbl_caminho.Text;
                        string caminho_fotografia = Application.StartupPath + @"\atores\fotografia\";
                        if (!Directory.Exists(caminho_fotografia))
                            Directory.CreateDirectory(caminho_fotografia);

                        int index_ultima_barra = caminho_original.LastIndexOf(@"\");


                        string prox_cod_ator = (Convert.ToInt32(BaseDados.Instance.maxCodAtor().Rows[0][0].ToString()) + 1).ToString();

                        string imagem = null;
                        if (lbl_caminho.Text != "" && lbl_caminho.Text != null)
                        {
                            if (!File.Exists(caminho_fotografia + prox_cod_ator + "-" + nome))
                                File.Copy(caminho_original, caminho_fotografia + prox_cod_ator + "-" + nome);

                            imagem = @"\atores\fotografia\" + prox_cod_ator + "-" + nome;
                        }

                        if (imagem == null)
                            BaseDados.Instance.adicionarAtor(nome, txt_desc.Text);
                        else
                            BaseDados.Instance.adicionarAtor(nome, txt_desc.Text, imagem);


                        int selected_row = Convert.ToInt32(dgv_filmes.CurrentCell.RowIndex);
                        iniciar_atores();
                        atualizarGrelha();
                        try
                        {
                            dgv_filmes.CurrentCell = dgv_filmes.Rows[selected_row - 1].Cells[0];
                        }
                        catch (Exception)
                        {
                            dgv_filmes.CurrentCell = dgv_filmes.Rows[0].Cells[0];

                        }

                    }
                }

                if (ok_final == true)
                {
                    label1.Visible = true;
                    btn_adicionar.Text = "Adicionar";

                    btn_capa.Visible = false;
                    btn_cancelar.Visible = false;

                    dgv_filmes.Enabled = true;
                    txt_pesquisar.Enabled = true;
                    btn_pesquisar.Enabled = true;

                    txt_nome.Visible = false;
                    txt_ano.Visible = false;
                    txt_desc.Visible = false;
                    lbl_caminho.Visible = false;

                    btn_editar.Enabled = true;
                    btn_eliminar.Enabled = true;
                    cb_realizador.Visible = false;

                    menuStrip1.Enabled = true;

                    lbl_erros.Visible = false;
                    lbl_erros.Text = "\nErros:";
                }
            }
        }

        private void apagarParticipacao(int n_ator)
        {
            DataTable atores = BaseDados.Instance.atoresFilme(cod_filme_n);

            BaseDados.Instance.eliminarParticipacao_Filme(cod_filme_n, Convert.ToInt32(atores.Rows[n_ator-1][3].ToString()), atores.Rows[n_ator-1][2].ToString());


        }
        private void atualizarCB()
        {
            string strSQL = "SELECT cod_realizador,nome FROM Realizadores  ORDER BY nome";
            DataTable dados = BaseDados.Instance.devolveConsulta(strSQL);
            cb_realizador.Items.Clear();
            foreach (DataRow linha in dados.Rows)
                cb_realizador.Items.Add(new Elementos() { id = int.Parse(linha[0].ToString()), texto = linha[1].ToString() });

            strSQL = "SELECT cod_ator,nome FROM Atores  ORDER BY nome";
             dados = BaseDados.Instance.devolveConsulta(strSQL);
            cb_atores.Items.Clear();
            foreach (DataRow linha in dados.Rows)
                cb_atores.Items.Add(new Elementos() { id = int.Parse(linha[0].ToString()), texto = linha[1].ToString() });

        }
        private void txt_desc_Click(object sender, EventArgs e)
        {
       /*     if (btn_editar.Text != "Guardar")
                txt_desc.Text = "";*/
        }

        private void txt_ano_Click(object sender, EventArgs e)
        {
         /*   if (btn_editar.Text != "Guardar")
                txt_ano.Text = "";*/
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            if(btn_editar.Text!="Guardar")
            txt_nome.Text = "";
        }

        private void btn_capa_Click(object sender, EventArgs e)
        {
            OpenFileDialog cxDialogo = new OpenFileDialog();
            DialogResult resposta = cxDialogo.ShowDialog();
            if (resposta != DialogResult.OK) return;
            lbl_caminho.Text = cxDialogo.FileName;
            ptb_capa.Image = Image.FromFile(cxDialogo.FileName);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if((btn_adicionar.Text=="Guardar") || (btn_editar.Text=="Guardar"))
            {
                btn_adicionar.Text = "Adicionar";
                btn_editar.Text = "Editar";

                btn_capa.Visible = false;
                btn_cancelar.Visible = false;

               
                dgv_filmes.Enabled = true;
                txt_pesquisar.Enabled = true;
                btn_pesquisar.Enabled = true;
                txt_nome.Visible = false;
                txt_ano.Visible = false;
                txt_desc.Visible = false;
                lbl_caminho.Visible = false;

                btn_editar.Enabled = true;
                btn_adicionar.Enabled = true;
                btn_eliminar.Enabled = true;
                cb_realizador.Visible = false;

                menuStrip1.Enabled = true;

                label1.Visible = true;
                lbl_erros.Visible = false;
                lbl_erros.Text = "\nErros:";

                if (this.Text == "[Filmes] LMDb - Local Movie Database")
                {
                    iniciar_filmes();
                }

                else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
                {

                    iniciar_realizadores();
              
                }
                else if (this.Text == "[Atores] LMDb - Local Movie Database")
                {

                    iniciar_atores();

                }

                int selected_row = Convert.ToInt32(dgv_filmes.CurrentCell.RowIndex);
                atualizarGrelha();

                try
                {
                    dgv_filmes.CurrentCell = dgv_filmes.Rows[selected_row].Cells[0];
                }
                catch (Exception)
                {
                    dgv_filmes.CurrentCell = dgv_filmes.Rows[0].Cells[0];

                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DataTable caminho_imagem = null;

            if (this.Text == "[Filmes] LMDb - Local Movie Database")
            {
                DialogResult confirmacao = MessageBox.Show("Tem a certeza que deseja eliminar este filme?", "Confirmar eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirmacao == DialogResult.No) return;
                ///

              caminho_imagem = BaseDados.Instance.caminhoCapaFilme(cod_filme_n);
     
                BaseDados.Instance.eliminarFilme(cod_filme_n);

               

            }
            else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
            {
                DialogResult confirmacao = MessageBox.Show("Tem a certeza que deseja eliminar este realizador?", "Confirmar eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirmacao == DialogResult.No) return;
                ///


                caminho_imagem = BaseDados.Instance.caminhoFotoRealizador(cod_realizador_n);
              
                BaseDados.Instance.eliminarRealizador(cod_realizador_n);


            }
            else if (this.Text == "[Atores] LMDb - Local Movie Database")
            {
                DialogResult confirmacao = MessageBox.Show("Tem a certeza que deseja eliminar este ator?", "Confirmar eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirmacao == DialogResult.No) return;
                ///


                caminho_imagem = BaseDados.Instance.caminhoFotoAtor(cod_ator_n);

                BaseDados.Instance.eliminarAtor(cod_ator_n);

            }

            int selected_row = Convert.ToInt32(dgv_filmes.CurrentCell.RowIndex);

            lerDGV(retirar + 1);
            //   iniciar_filmes();
            atualizarGrelha();
            try
            {
                dgv_filmes.CurrentCell = dgv_filmes.Rows[selected_row - 1].Cells[0];
            }
            catch (Exception)
            {
                dgv_filmes.CurrentCell = dgv_filmes.Rows[0].Cells[0];

            }

            ptb_capa.Image = ptb_capa.ErrorImage;
            GC.Collect();
            if (File.Exists(Application.StartupPath + caminho_imagem.Rows[0][0].ToString()))
                try
                {
                    File.Delete(Application.StartupPath + caminho_imagem.Rows[0][0].ToString());
                }catch(Exception )
                {
                    MessageBox.Show("Não foi possível eliminar a imagem referente. Tente eliminar manualmente.", "Erro",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (btn_editar.Text == "Editar")
            {

                if (this.Text == "[Filmes] LMDb - Local Movie Database")
                {
                    txt_ano.Text = lbl_ano.Text;
                    lbl_ano.Text = "Ano:";
                    txt_ano.Visible = true;

                    btn_add_ator.Visible = true;
                    cb_atores.Visible = true;
                    txt_nome_personagem.Visible = true;

                    cb_realizador.Text = lbl_realizador.Text;

                    cb_realizador.Visible = true;

                         atualizarCB();



                    if (n_atores >= 1)
                    {

                        btn_del_a1.Visible = true;
                        btn_del_a1.Enabled = true;

                        if (n_atores >= 2)
                        {
                            btn_del_a2.Visible = true;
                            btn_del_a2.Enabled = true;

                            if (n_atores >= 3)
                            {
                                btn_del_a3.Visible = true;
                                btn_del_a3.Enabled = true;

                                if (n_atores >= 4)
                                {

                                    btn_del_a4.Visible = true;
                                    btn_del_a4.Enabled = true;
                                }
                            }
                        }
                    }

                }




                txt_nome.Text = lbl_nome.Text;
               
                txt_desc.Text = lbl_descricao.Text;


                lbl_nome.Text = "Nome:";
               
                lbl_descricao.Text = "Descrição:";



                btn_capa.Visible = true;
                btn_cancelar.Visible = true;


                txt_nome.Visible = true;
             
                txt_desc.Visible = true;
                lbl_caminho.Visible = true;

                btn_editar.Text = "Guardar";

                btn_adicionar.Enabled = false;

                btn_eliminar.Enabled = false;

                dgv_filmes.Enabled = false;
                txt_pesquisar.Enabled = false;
                btn_pesquisar.Enabled = false;

                menuStrip1.Enabled = false;



            }
            else
            {


                if (this.Text == "[Filmes] LMDb - Local Movie Database")
                {
                    string nome = txt_nome.Text, ano = txt_ano.Text;

                    string caminho_original = lbl_caminho.Text;
                    string caminho_capa = Application.StartupPath + @"\filmes\capa\";
                    if (!Directory.Exists(caminho_capa))
                        Directory.CreateDirectory(caminho_capa);

                    int index_ultima_barra = caminho_original.LastIndexOf(@"\");




                    if (!File.Exists(caminho_capa + cod_filme_n + "-" + nome + "-" + ano /* + "-" + nome_imagem*/))
                        File.Copy(caminho_original, caminho_capa + cod_filme_n + "-" + nome + "-" + ano  /* + "-" + nome_imagem*/);

                    string imagem = @"\filmes\capa\" + cod_filme_n + "-" + nome + "-" + ano /*  "-" + nome_imagem*/;

                    int codigo_realizador = 0;
                    try
                    {
                         codigo_realizador = ((Elementos)cb_realizador.SelectedItem).id;
                    }
                    catch (Exception)
                    {
                        codigo_realizador = cod_realizador_cb;
                      
                    }
                 
                    BaseDados.Instance.editarFilme(cod_filme_n, codigo_realizador, nome, txt_desc.Text, Convert.ToInt32(ano), imagem);


                  
                    cb_realizador.Visible = false;
                    txt_ano.Visible = false;

                    iniciar_filmes();

                }

               else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
                {
                    string nome = txt_nome.Text;

                    string caminho_original = lbl_caminho.Text;
                    string caminho_fotografia = Application.StartupPath + @"\realizadores\fotografia\";
                    if (!Directory.Exists(caminho_fotografia))
                        Directory.CreateDirectory(caminho_fotografia);

                    int index_ultima_barra = caminho_original.LastIndexOf(@"\");


                    string prox_cod_realizador = (Convert.ToInt32(BaseDados.Instance.maxCodRealizador().Rows[0][0].ToString()) + 1).ToString();

                   

                    string imagem = null;

                    
                    if (lbl_caminho.Text != "" && lbl_caminho.Text != null)
                    {
                        if (!File.Exists(caminho_fotografia + prox_cod_realizador + "-" + nome))
                            File.Copy(caminho_original, caminho_fotografia + prox_cod_realizador + "-" + nome);

                        imagem = @"\realizadores\fotografia\" + prox_cod_realizador + "-" + nome;
                    }

                    if (imagem == null)
                        BaseDados.Instance.editarRealizador(cod_realizador_n,nome, txt_desc.Text);
                    else
                        BaseDados.Instance.editarRealizador(cod_realizador_n,nome, txt_desc.Text, imagem);

                 



                    iniciar_realizadores();

                }

                else if (this.Text == "[Atores] LMDb - Local Movie Database")
                {
                    string nome = txt_nome.Text;

                    string caminho_original = lbl_caminho.Text;
                    string caminho_fotografia = Application.StartupPath + @"\atores\fotografia\";
                    if (!Directory.Exists(caminho_fotografia))
                        Directory.CreateDirectory(caminho_fotografia);

                    int index_ultima_barra = caminho_original.LastIndexOf(@"\");


                    string prox_cod_ator = (Convert.ToInt32(BaseDados.Instance.maxCodAtor().Rows[0][0].ToString()) + 1).ToString();



                    string imagem = null;


                    if (lbl_caminho.Text != "" && lbl_caminho.Text != null)
                    {
                        if (!File.Exists(caminho_fotografia + prox_cod_ator + "-" + nome))
                            File.Copy(caminho_original, caminho_fotografia + prox_cod_ator + "-" + nome);

                        imagem = @"\atores\fotografia\" + prox_cod_ator + "-" + nome;
                    }

                    if (imagem == null)
                        BaseDados.Instance.editarAtor(cod_ator_n, nome, txt_desc.Text);
                    else
                        BaseDados.Instance.editarAtor(cod_ator_n, nome, txt_desc.Text, imagem);





                    iniciar_atores();

                }

                btn_editar.Text = "Editar";

                btn_capa.Visible = false;
                btn_cancelar.Visible = false;

                dgv_filmes.Enabled = true;
                txt_pesquisar.Enabled = true;
                btn_pesquisar.Enabled = true;
                txt_nome.Visible = false;
               
                txt_desc.Visible = false;
                lbl_caminho.Visible = false;

                btn_adicionar.Enabled = true;
                btn_eliminar.Enabled = true;

                int selected_row = Convert.ToInt32(dgv_filmes.CurrentCell.RowIndex);
                atualizarGrelha();

                try
                {
                    dgv_filmes.CurrentCell = dgv_filmes.Rows[selected_row].Cells[0];
                }
                catch (Exception)
                {
                    dgv_filmes.CurrentCell = dgv_filmes.Rows[0].Cells[0];

                }

                menuStrip1.Enabled = true;

            }


        }

        private void enable_atores()
        {
            lbl_nome_a1.Enabled = true;
            lbl_nome_p1.Enabled = true;
            ptb_ator_1.Enabled = true;

            lbl_nome_a2.Enabled = true;
            lbl_nome_p2.Enabled = true;
            ptb_ator_2.Enabled = true;

            lbl_nome_a3.Enabled = true;
            lbl_nome_p3.Enabled = true;
            ptb_ator_3.Enabled = true;

            lbl_nome_a4.Enabled = true;
            lbl_nome_p4.Enabled = true;
            ptb_ator_4.Enabled = true;
        }

        private void btn_del_a1_Click(object sender, EventArgs e)
        {
            apagarParticipacao(1);
            lbl_nome_a1.Enabled = false;
            lbl_nome_p1.Enabled = false;
            ptb_ator_1.Enabled = false;
            btn_del_a1.Enabled = false;

        }

        private void btn_del_a2_Click(object sender, EventArgs e)
        {
            apagarParticipacao(2);

            lbl_nome_a2.Enabled = false;
            lbl_nome_p2.Enabled = false;
            ptb_ator_2.Enabled = false;
            btn_del_a2.Enabled = false;
        }

        private void btn_del_a3_Click(object sender, EventArgs e)
        {
            apagarParticipacao(3);

            lbl_nome_a3.Enabled = false;
            lbl_nome_p3.Enabled = false;
            ptb_ator_3.Enabled = false;
            btn_del_a3.Enabled = false;
        }

        private void btn_del_a4_Click(object sender, EventArgs e)
        {
            apagarParticipacao(4);

            lbl_nome_a4.Enabled = false;
            lbl_nome_p4.Enabled = false;
            ptb_ator_4.Enabled = false;
            btn_del_a4.Enabled = false;
        }

        private void lbl_nome_a1_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_consultas f = new fr_consultas();
            f.Show();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //http://plainicon.com/download-icon/57215/magnifying-glass


            if (this.Text == "[Filmes] LMDb - Local Movie Database")
            {
                dgv_filmes.DataSource = BaseDados.Instance.listarFilmesPesquisa(txt_pesquisar.Text);

            }
            else if (this.Text == "[Realizadores] LMDb - Local Movie Database")
            {
                dgv_filmes.DataSource = BaseDados.Instance.listarRealizadoresPesquisa(txt_pesquisar.Text);
            }
            else if (this.Text == "[Atores] LMDb - Local Movie Database")
            {
                dgv_filmes.DataSource = BaseDados.Instance.listarAtoresPesquisa(txt_pesquisar.Text);

            }
            
        }
       
        private void dgv_filmes_SelectionChanged(object sender, EventArgs e)
        {
            if(aRefrescar==false)
                lerDGV(retirar);
        }

        private void txt_pesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                btn_pesquisar_Click(this, new EventArgs());
            }
        }

        private void txt_pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_pesquisar.Text == "Pesquisar...")
                txt_pesquisar.Text = "";
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_sobre f = new fr_sobre();
            f.Show();
        }

        private void btn_add_ator_Click(object sender, EventArgs e)
        {
           
            int codigo_ator = ((Elementos)cb_atores.SelectedItem).id;


            BaseDados.Instance.adicionarParticipacao_Filme(cod_filme_n, codigo_ator, txt_nome_personagem.Text);

            cb_atores.SelectedIndex=-1;
            txt_nome_personagem.Text = "";
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "[Filmes] LMDb - Local Movie Database";

            filmesToolStripMenuItem.Enabled = false;
            realizadoresToolStripMenuItem.Enabled = true;
            atoresToolStripMenuItem.Enabled = true;

            FormPrincipal_Load(sender, e);
        }

        private void realizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "[Realizadores] LMDb - Local Movie Database";

            realizadoresToolStripMenuItem.Enabled = false;
            filmesToolStripMenuItem.Enabled = true;
            atoresToolStripMenuItem.Enabled = true;

            FormPrincipal_Load(sender, e);
        }

        private void atoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "[Atores] LMDb - Local Movie Database";

            atoresToolStripMenuItem.Enabled = false;
            realizadoresToolStripMenuItem.Enabled = true;
            filmesToolStripMenuItem.Enabled = true;

            FormPrincipal_Load(sender,e);
        }

        private void btn_testes_Click(object sender, EventArgs e)
        {
        
     
        }

 
    }

}
