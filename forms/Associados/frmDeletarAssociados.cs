﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Emprestimo___Biblioteca.forms.Associados
{
    public partial class frmDeletarAssociados : Form
    {
        public frmDeletarAssociados()
        {
            InitializeComponent();
        }


        private void btnAtualizarListaAssociado_Click(object sender, EventArgs e)
        {
            AtualizarListaAssociados();
        }

        private void AtualizarListaAssociados()
        {
            listAssociadosCadastrados.Items.Clear(); // Limpa a lista antes de atualizar

            foreach (var associados in BancoDados.Associado)
            {
                ListViewItem item = new ListViewItem(associados.Id.ToString());
                item.SubItems.Add(associados.Nome);
                item.SubItems.Add(associados.CPF);
                listAssociadosCadastrados.Items.Add(item); // Adiciona o item à ListView
            }
        }

        private void btnExcluirAssociado_Click(object sender, EventArgs e)
        {
            if (listAssociadosCadastrados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um associado para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem itemSelecionado = listAssociadosCadastrados.SelectedItems[0];
            int idAssociado = int.Parse(itemSelecionado.Text);

            var AssociadoParaRemover = BancoDados.Associado.FirstOrDefault(a => a.Id == idAssociado);
            if (AssociadoParaRemover != null)
            {
                BancoDados.Associado.Remove(AssociadoParaRemover);

                AtualizarListaAssociados();

                MessageBox.Show("Associado excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Associado não encontrado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDeletarAssociados_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBuscarAssociadoDeletar_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtConsultacpfAssociadoDeletar.Text, out var cpfBusca))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var associadoEncontrado = BancoDados.Associado.FirstOrDefault(Associados => Associados.CPF == Convert.ToString(cpfBusca));

            listAssociadosCadastrados.Items.Clear();
            if (associadoEncontrado != null)
            {
                ListViewItem item = new ListViewItem(associadoEncontrado.Id.ToString());
                item.SubItems.Add(associadoEncontrado.Nome);
                item.SubItems.Add(associadoEncontrado.CPF);
                listAssociadosCadastrados.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Nenhum associado encontrado com o CPF informado.", "Resultados da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
