using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;     //ler o ficheiro app.config
using System.Data;
using System.Windows.Forms;

namespace LMDB
{
    class BaseDados
    {
        private static BaseDados instance;
        public static BaseDados Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaseDados();
                return instance;
            }
        }
        private string strLigacao;
        private SqlConnection ligacaoBD;
        public BaseDados()
        {

            //ligação à bd
            strLigacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
            strLigacao = strLigacao.Substring(0, strLigacao.IndexOf("filme") ) + Application.StartupPath + @"\bd\" + strLigacao.Substring(strLigacao.IndexOf("filme") );

            ligacaoBD = new SqlConnection(strLigacao);
         
            ligacaoBD.Open();
        }
        ~BaseDados()
        {
            try
            {
                ligacaoBD.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public DataTable devolveConsulta(string strSQL)
        {
            SqlCommand comando = new SqlCommand(strSQL, ligacaoBD);
            DataTable registos = new DataTable();

            SqlDataReader leitor = comando.ExecuteReader();
            registos.Load(leitor);

            return registos;
        }
        public static void criarBD(string nome)
        {
            string nomeBD = System.IO.Path.GetFileNameWithoutExtension(nome);
            var ligacaoServidor = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30");
            ligacaoServidor.Open();
            string strSQL = $"CREATE DATABASE {nomeBD} ON PRIMARY (NAME={nomeBD}, FILENAME='{nome}' )";
            var comando = new SqlCommand(strSQL, ligacaoServidor);
            comando.ExecuteNonQuery();
            //criar as tabelas
            ligacaoServidor = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={nome};Integrated Security=True;Connect Timeout=30");
            ligacaoServidor.Open();
            strSQL = @"CREATE TABLE Filmes(
cod_filme int identity not null primary key,
cod_realizador int not null,
nome varchar(50) not null check(len(nome)>1),
descricao varchar(500),
ano int check(ano like '____') default(datepart(YEAR,getdate())),
capa varchar(300),
trailer varchar(100)
);

CREATE TABLE Realizadores(
cod_realizador int identity not null primary key,
nome varchar(50) not null check(len(nome)>3),
biografia varchar(500),
fotografia varchar(100)

);

ALTER TABLE Filmes
ADD foreign key (cod_realizador) references Realizadores(cod_realizador) on delete cascade;


CREATE TABLE Atores(
cod_ator int identity not null primary key,
nome varchar(50) not null check(len(nome)>3),
biografia varchar(500),
fotografia varchar(100)

);

CREATE TABLE Filmes_Atores(
cod_filme int foreign key references Filmes(cod_filme) on delete cascade,
cod_ator int foreign key references Atores(cod_ator) on delete cascade,
personagem varchar(100) not null check(len(personagem)>6)
);

CREATE INDEX Ano_filmes
ON Filmes(ano DESC);
";
            comando = new SqlCommand(strSQL, ligacaoServidor);
            comando.ExecuteNonQuery();


            //criar as vistas
            strSQL = @"CREATE VIEW Capas
AS(SELECT Capa, cod_filme From Filmes)
";
            comando = new SqlCommand(strSQL, ligacaoServidor);
            comando.ExecuteNonQuery();


            strSQL = @"CREATE VIEW [Filmes_deste_ano]
AS(SELECT Filmes.Nome, Filmes.Capa, Filmes.Descricao, Realizadores.Nome AS [Realizador], Filmes.cod_filme, Filmes.Ano
                            From Filmes INNER JOIN Realizadores ON Filmes.cod_realizador = Realizadores.cod_realizador WHERE ano=DATEPART(YEAR,getdate()))";
            comando = new SqlCommand(strSQL, ligacaoServidor);
            comando.ExecuteNonQuery();



        }

        #region filmes
        public DataTable listarFilmesPesquisa(string text)
        {
            string strSQL = @"SELECT Filmes.Nome, Filmes.Capa , Filmes.Descricao as [Descrição], Realizadores.Nome as Realizador, Filmes.cod_filme as Código, Filmes.Ano
                            From Filmes INNER JOIN Realizadores ON Filmes.cod_realizador = Realizadores.cod_realizador
                            WHERE Filmes.nome LIKE '%'+@text+'%' ORDER By Filmes.Nome";
            SqlCommand comando = new SqlCommand(strSQL, ligacaoBD);
            DataTable resultado = new DataTable();
            comando.Parameters.AddWithValue("@text",text);

            SqlDataReader pesquisa = comando.ExecuteReader();
            resultado.Load(pesquisa);

            return resultado;

            //http://stackoverflow.com/questions/25254943/add-sqlparameter-to-bind-like-x
        }

        public void adicionarFilme(int cod_realizador,string nome, string desc, int ano, string capa="-1")
        {
            string sql = @"INSERT INTO Filmes(cod_realizador,nome,descricao,ano,capa)
                VALUES (@cod_realizador,@nome,@desc,@ano,@capa);";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@cod_realizador", cod_realizador);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@ano", ano);
            comando.Parameters.AddWithValue("@desc", desc);
          
            comando.Parameters.AddWithValue("@capa", capa);
       
            comando.ExecuteNonQuery();
        }

        public void editarFilme(int cod_filme, int cod_realizador, string nome, string desc, int ano, string capa)
        {
            string sql = @"UPDATE Filmes SET cod_realizador=@cod_realizador,nome =@nome,descricao=@desc,ano=@ano,capa=@capa
               WHERE cod_filme=@cod_filme;";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@cod_filme", cod_filme);
            comando.Parameters.AddWithValue("@cod_realizador", cod_realizador);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@ano", ano);
            comando.Parameters.AddWithValue("@desc", desc);

            comando.Parameters.AddWithValue("@capa", capa);

            comando.ExecuteNonQuery();
        }

        public DataTable listar1Filme(int codigo_filme)
        {
            string strSQL = @"SELECT Filmes.Nome, Filmes.Capa, Filmes.Descricao, Realizadores.Nome, Filmes.cod_filme, Filmes.ano
                            From Filmes INNER JOIN Realizadores ON Filmes.cod_realizador = Realizadores.cod_realizador
                            WHERE cod_filme = "+codigo_filme;
            return devolveConsulta(strSQL);
        }

        public DataTable cod_realizadorFilme(int codigo_filme)
        {
            string strSQL = @"SELECT cod_realizador FROM Filmes
                            WHERE cod_filme = " + codigo_filme;
            return devolveConsulta(strSQL);
        }

        public DataTable listarTodosFilmes()
        {
            string strSQL = @"SELECT Filmes.Nome, Filmes.Capa , Filmes.Descricao as [Descrição], Realizadores.Nome as Realizador, Filmes.cod_filme as Código, Filmes.Ano
                            From Filmes INNER JOIN Realizadores ON Filmes.cod_realizador = Realizadores.cod_realizador
                            ";
            return devolveConsulta(strSQL);
        }
        public DataTable atoresFilme(int codigo_filme)
        {
            string strSQL = @"SELECT Atores.Fotografia, Atores.Nome, Filmes_Atores.Personagem, Filmes_Atores.cod_ator
                            From Atores INNER JOIN Filmes_Atores ON Atores.cod_ator = Filmes_atores.cod_ator
                            WHERE Filmes_atores.cod_filme = "+codigo_filme;
            return devolveConsulta(strSQL);

        }

        public void eliminarParticipacao_Filme(int codigo_filme, int codigo_ator, string personagem)
        {
            string sql = @"DELETE FROM Filmes_Atores WHERE cod_filme=@codigo_filme AND cod_ator = @codigo_ator AND personagem=@personagem";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@codigo_filme", codigo_filme);
            comando.Parameters.AddWithValue("@codigo_ator", codigo_ator);
            comando.Parameters.AddWithValue("@personagem", personagem);

            comando.ExecuteNonQuery();
        }

        public void adicionarParticipacao_Filme(int codigo_filme, int codigo_ator, string personagem)
        {
            string sql = @"INSERT INTO Filmes_Atores(cod_filme,cod_ator,personagem) VALUES(@codigo_filme,@codigo_ator,@personagem)";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@codigo_filme", codigo_filme);
            comando.Parameters.AddWithValue("@codigo_ator", codigo_ator);
            comando.Parameters.AddWithValue("@personagem", personagem);

            comando.ExecuteNonQuery();
              
            
        }
        public DataTable minCodFilme()
        {
            string strSQL = @"SELECT TOP 1 cod_filme From Filmes Order by Cod_filme asc";
            return devolveConsulta(strSQL);
        }

        public DataTable maxCodFilme()
        {
            string strSQL = @"SELECT TOP 1 cod_filme From Filmes Order by Cod_filme desc";
            return devolveConsulta(strSQL);
        }

        public void eliminarFilme(int codigo_filme)
        {
            string sql = @"DELETE FROM Filmes WHERE cod_filme=@codigo_filme;";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@codigo_filme", codigo_filme);
         

        

            comando.ExecuteNonQuery();
        }

      
        public DataTable caminhoCapaFilme(int codigo_filme)
        {
            string strSQL = @"SELECT capa FROM Filmes WHERE cod_filme="+codigo_filme;
            return devolveConsulta(strSQL);
        }
        #endregion

        #region atores

        public DataTable listarAtoresPesquisa(string text)
        {
            string strSQL = @"SELECT Nome, Biografia, Fotografia, cod_ator
                            From Atores
                            WHERE Nome LIKE '%'+@text+'%' ORDER By Nome";
            SqlCommand comando = new SqlCommand(strSQL, ligacaoBD);
            DataTable resultado = new DataTable();
            comando.Parameters.AddWithValue("@text", text);

            SqlDataReader pesquisa = comando.ExecuteReader();
            resultado.Load(pesquisa);

            return resultado;

       
        }
        public DataTable listarTodosAtores()
        {
            string strSQL = @"SELECT Nome, Biografia, Fotografia, cod_ator
                            From Atores
                            ";
            return devolveConsulta(strSQL);
        }

        public DataTable listar1Ator(int codigo_ator)
        {
            string strSQL = @"SELECT Nome, Biografia, Fotografia, cod_ator
                            From  Atores
                            WHERE cod_ator = " + codigo_ator;
            return devolveConsulta(strSQL);
        }

        public DataTable minCodAtor()
        {
            string strSQL = @"SELECT TOP 1 cod_ator From Atores Order by Cod_ator asc";
            return devolveConsulta(strSQL);
        }

        public DataTable maxCodAtor()
        {
            string strSQL = @"SELECT TOP 1 cod_ator From Atores Order by Cod_ator desc";
            return devolveConsulta(strSQL);
        }

        public void adicionarAtor(string nome, string biografia, string fotografia = "-1")
        {

            string teste_foto = "";
            if (fotografia != "-1")
                teste_foto = ",fotografia";
            string sql = @"INSERT INTO Atores(nome,biografia"+teste_foto+") values(@nome,@biografia";

            if (fotografia != "-1") sql += ",@fotografia";

            sql += ");";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);

            comando.Parameters.AddWithValue("@nome", nome);

            comando.Parameters.AddWithValue("@biografia", biografia);

            if (fotografia != "-1")
                comando.Parameters.AddWithValue("@fotografia", fotografia);

            comando.ExecuteNonQuery();
        }

        public void editarAtor(int cod_ator, string nome, string biografia, string fotografia = "-1")
        {
            string sql = @"UPDATE Atores SET nome =@nome,biografia=@biografia";

            if (fotografia != "-1") sql += ",fotografia=@fotografia";
            sql += " WHERE cod_ator=@cod_ator;";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);

            comando.Parameters.AddWithValue("@cod_ator", cod_ator);
            comando.Parameters.AddWithValue("@nome", nome);

            comando.Parameters.AddWithValue("@biografia", biografia);

            if (fotografia != "-1")
                comando.Parameters.AddWithValue("@fotografia", fotografia);

            comando.ExecuteNonQuery();
        }

        public void eliminarAtor(int codigo_ator)
        {
            string sql = @"DELETE FROM Atores WHERE cod_ator=@codigo_ator;";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@codigo_ator", codigo_ator);




            comando.ExecuteNonQuery();
        }

        public DataTable participacoesAtor(int codigo_ator)
        {
            string strSQL = @"SELECT Count(*) From Filmes_Atores WHERE cod_ator=" + codigo_ator;
            return devolveConsulta(strSQL);
        }

        public DataTable filmesAtor(int codigo_ator)
        {
            string strSQL = @"SELECT DISTINCT  Filmes.Capa,Filmes.Nome, Filmes.cod_filme FROM Filmes INNER JOIN Filmes_Atores ON Filmes.cod_filme = Filmes_Atores.cod_filme WHERE Filmes_Atores.cod_ator=" + codigo_ator;
            return devolveConsulta(strSQL);
        }

        public DataTable caminhoFotoAtor(int codigo_ator)
        {
            string strSQL = @"SELECT fotografia FROM Atores WHERE cod_ator=" + codigo_ator;
            return devolveConsulta(strSQL);
        }
        #endregion

        #region realizadores

        public DataTable listarRealizadoresPesquisa(string text)
        {
            string strSQL = @"SELECT Nome, Biografia, Fotografia, cod_realizador
                            From Realizadores
                            WHERE Nome LIKE '%'+@text+'%' ORDER By Nome";
            SqlCommand comando = new SqlCommand(strSQL, ligacaoBD);
            DataTable resultado = new DataTable();
            comando.Parameters.AddWithValue("@text", text);

            SqlDataReader pesquisa = comando.ExecuteReader();
            resultado.Load(pesquisa);

            return resultado;


        }
        public DataTable listarTodosRealizadores()
        {
            string strSQL = @"SELECT Nome, Biografia, Fotografia, Cod_realizador
                            From Realizadores
                            ";
            return devolveConsulta(strSQL);
        }

        public DataTable listarFilmesRealizador(int codigo_realizador)
        {
            string strSQL = @"SELECT  Nome, Capa, cod_filme
                            From Filmes 
                            WHERE cod_realizador = " + codigo_realizador;
            return devolveConsulta(strSQL);
        }

        public DataTable listar1Realizador(int codigo_realizador)
        {
            string strSQL = @"SELECT Nome, Biografia, Fotografia, cod_realizador
                            From  Realizadores
                            WHERE cod_realizador = " + codigo_realizador;
            return devolveConsulta(strSQL);
        }

        public DataTable minCodRealizador()
        {
            string strSQL = @"SELECT TOP 1 cod_realizador From Realizadores Order by Cod_realizador asc";
            return devolveConsulta(strSQL);
        }

        public DataTable maxCodRealizador()
        {
            string strSQL = @"SELECT TOP 1 cod_realizador From Realizadores Order by Cod_realizador desc";
            return devolveConsulta(strSQL);
        }

        public void adicionarRealizador(string nome, string biografia, string fotografia="-1")
        {
            string teste_foto = "";
            if (fotografia != "-1")
                teste_foto = ",fotografia";

            string sql = @"INSERT INTO Realizadores(nome,biografia"+teste_foto+") values(@nome,@biografia";

            if(fotografia!="-1") sql+=",@fotografia";

            sql += ");";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
        
            comando.Parameters.AddWithValue("@nome", nome);
            
            comando.Parameters.AddWithValue("@biografia", biografia);

            if (fotografia != "-1") 
                comando.Parameters.AddWithValue("@fotografia", fotografia);

            comando.ExecuteNonQuery();
        }

        public void editarRealizador(int cod_realizador, string nome, string biografia, string fotografia = "-1")
        {
            string sql = @"UPDATE Realizadores SET nome =@nome,biografia=@biografia";   

 if (fotografia != "-1") sql += ",fotografia=@fotografia"; 
            sql+=   " WHERE cod_realizador=@cod_realizador;";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
        
            comando.Parameters.AddWithValue("@cod_realizador", cod_realizador);
            comando.Parameters.AddWithValue("@nome", nome);
           
            comando.Parameters.AddWithValue("@biografia", biografia);

            if (fotografia != "-1")
                comando.Parameters.AddWithValue("@fotografia", fotografia);

            comando.ExecuteNonQuery();
        }
        public void eliminarRealizador(int codigo_realizador)
        {
            string sql = @"DELETE FROM Realizadores WHERE cod_realizador=@codigo_realizador;";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@codigo_realizador", codigo_realizador);




            comando.ExecuteNonQuery();
        }

        public DataTable nfilmesRealizador(int codigo_realizador)
        {
            string strSQL = @"SELECT Count(*) From Filmes WHERE cod_realizador="+codigo_realizador;
            return devolveConsulta(strSQL);
        }

        public DataTable filmesRealizador(int codigo_realizador)
        {
            string strSQL = @"SELECT Capa,Nome, cod_filme FROM Filmes  WHERE cod_realizador=" + codigo_realizador;
            return devolveConsulta(strSQL);
        }

        public DataTable caminhoFotoRealizador(int codigo_realizador)
        {
            string strSQL = @"SELECT fotografia FROM Realizadores WHERE cod_realizador=" + codigo_realizador;
            return devolveConsulta(strSQL);
        }
        #endregion
    }
}
