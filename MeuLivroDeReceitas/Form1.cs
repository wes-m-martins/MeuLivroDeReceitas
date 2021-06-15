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
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       


        private void btnincluir_Click(object sender, EventArgs e)
        {
            
            string comofazer = txtDescricao.Text.Replace("\n", "&");
            Receita receita = new Receita(txtReceita.Text, txtDificuldade.Text, comofazer, dateTimePicker1.Value);
            listaReceitas.Add(receita);
            grid.DataSource = null;
            grid.DataSource = listaReceitas;


            using (StreamWriter writer = new StreamWriter("C:/Users/Aluno/source/repos/MeuLivroDeReceitas/MeuLivroDeReceitas/receitas.txt", true))
            {
                writer.WriteLine(txtReceita.Text + ";" + txtDificuldade.Text + ";" + comofazer + ";"+ dateTimePicker1.Value + "|");
                writer.Close();                
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
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
                        listaReceitas.Add(new Receita(linhaarquivo[0], linhaarquivo[1], linhaarquivo[2].Replace("&","\n"), Convert.ToDateTime(linhaarquivo[3])));
                    
               }
               grid.DataSource = listaReceitas;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var resposta = MessageBox.Show("Você quer visualizar a receita selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                var registro = listaReceitas.Find(x => x.Nome == (grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
                txtReceita.Text = registro.Nome;
                txtDificuldade.Text = registro.Dificuldade;
                txtDescricao.Text = registro.Descricao;
                dateTimePicker1.Text = registro.DataCadastro.ToString();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDificuldade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceita_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            listaReceitas.Remove(Receita);
        }
    }
}
