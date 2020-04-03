using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Time
    {
        /*atributos*/
        private string nome;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empates;

        /*construtor*/
        public Time (string Nome)
        {
            this.nome = Nome;
            this.vitorias = 0;
            this.derrotas = 0;
            this.empates = 0;
        }

        /*metodos*/
        public string Nome
        {
            get { return nome; }
        }

        public string getStatus()
        {
            return " O status do Time " + this.Nome +
                   " e Vitorias:" + this.Vitorias +
                   " Derrotas: " + this.Derrotas +
                   " Empates: " + this.Empates;
        }

        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }

        public Int32 Derrotas
        {
            get { return derrotas; }
            set { derrotas += value; }
        }

        public Int32 Empates
        {
            get { return empates; }
            set { empates += value; }
        }
    }
}
