using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dio.Serles.Interfaces;

namespace Dio.Serles
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Enclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
           return listaSerie.Count;
        }

        public Serie RetornaId(int id)
        {
            return listaSerie[id];
        }
    }
}