using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ViewForms
{
    public partial class MainForm : Form
    {
        private const string LIMITE_CREDITO_LABEL_INICIAL = "Informe sua renda mensal para saber o limite de crédito disponível.";

        private double _valorRenda;
        private double _limiteCredito;
        private IEnumerable<Proposta> _propostas;

        public MainForm()
        {
            InitializeComponent();
            ReiniciarProcesso();
        }

        private void ReiniciarProcesso()
        {
            LimparCampos();
            HabilitarCamposRenda(true);
            limiteCreditoLabel.Text = LIMITE_CREDITO_LABEL_INICIAL;
            HabilitarCamposValorCredito(false);
            propostasGroupBox.Enabled = false;
            VisualizarDetalhesProposta();
            contratarButton.Enabled = false;
            rendaTextBox.Focus();
        }

        private void LimparCampos()
        {
            rendaTextBox.Text = string.Empty;
            valorCreditoTextBox.Text = string.Empty;

            proposta12RadioButton.Checked = false;
            proposta24RadioButton.Checked = false;
            proposta36RadioButton.Checked = false;

            proposta12RadioButton.Text = string.Empty;
            proposta24RadioButton.Text = string.Empty;
            proposta36RadioButton.Text = string.Empty;

            detalhesLabel.Text = string.Empty;

            _valorRenda = 0.0;
            _limiteCredito = 0.0;
            _propostas = null;
        }

        private void VisualizarDetalhesProposta(string detalhes = null)
        {
            detalhesLabel.Text = detalhes;
            detalhesLabel.Visible = detalhes != null;
        }

        private void HabilitarCamposRenda(bool habilitar)
        {
            rendaLabel.Enabled = habilitar;
            rendaTextBox.Enabled = habilitar;
        }

        private void HabilitarCamposValorCredito(bool habilitar)
        {
            valorCreditoLabel.Enabled = habilitar;
            valorCreditoTextBox.Enabled = habilitar;
        }

        private static string FormatarMoeda(double valor)
        {
            return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", valor);
        }

        private void CarregarPropostas(double valorCredito)
        {
            _propostas = CreditoService.CarregarPropostas(_valorRenda, valorCredito);

            proposta12RadioButton.Text = _propostas.First(x => x.Parcelas == 12).Descricao;
            proposta24RadioButton.Text = _propostas.First(x => x.Parcelas == 24).Descricao;
            proposta36RadioButton.Text = _propostas.First(x => x.Parcelas == 36).Descricao;
        }

        private void reiniciarProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReiniciarProcesso();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rendaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                     || ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1));
        }

        private void rendaTextBox_Leave(object sender, EventArgs e)
        {
            if (CreditoService.VerificarRenda(rendaTextBox.Text, out _valorRenda))
            {
                rendaTextBox.Text = FormatarMoeda(_valorRenda);
                _limiteCredito = CreditoService.CalcularLimiteCredito(_valorRenda);
                limiteCreditoLabel.Text = $"Você possui o limite de crédito avaliado em {FormatarMoeda(_limiteCredito)}.";
                HabilitarCamposRenda(false);
            }
            else
            {
                MessageBox.Show($"Infelizmente a renda mensal informada não é válida.\nPor favor, informe um valor válido.\nValor de renda mínima: {FormatarMoeda(CreditoService.RENDA_MINIMA)}.", "Renda mensal inválida");
                rendaTextBox.Text = string.Empty;
                HabilitarCamposValorCredito(false);
                rendaTextBox.Focus();
            }
        }

        private void rendaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rendaTextBox.Text.Length > 0)
            {
                HabilitarCamposValorCredito(true);
            }
        }

        private void valorCreditoTextBox_Leave(object sender, EventArgs e)
        {
            if (rendaTextBox.Text.Length == 0)
            {
                return;
            }

            if (CreditoService.VerificarCredito(valorCreditoTextBox.Text, _limiteCredito, out double valorCredito))
            {
                valorCreditoTextBox.Text = FormatarMoeda(valorCredito);
                CarregarPropostas(valorCredito);
                HabilitarCamposValorCredito(false);
            }
            else
            {
                MessageBox.Show($"O valor informado não é válido.\nO crédito mínimo é de {FormatarMoeda(CreditoService.CREDITO_MINIMO)} e máximo é de {FormatarMoeda(_limiteCredito)}.\nFavor informar um valor entre os limites.", "Crédito desejado inválido");
                valorCreditoTextBox.Text = string.Empty;
                HabilitarCamposValorCredito(true);
                propostasGroupBox.Enabled = false;
                valorCreditoTextBox.Focus();
            }
        }

        private void valorCreditoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (valorCreditoTextBox.Text.Length > 0)
            {
                propostasGroupBox.Enabled = true;
            }
        }

        private void propostaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (proposta12RadioButton.Checked)
            {
                detalhesLabel.Text = _propostas.FirstOrDefault(x => x.Parcelas == 12).Detalhes;
            }
            else if (proposta24RadioButton.Checked)
            {
                detalhesLabel.Text = _propostas.FirstOrDefault(x => x.Parcelas == 24).Detalhes;
            }
            else if (proposta36RadioButton.Checked)
            {
                detalhesLabel.Text = _propostas.FirstOrDefault(x => x.Parcelas == 36).Detalhes;
            }
            else
            {
                detalhesLabel.Text = string.Empty;
            }

            detalhesLabel.Visible = detalhesLabel.Text.Length > 0;
            contratarButton.Enabled = detalhesLabel.Visible;
        }

        private void contratarButton_Click(object sender, EventArgs e)
        {
            var mensagemContratacao = $"Você selecionou a seguinte proposta:\n\n{detalhesLabel.Text[4..].Replace(" | ", "\n")}\n\nDeseja realizar a contratação?";

            if (MessageBox.Show(mensagemContratacao, "Confirmação de Contratação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Contratação efetuada com sucesso!", "Contratado!");
            }
            else
            {
                MessageBox.Show("Contratação recusada.\nFavor reiniciar o processo.", "Recusado!");
            }

            ReiniciarProcesso();
        }
    }
}
