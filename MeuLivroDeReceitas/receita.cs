using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuLivroDeReceitas
{
    public class Receita
    {
        public string Nome { get; set; }
        public string Dificuldade { get; set; }
        public DateTime DataCadastro { get; set; }

    
        public Receita (string nome, string nivel, DateTime data)
        {
            Nome = nome;
            Dificuldade = nivel;
            DataCadastro = data;
        }
        public override string ToString()
        {
            string retorno = this.Nome + ";" + this.Dificuldade + ";" + this.DataCadastro;
            return retorno;

        }

    }
}
