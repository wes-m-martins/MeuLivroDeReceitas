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
        public string TempoPreparo {get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }


        public Receita (string nome, string tempoprep, string descricao, DateTime datacad, DateTime dataat)
        {
            Nome = nome;
            TempoPreparo = tempoprep;
            Descricao = descricao;
            DataCadastro = datacad;
            DataAtualizacao = dataat;
        }
        public override string ToString()
        {
            string retorno = this.Nome + ";" + this.TempoPreparo + ";" + this.Descricao + ";" + this.DataCadastro + ";" + this.DataAtualizacao;
            return retorno;

        }
       

    }
}
