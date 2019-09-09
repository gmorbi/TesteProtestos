using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WF.PROTESTO.Models
{
    public class Protesto
    {
        public int ProtestoID { get; set; }
        public string CodigoBanco { get; set; }
        public string CodigoInterno { get; set; }
        public string NomeCredor { get; set; }
        public string NumeroTitulo { get; set; }
        public string Parcela { get; set; }
        public string NomeDevedor { get; set; }
        public string CPF_CNPJ_Devedor { get; set; }
        public string Endereco_Devedor { get; set; }
        public string Bairro_Devedor { get; set; }
        public string Cidade_Devedor { get; set; }
        public string CEP_Devedor { get; set; }
        public string UF_Devedor { get; set; }
        public string Cidade_Praca_Pagamento { get; set; }
        public string UF_Praca_Pagamento { get; set; }
        public  string  ValorTitulo { get; set; }
        public  string  ValorProtestar { get; set; }
        public  string  DataEmissao { get; set; }
        public  string  DataVencimento { get; set; }
        public string TipoDocumento { get; set; }
        public string Operacao { get; set; }
        public  string  Valor1aParcela { get; set; }
        public  string  QtdeParcelaContrato { get; set; }
    }
}
