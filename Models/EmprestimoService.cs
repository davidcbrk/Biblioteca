using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Biblioteca.Models
{
    public class EmprestimoService
    {
        public void Inserir(Emprestimo e)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Emprestimos.Add(e);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Emprestimo e)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Emprestimo emprestimo = bc.Emprestimos.Find(e.Id);
                emprestimo.NomeUsuario = e.NomeUsuario;
                emprestimo.Telefone = e.Telefone;
                emprestimo.LivroId = e.LivroId;
                emprestimo.DataEmprestimo = e.DataEmprestimo;
                emprestimo.DataDevolucao = e.DataDevolucao;
                emprestimo.Devolvido = e.Devolvido;

                bc.SaveChanges();
            }
        }

        public ICollection<Emprestimo> ListarTodos(FiltrosEmprestimos filtro)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                //filtro
                IQueryable<Emprestimo> query;

                if (filtro != null)
                {
                    //definido dinamicamente a filtragem
                    switch (filtro.TipoFiltro)
                    {

                        case "Usuario":
                            query = bc.Emprestimos.Where(l => l.NomeUsuario.Contains(filtro.Filtro));

                            break;

                        case "Livro":
                            query = bc.Emprestimos.Where(l => l.Livro.Titulo.Contains(filtro.Filtro));

                            break;

                        default:
                            query = bc.Emprestimos;
                            break;
                    }
                }
                else
                {
                    query = bc.Emprestimos;
                }

                //List<Emprestimo> emprestimos = query.OrderByDescending(e => e.DataDevolucao).ToList();
                List<Emprestimo> lista = query.OrderByDescending(e => e.DataDevolucao).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    lista[i].Livro = bc.Livros.Find(lista[i].LivroId);
                }

                //return query.OrderByDescending(e => e.DataDevolucao).ToList();
                //return query.Include(e => e.Livro).ToList();
                return lista;
            }
        }

        public Emprestimo ObterPorId(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Emprestimos.Find(id);
            }
        }
    }
}