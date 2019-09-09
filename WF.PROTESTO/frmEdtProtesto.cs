using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF.PROTESTO.Models;

namespace WF.PROTESTO
{
    public partial class frmEdtProtesto : Form
    {
        frmProtestos _frmProtestos;
        public int idProtesto;
        Protesto protesto = new Protesto();

        public frmEdtProtesto()
        {
            InitializeComponent();
        }

        public frmEdtProtesto(frmProtestos frmProtestos)
        {
            _frmProtestos = frmProtestos;
            InitializeComponent();
        }

        private void frmEdtProtesto_Load(object sender, EventArgs e)
        {
            string url = System.Configuration.ConfigurationSettings.AppSettings["urlApi"];
            string endpoint = System.Configuration.ConfigurationSettings.AppSettings["endpointProtesto"];
            string jsonReturnProtestos;
            HttpResponseMessage retorno;

            retorno = ApiClient.RetornarProtestoById(url + endpoint + '/', idProtesto);

            jsonReturnProtestos = retorno.Content.ReadAsStringAsync().Result;

            if (jsonReturnProtestos != null)
            {
                protesto = JsonConvert.DeserializeObject<Protesto>(jsonReturnProtestos);

                carregaCampos(protesto);
            }
        }

        private void carregaCampos(Protesto protesto)
        {
            txtCodBanco.Text = protesto.CodigoBanco;
            txtBairro.Text = protesto.Bairro_Devedor;
            txtCep.Text = protesto.CEP_Devedor;
            txtCidade.Text = protesto.Cidade_Devedor;
            txtCidadePraca.Text = protesto.Cidade_Praca_Pagamento;
            txtCodInt.Text = protesto.CodigoInterno;
            txtCpfCnpj.Text = protesto.CPF_CNPJ_Devedor;
            txtDataEmissao.Text = protesto.DataEmissao;
            txtDataVenc.Text = protesto.DataVencimento;
            txtEndereco.Text = protesto.Endereco_Devedor;
            txtNomeCredor.Text = protesto.NomeCredor;
            txtNomeDevedor.Text = protesto.NomeDevedor;
            txtNtoTitulo.Text = protesto.NumeroTitulo;
            txtOperacao.Text = protesto.Operacao;
            txtParcela.Text = protesto.Parcela;
            txtQtdeParcela.Text = protesto.QtdeParcelaContrato;
            txtTipoDoc.Text = protesto.TipoDocumento;
            txtUf.Text = protesto.UF_Devedor;
            txtUfPraca.Text = protesto.UF_Praca_Pagamento;
            txtValor1aPercela.Text = protesto.Valor1aParcela;
            txtValorProtestar.Text = protesto.ValorProtestar;
            txtValorTitulo.Text = protesto.ValorTitulo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            HttpResponseMessage retorno;
            string url = System.Configuration.ConfigurationSettings.AppSettings["urlApi"];
            string endpoint = System.Configuration.ConfigurationSettings.AppSettings["endpointProtesto"];
            string returnProtestos;

            protesto.CodigoBanco = txtCodBanco.Text;
            protesto.Bairro_Devedor = txtBairro.Text;
            protesto.CEP_Devedor = txtCep.Text;
            protesto.Cidade_Devedor = txtCidade.Text;
            protesto.Cidade_Praca_Pagamento = txtCidadePraca.Text;
            protesto.CodigoInterno = txtCodInt.Text;
            protesto.CPF_CNPJ_Devedor = txtCpfCnpj.Text;
            protesto.DataEmissao = txtDataEmissao.Text;
            protesto.DataVencimento = txtDataVenc.Text;
            protesto.Endereco_Devedor = txtEndereco.Text;
            protesto.NomeCredor = txtNomeCredor.Text;
            protesto.NomeDevedor = txtNomeDevedor.Text;
            protesto.NumeroTitulo = txtNtoTitulo.Text;
            protesto.Operacao = txtOperacao.Text;
            protesto.Parcela = txtParcela.Text;
            protesto.QtdeParcelaContrato = txtQtdeParcela.Text;
            protesto.TipoDocumento = txtTipoDoc.Text;
            protesto.UF_Devedor = txtUf.Text;
            protesto.UF_Praca_Pagamento = txtUfPraca.Text;
            protesto.Valor1aParcela = txtValor1aPercela.Text;
            protesto.ValorProtestar = txtValorProtestar.Text;
            protesto.ValorTitulo = txtValorTitulo.Text;

            retorno = ApiClient.SalvarProtesto(url + endpoint, protesto);
            
            returnProtestos = retorno.Content.ReadAsStringAsync().Result;

            if (retorno.IsSuccessStatusCode)
            {
                MessageBox.Show("Protesto atualizado!");
                this.Close();
                _frmProtestos.RefreshForm();
            }
            else
            {
                MessageBox.Show("Erro ao salvar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
