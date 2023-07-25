using System.Collections;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface IDao<T>
    {
        IEnumerable<T> BuscarTodos();

        T BuscarPorId(int id);
        void incluir(T obj);

        void Alterar (T obj);
        void Excluir(T obj);
    }
}
