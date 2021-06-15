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
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

    
        public Receita (string nome, string nivel, string descricao, DateTime data)
        {
            Nome = nome;
            Dificuldade = nivel;
            Descricao = descricao;
            DataCadastro = data;
        }
        public override string ToString()
        {
            string retorno = this.Nome + ";" + this.Dificuldade + ";" + this.Descricao + ";" + this.DataCadastro + "|";
            return retorno;

        }
       

    }
}
