using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Emprestimo___Biblioteca
{
    public partial class frmCadastraAssociado : Form
    {
        public frmCadastraAssociado()
        {
            InitializeComponent();
        }
        
        private void btnAdicionarNovoAssociado_Click(object sender, EventArgs e)
        {
           

            try
            {
                string nome = txtNomeAssociado.Text;
                string sexo = cmbSexoAssociado.Text; 
                string logradouro = txtLogradouroAssociado.Text;
                string cidade = txtCidadeAssociado.Text;
                string estado = txtEstadoAssociado.Text;
                string cpf = txtCpfAssociado.Text;
                string pais = txtPaisAssociado.Text;
                double multa = 0;

                var associadoExistente = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpf);
                if (associadoExistente != null)
                {
                    MessageBox.Show("Já existe um associado cadastrado com este CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Associados Associados1 = Associados.CriarAssociado(nome,cpf,sexo,logradouro,cidade,estado,pais);
                BancoDados.Associado.Add(Associados1);

                ListViewItem item = new ListViewItem(Associados1.Id.ToString());
                item.SubItems.Add(Associados1.Nome);
                item.SubItems.Add(Associados1.CPF);
                item.SubItems.Add(Associados1.Sexo);
                item.SubItems.Add(Associados1.Logradouro);
                item.SubItems.Add(Associados1.Cidade);
                item.SubItems.Add(Associados1.Estado);
                item.SubItems.Add(Associados1.Pais);

                listAssociadosNovos.Items.Add(item);
                MessageBox.Show("Associado adicionado com sucesso!");
            }
            catch (ArgumentException ex)
            {
                // Mostra mensagens de erro específicas
                MessageBox.Show($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Mostra mensagens de erro gerais
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
