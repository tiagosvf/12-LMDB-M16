using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMDB
{
    public partial class fr_consultas : Form
    {
        public fr_consultas()
        {
            InitializeComponent();
        }

        private void nºDeParticipaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listar o número de participações de cada ator
            string sql = "SELECT Atores.Nome, Count(Filmes_Atores.Personagem) AS [Nº de Participações] FROM Atores INNER JOIN Filmes_Atores ON Filmes_Atores.cod_ator = Atores.cod_ator GROUP BY Atores.Nome ORDER BY [Nº de Participações] Desc";
            dgv_consultas.DataSource = BaseDados.Instance.devolveConsulta(sql);
        }

        private void filmesDesteAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listar as participações de cada ator em filmes deste ano
            string sql = "SELECT Atores.Nome AS [Ator], Filmes_Atores.Personagem, Filmes.Nome AS [Filme] FROM Atores INNER JOIN Filmes_Atores ON Filmes_Atores.cod_ator = Atores.cod_ator INNER JOIN Filmes ON Filmes_Atores.cod_filme = Filmes.cod_filme WHERE Filmes.Ano=datepart(YEAR,getdate()) ORDER BY Atores.Nome ASC";
            dgv_consultas.DataSource = BaseDados.Instance.devolveConsulta(sql);
        }

        private void filmesDesteAnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            //listar todos os filmes lançados este ano
            string sql = "SELECT * FROM [Filmes_deste_ano]";
            dgv_consultas.DataSource = BaseDados.Instance.devolveConsulta(sql);
        }
    }
}
