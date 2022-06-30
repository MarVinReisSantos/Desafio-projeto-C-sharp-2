using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.Serles.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaId(int id);
        void insere (T entidade);
        void Enclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}