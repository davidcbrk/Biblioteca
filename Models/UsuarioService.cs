using System.Collections.Generic;
using System;
using MySqlConnector;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Biblioteca.Models
{

    public class UsuarioService
    {
        public List<Usuario> Listar()
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.usuarios.ToList();
            }

        }

        public Usuario Listar(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.usuarios.Find(id);
            }
        }

        public void incluirUsuario(Usuario novoUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Add(novoUser);
                bc.SaveChanges();
            }
        }

        public void EdiatrUsuario(Usuario userEditado)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario u = bc.usuarios.Find(userEditado.Id);

                u.Login = userEditado.Login;
                u.Nome = userEditado.Nome;
                u.Senha = userEditado.Senha;
                u.Tipo = userEditado.Tipo;

                bc.SaveChanges();
            }
        }

        public void excluirUsuario(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.usuarios.Remove(bc.usuarios.Find(id));
                bc.SaveChanges();
            }
        }

        /*public Usuario ValidarLogin(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.Open();

            String SqlConsultaLoginSenha = "select * from Usuario WHERE Login=@Login and Senha=@Senha";

            MySqlCommand Comando = new MySqlCommand(SqlConsultaLoginSenha, Conexao);

            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario userEncontrado = null;

            if (Reader.Read())
            {
                userEncontrado = new Usuario();

                userEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");

            }

            Conexao.Close();

            return userEncontrado;

        }*/


        /*
        
        public void Inserir (Usuario us)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuario.Add(us);
                bc.SaveChanges();
            }
        }

        public void Editar(Usuario us)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuario.Find(us.Id);
                usuario.Nome = us.Nome;
                usuario.Login = us.Login;
                usuario.Senha = us.Senha;
                usuario.DataNascimento = us.DataNascimento;

                bc.SaveChanges();
            }

        }

        public Usuario ObterPorId(int Id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuario.Find(Id);
            }
        }
        

        public ICollection<Usuario> ListarTodos(FiltroUsuarios filtro = null)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Usuario> query;
                if (filtro != null)
                {
                    //definindo dinamicamente a filtragem
                    switch (filtro.TipoFiltro)
                    {
                        case "Nome":
                            query = bc.Usuario.Where(us => us.Nome.Contains(filtro.Filtro));
                            break;

                        //case "DataNascimento":
                        //    query = bc.Usuario.Where(us => us.Login.Contains(filtro.Filtro));
                        //    break;

                        default:
                            query = bc.Usuario;
                            break;
                    }
                }
                else
                {
                    // caso filtro não tenha sido informado
                    query = bc.Usuario;
                }

                //ordenação padrão
                return query.OrderBy(us => us.Nome).ToList();

            }
        }
    
        public void Remover(Usuario us)
        {
            //


        }
        */

        
        /*
        private const string DadosConexao = "Database=Biblioteca;Data Source=localhost; User Id=root;";

        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando");
            Conexao.Close();
        }


        public Usuario ValidarLogin(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String SqlConsultaLoginSenha = "select * from Usuario WHERE Login=@Login and Senha=@Senha";

            MySqlCommand Comando = new MySqlCommand(SqlConsultaLoginSenha, Conexao);

            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario userEncontrado = null;

            if (Reader.Read())
            {
                userEncontrado = new Usuario();

                userEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");

                userEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            Conexao.Close();

            return userEncontrado;

        }

        public void Inserir(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String SqlInclusao = "insert into Usuario (Nome,Login,Senha,DataNascimento) VALUES (@Nome,@Login,@Senha,@DataNascimento)";

            MySqlCommand Comando = new MySqlCommand(SqlInclusao, Conexao);

            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Remover(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String SqlExclusao = "delete from Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(SqlExclusao, Conexao);

            Comando.Parameters.AddWithValue("@Id", user.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Atualizar(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String SqlAtalizacao = "update Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(SqlAtalizacao, Conexao);

            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }


        public List<Usuario> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String SqlConsulta = "select * from Usuario";

            MySqlCommand Comando = new MySqlCommand(SqlConsulta, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Usuario> Lista = new List<Usuario>();

            while (Reader.Read())
            {
                Usuario User = new Usuario();

                User.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    User.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    User.Login = Reader.GetString("Login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    User.Senha = Reader.GetString("Senha");
                User.DataNascimento = Reader.GetDateTime("DataNascimento");

                Lista.Add(User);
            }

            Conexao.Close();

            return Lista;

        }

        public Usuario BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String SqlConsultaId = "select * from Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(SqlConsultaId, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario userEncontrado = new Usuario();

            if (Reader.Read())
            {
                userEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");

                userEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            Conexao.Close();

            return userEncontrado;
        }

        */
    }
}