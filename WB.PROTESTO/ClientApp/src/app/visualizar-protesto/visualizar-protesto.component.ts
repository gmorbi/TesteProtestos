import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-visualizar-protesto',
  templateUrl: './visualizar-protesto.component.html'
})
export class VisualizarProtesto {
  public protestos: VisualizarProtestos[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<VisualizarProtestos[]>(baseUrl + '/api/protesto').subscribe(result => {
      this.protestos = result;
    }, error => console.error(error));
  }
}

interface VisualizarProtestos {
  Bairro_Devedor: string;
  CEP_Devedor: string;
  CPF_CNPJ_Devedor: string;
  Cidade_Devedor: string;
  Cidade_Praca_Pagamento: string;
  CodigoBanco: string;
  CodigoInterno: string;
  DataEmissao: string;
  DataVencimento: string;
  Endereco_Devedor: string;
  NomeCredor: string;
  NomeDevedor: string;
  NumeroTitulo: string;
  Operacao: string;
  Parcela: string;
  ProtestoID: string;
  QtdeParcelaContrato: string;
  TipoDocumento: string;
  UF_Devedor: string;
  UF_Praca_Pagamento: string;
  Valor1aParcela: string;
  ValorProtestar: string;
  ValorTitulo: string;
}
