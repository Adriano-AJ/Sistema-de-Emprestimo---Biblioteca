using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sistema_de_Emprestimo___Biblioteca.forms.Associados
{
    public partial class frmConsultaAssociado : Form
    {
        public frmConsultaAssociado()
        {
            InitializeComponent();
        }

        

        
        private void btnBuscarAssociadoNome_Click(object sender, EventArgs e)
        {
           
            string nomeBusca = txtConsultaNomeAssociado.Text.ToLower();

            if (string.IsNullOrEmpty(nomeBusca))
            {
                MessageBox.Show("Por favor, insira um nome para buscar.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var resultados = BancoDados.Associado.Where(Associados => Associados.Nome.ToLower().Contains(nomeBusca)).ToList();

            listViewConsultaAssociado.Items.Clear();
            if (resultados.Any())
            {
                foreach (var associado in resultados)
                {
                    ListViewItem item = new ListViewItem(associado.Id.ToString());
                    item.SubItems.Add(associado.Nome);
                    item.SubItems.Add(associado.CPF);
                    listViewConsultaAssociado.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nenhum Associado encontrado com o nome informado.", "Resultados da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

       

        private void btnBuscarAssociadoCpf_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtConsultaCpfAssociado.Text, out var cpfBusca))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var associadoEncontrado = BancoDados.Associado.FirstOrDefault(Associados => Associados.CPF == Convert.ToString(cpfBusca));

            listViewConsultaAssociado.Items.Clear();
            if (associadoEncontrado != null)
            {
                ListViewItem item = new ListViewItem(associadoEncontrado.Id.ToString());
                item.SubItems.Add(associadoEncontrado.Nome);
                item.SubItems.Add(associadoEncontrado.CPF);
                listViewConsultaAssociado.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Nenhum associado encontrado com o CPF informado.", "Resultados da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLimparListaAssociado_Click(object sender, EventArgs e)
        {
           listViewConsultaAssociado.Items.Clear();
        }
    }
}