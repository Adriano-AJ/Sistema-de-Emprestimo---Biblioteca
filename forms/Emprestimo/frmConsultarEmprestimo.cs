using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Emprestimo___Biblioteca.forms.Emprestimo
{
    public partial class frmConsultarEmprestimo : Form
    {
        public frmConsultarEmprestimo()
        {
            InitializeComponent();
        }

        private void btnConsultarEmprestimo_Click(object sender, EventArgs e)
        {
            {
                string cpfAssociado = txtCPFAssociado.Text;

                // Validar se o CPF foi informado
                if (string.IsNullOrWhiteSpace(cpfAssociado))
                {
                    MessageBox.Show("Informe o CPF do associado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chamar o método para preencher a lista de empréstimos
                PreencherListaEmprestimos(cpfAssociado);
            }
        }

        private void btnPagarMulta_Click(object sender, EventArgs e)
        {
            string cpf = txtCPFAssociado.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Informe o CPF do associado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpf);
            if (associado == null)
            {
                MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double valorPago = double.Parse(txtValorMulta.Text.Replace("R$", "").Trim());
                bool quitado = associado.QuitarMultas(valorPago);

                if (quitado)
                {
                    // Atualiza o banco de dados
                    BancoDados.AtualizarAssociado(associado);

                    // Atualiza a interface
                    txtValorMulta.Text = "R$ 0,00"; // Zera o valor da multa na interface
                    btnPagarMulta.Enabled = false;   // Desabilita o botão de pagar multa

                    // Atualiza os botões de acordo com o status da multa
                    AtualizarStatusBotoes(associado);

                    MessageBox.Show("Multa quitada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O valor pago não é suficiente para quitar a multa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe um valor válido para a multa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao quitar multa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateSelectConsultar.Value.ToString());
            if (listEmprestimoAssociado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um empréstimo para devolução.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedItem = listEmprestimoAssociado.SelectedItems[0];
            int emprestimoId = int.Parse(selectedItem.SubItems[0].Text);

            List<DateTime> feriados = Emprestimos.ObterFeriados();

            string resultado = Emprestimos.EfetuarDevolucao(emprestimoId, dateSelectConsultar.Value,feriados);
            MessageBox.Show(resultado, "Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Atualiza a lista de empréstimos
            PreencherListaEmprestimos(txtCPFAssociado.Text.Trim());
        }

        private void listEmprestimoAssociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEmprestimoAssociado.SelectedItems.Count > 0)
            {
                var selectedItem = listEmprestimoAssociado.SelectedItems[0];

                // Preencher o ID do empréstimo
                txtIdEmprestimo.Text = selectedItem.SubItems[0].Text;

                // Preencher o valor da multa
                txtValorMulta.Text = selectedItem.SubItems[4].Text;

                string cpfAssociado = selectedItem.SubItems[1].Text;

                var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);

                AtualizarStatusBotoes(associado);
            }
        }

        private void PreencherListaEmprestimos(string cpfAssociado)
        {
            try
            {
                // Limpar itens existentes na lista
                listEmprestimoAssociado.Items.Clear();

                // Buscar associado pelo CPF
                var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);

                if (associado == null)
                {
                    MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Filtrar os empréstimos desse associado
                var emprestimosAssociado = BancoDados.Emprestimos.Where(e => e.AssociadoId == associado.Id).ToList();

                // Adicionar os empréstimos na lista
                foreach (var emprestimo in emprestimosAssociado)
                {
                    // Concatenar os títulos dos livros emprestados
                    string livrosConcatenados = string.Join(", ", emprestimo.Livros.Select(l => l.Titulo));

                    List<DateTime> feriados = Emprestimos.ObterFeriados();

                    // Calcular a multa temporária com base na data selecionada
                    string multa = Emprestimos.CalcularMulta(
                        emprestimo.DateDevolucao,
                        dateSelectConsultar.Value,
                        emprestimo.Livros.Count,
                        feriados
                    ).ToString("C");

                    // Criar o item para exibição
                    ListViewItem item = new ListViewItem(emprestimo.Id.ToString()); // ID do empréstimo
                    item.SubItems.Add(associado.CPF);                              // CPF do associado
                    item.SubItems.Add(associado.Nome);                             // Nome do associado
                    item.SubItems.Add(string.IsNullOrWhiteSpace(livrosConcatenados) ? "N/A" : livrosConcatenados); // Livros
                    item.SubItems.Add(multa);                                      // Multa calculada
                    item.SubItems.Add(emprestimo.DataEmprestimo.ToShortDateString()); // Data do empréstimo
                    item.SubItems.Add(emprestimo.DateDevolucao.ToShortDateString()); // Data prevista para devolução

                    // Adicionar o item à lista
                    listEmprestimoAssociado.Items.Add(item);
                }

                if (emprestimosAssociado.Count == 0)
                {
                    MessageBox.Show("Nenhum empréstimo encontrado para este associado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a lista de empréstimos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarStatusBotoes(Sistema_de_Emprestimo___Biblioteca.Associados associado)
        {
            if (associado == null)
            {
                btnDevolver.Enabled = false;
                btnPagarMulta.Enabled = false;
                return;
            }

            // Verifica se o associado tem multa
            if (associado.Multa > 0)
            {
                btnDevolver.Enabled = false;  // Bloqueia devolução
                btnPagarMulta.Enabled = true; // Permite pagamento
            }
            else
            {
                btnDevolver.Enabled = true;  // Permite devolução
                btnPagarMulta.Enabled = false; // Bloqueia pagamento
            }
        }
        private void dateSelectConsultar_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                // Verifica se um empréstimo está selecionado
                if (listEmprestimoAssociado.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecione um empréstimo na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtém o item selecionado e os dados correspondentes
                ListViewItem selectedItem = listEmprestimoAssociado.SelectedItems[0];
                int emprestimoId = int.Parse(selectedItem.SubItems[0].Text); // ID do empréstimo

                var emprestimo = BancoDados.Emprestimos.FirstOrDefault(e => e.Id == emprestimoId);
                if (emprestimo == null)
                {
                    MessageBox.Show("Empréstimo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtém o associado do empréstimo
                var associado = BancoDados.Associado.FirstOrDefault(a => a.Id == emprestimo.AssociadoId);
                if (associado == null)
                {
                    MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<DateTime> feriados = Emprestimos.ObterFeriados();
                // Calcula a multa com base na nova data de devolução
                DateTime novaDataDevolucao = dateSelectConsultar.Value;
                double multaCalculada = Emprestimos.CalcularMulta(emprestimo.DateDevolucao, novaDataDevolucao, emprestimo.Livros.Count,feriados);

                // Atualiza a multa no associado
                associado.Multa = (double)multaCalculada;
                
                // Atualizar os Botões
                btnDevolver.Enabled =  associado.Multa <= 0;
                btnPagarMulta.Enabled = associado.Multa > 0;

                // Atualiza os textos dos campos de multa na interface
                txtValorMulta.Text = multaCalculada.ToString("C"); // Mostra o valor formatado como moeda
                selectedItem.SubItems[4].Text = multaCalculada.ToString("C"); // Atualiza a lista

                MessageBox.Show("Multa recalculada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a multa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

    }
}

