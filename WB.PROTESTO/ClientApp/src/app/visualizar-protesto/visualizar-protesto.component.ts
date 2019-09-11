import { Component, Inject, ViewChild, HostListener } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CATCH_ERROR_VAR } from '@angular/compiler/src/output/abstract_emitter';

@Component({
  selector: 'app-visualizar-protesto',
  templateUrl: './visualizar-protesto.component.html'
})
export class VisualizarProtesto {
  public protestos: VisualizarProtestos[];
  apiURL = "http://localhost:60793/";

  constructor(http: HttpClient) {
    http.get<VisualizarProtestos[]>(this.apiURL + 'api/protesto').subscribe(result => {
      this.protestos = result;
    }, error => console.error(error));
  }
}

interface VisualizarProtestos {
  cpF_CNPJ_Devedor: string;
  codigoInterno: string;
  nomeDevedor: string;
  numeroTitulo: string;
  valorTitulo: string;
}
