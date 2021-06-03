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
            Receita receita = new Receita(txtReceita.Text, txtDificuldade.Text, dateTimePicker1.Value);
            listaReceitas.Add(receita);
            grid.DataSource = null;
            grid.DataSource = listaReceitas;

            using (StreamWriter writer = new StreamWriter("C:/Users/Aluno/source/repos/MeuLivroDeReceitas/MeuLivroDeReceitas/receitas.txt", true))
            {
                writer.WriteLine(txtReceita.Text + ";" + txtDificuldade.Text + ";"+ dateTimePicker1.Value);
                                
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
                    listaReceitas.Add(new Receita(linhaarquivo[0], linhaarquivo[1], Convert.ToDateTime(linhaarquivo[2])));

               }
               grid.DataSource = listaReceitas;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
