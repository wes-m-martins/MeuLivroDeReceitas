using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MeuLivroDeReceitas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private List<Receita> listaReceitas = new List<Receita>();
       

       
        private void btnincluir_Click(object sender, EventArgs e)
        {
            
            string comofazer = txtDescricao.Text.Replace("\n", "&");
            Receita receita = new Receita(txtReceita.Text, txtTempo.Text, comofazer, dateTimeCria.Value, dateTimeAtu.Value);
            listaReceitas.Add(receita);
            grid.DataSource = null;
            grid.DataSource = listaReceitas;


            using (StreamWriter writer = new StreamWriter("C:/Users/Aluno/source/repos/MeuLivroDeReceitas/MeuLivroDeReceitas/receitas.txt", true))
            {
                writer.WriteLine(txtReceita.Text + ";" + txtTempo.Text + ";" + comofazer + ";"+ dateTimeCria.Value + ";" + dateTimeAtu.Value);
                writer.Close();                
            }
        }

        

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            string linhas;
            using (StreamReader leitor = new StreamReader("C:/Users/Aluno/source/repos/MeuLivroDeReceitas/MeuLivroDeReceitas/receitas.txt"))
            {
                linhas = leitor.ReadLine();


               while ((linhas = leitor.ReadLine()) != null)
               {           
                                   
                        string[] linhaarquivo = linhas.Split(';');
                        listaReceitas.Add(new Receita(linhaarquivo[0], linhaarquivo[1], linhaarquivo[2].Replace("&","\n"), Convert.ToDateTime(linhaarquivo[3]), Convert.ToDateTime(linhaarquivo[4])));
                    
               }
               grid.DataSource = listaReceitas;
            }

        }

       
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIncluir.Enabled = false;
            btnApagar.Enabled = true;
            btnSalvar.Enabled = true;
            var resposta = MessageBox.Show("Você quer visualizar a receita selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                var registro = listaReceitas.Find(x => x.Nome == (grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                txtReceita.Text = registro.Nome;
                txtTempo.Text = registro.TempoPreparo;
                txtDescricao.Text = registro.Descricao;
                dateTimeCria.Text = registro.DataCadastro.ToString();
                dateTimeCria.Text = registro.DataAtualizacao.ToString();
            }
            
        }

       

       

       

        private void btnApagar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Você quer apagar a receita selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                Receita registro = listaReceitas.Find(x => x.Nome == txtReceita.Text);
                listaReceitas.Remove(registro);
                grid.DataSource = null;
                grid.DataSource = listaReceitas;
                txtReceita.Text = " ";
                txtTempo.Text = " ";
                txtDescricao.Text = " ";
                
            }
            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
            this.Enabled = false;
        }

       

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (this.Enabled == true) {
                btnIncluir.Enabled = true;
                btnApagar.Enabled = true;
                var resposta = MessageBox.Show("Você quer salvar a receita ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    Receita registro = listaReceitas.Find(x => x.Nome == txtReceita.Text);
                    listaReceitas.Remove(registro);
                    btnIncluir.PerformClick();
                }
            }
            else
                MessageBox.Show("Você tem que selecionar alguma receita para depois salvar a alteração", "Aviso", MessageBoxButtons.OK);
        }
    }
}
