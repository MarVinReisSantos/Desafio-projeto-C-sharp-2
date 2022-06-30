using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dio.Serles;

namespace Dio.Serles
{
    public class Serie : EntidadeBase
    {
        private Genero Gereno {get; set;}

        private string Titulo{get; set;}
        private string Descricao {get; set;}
        private int Ano{get; set;}  
        private bool Excluido{get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Gereno = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Gereno + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrção: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo(){
            return this.Titulo;
        }

        public int retornaID(){
            return this.id;
        }
        public void Excluir (){
            this.Excluido = true;
        }

        public bool retornaExcluido(){
            return this.Excluido;
        }
    }
}