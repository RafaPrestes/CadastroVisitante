using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Cadastro_Visitante
{
    public partial class Form1 : Form
    {
        string[] nomes = new string[6] { "1234", "rafael", "Belsi", "Tecnologia", "1234131", "1" } ;
        public Form1()
        {
            InitializeComponent();
            gerarGrade();
        }
        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //quando clicar em pesquisar irá fazer essa validação e depois buscar os clientes
            if (txtBuscar.Text == "")
            {
                lstVisitantes.Items.Clear();
                btnEditar.Hide(); //esconder o botão de editar qnd estiver vazio a pesquisa
            }
            else if (txtBuscar.Text.Equals(nomes))
            {
                MessageBox.Show("Ja tem!");
            }
            lstVisitantes.Items.Clear();
            buscarPrestador();
        }

        public void gerarGrade()
        {
            //gerando as colunas e a grade da listview
            lstVisitantes.View = View.Details; //como a listview irá aparecer, nesse caso como Details (as colunas como "titulos")
            lstVisitantes.Columns.Add("RG", 50).TextAlign = HorizontalAlignment.Left; //determinando que o texto irá ficar alinhado a esquerda
            lstVisitantes.Columns.Add("Nome", 300).TextAlign = HorizontalAlignment.Left;
            lstVisitantes.Columns.Add("Empresa", 150).TextAlign = HorizontalAlignment.Left;
            lstVisitantes.Columns.Add("Ramo", 120).TextAlign = HorizontalAlignment.Left;
            lstVisitantes.Columns.Add("Telefone Pessoal", 120).TextAlign = HorizontalAlignment.Left;
            lstVisitantes.Columns.Add("Acesso" , 60).TextAlign = HorizontalAlignment.Left;
            

            lstVisitantes.View = View.Details;
            lstVisitantes.GridLines = true; //ativa as gridlines     
        }

        public void buscarClientes()
        {
            foreach (string nome in nomes)
            {
                if(txtBuscar.Text.Equals(nome))
                {
                    //Adicionando um subitem de cada vez               
                    ListViewItem item1 = new ListViewItem("item1", 0);
                    item1.SubItems.Add("1234");
                    item1.SubItems.Add("rafael");
                    item1.SubItems.Add("Belsi");
                    item1.SubItems.Add("Tecnologia");
                    item1.SubItems.Add("1234131");
                    item1.SubItems.Add("1");
                    lstVisitantes.Items.AddRange(new ListViewItem[] { item1 });
                }
            }

            //Listando uma array, porem está listando na vertical
            /*
            for (int i = 0; i < nomes.Length; ++i)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(nomes[i].ToString());
                lstVisitantes.Items.Add(item);
            }*/
        }

        public void buscarPrestador()
        {
            foreach (var buscar in Cadastrar.Nomes)
            {   
                    ListViewItem busca = new ListViewItem("busca", 0);
                    busca.SubItems.Add(Cadastrar.Nomes.ToString());
                    busca.SubItems.Add(Cadastrar.Rg.ToString());
                    busca.SubItems.Add(Cadastrar.Telefone.ToString());

                if (txtBuscar.Text.Equals(buscar))
                {
                    lstVisitantes.Items.AddRange(new ListViewItem[] { busca });
                }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text;
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); //botão sair, quando clicar finalizar programa
        }

        private void lstVisitantes_MouseClick(object sender, MouseEventArgs e)
        {
            btnEditar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CadastroVisitante abrirEditar = new CadastroVisitante(); //instanciando um novo CadastroVisitante
            if(lstVisitantes != SelectionMode) 
            abrirEditar.Show(); //mandando abrir o botão de editar
            abrirEditar.recuperarDados(); //recuperando os dados dos prestadores cadastrados
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CadastroVisitante abrirIncluir = new CadastroVisitante();
            abrirIncluir.Show(); //abrir para inserir um novo prestador
        }
    }

    
}
