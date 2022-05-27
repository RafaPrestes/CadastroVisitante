using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tela_Cadastro_Visitante
{
    public partial class CadastroVisitante : Form
    {

        public CadastroVisitante()
        {
            InitializeComponent();
        }


        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarPrestador();

            /*foreach (var prestadores in Cadastrar.Nomes)
            {
                MessageBox.Show(prestadores); 
            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void salvarPrestador()
        {
            Cadastrar.Nomes.Add(txtNome.Text);
            Cadastrar.Rg.Add(txtRG.Text);
            Cadastrar.Telefone.Add(txtTelefone.Text);

            MessageBox.Show("Salvo com sucesso!");
        }

        public void recuperarDados()
        {
            txtNome.Text += (Cadastrar.Nomes);
            txtRG.Text += (Cadastrar.Rg);
            txtTelefone.Text += (Cadastrar.Telefone);
        }

    }
}
