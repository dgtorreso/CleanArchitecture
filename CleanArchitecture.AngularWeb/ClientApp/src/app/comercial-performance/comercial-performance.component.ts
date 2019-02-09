import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-comercial-performance',
  templateUrl: './comercial-performance.component.html'
})
export class ComercialPerformanceComponent {
  public atividades: Atividade[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Atividade[]>(baseUrl + 'api/ComercialPerformance/GetAtividades').subscribe(result => {
      console.log(result);
      this.atividades = result;
    }, error => console.error(error));
  }
}

interface Atividade {
  co_atividade: number;
  ds_atividade: string;
  co_tipo_usuario: number;
}
