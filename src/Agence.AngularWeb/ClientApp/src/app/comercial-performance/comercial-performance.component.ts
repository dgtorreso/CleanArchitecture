import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { NgForm } from '@angular/forms';
import { Chart } from 'chart.js';

@Component({
  selector: 'app-comercial-performance',
  templateUrl: './comercial-performance.component.html',
  styleUrls: ['./comercial-performance.css']
})
export class ComercialPerformanceComponent implements OnInit {
  public ContactModel: BusquedaForm = new BusquedaForm();
  public gananciaConsultores: GananciasPorConsultor[];
  public puedeMostrarClientes: boolean;
  public obteniendoDatos: boolean;
  public verBarras: boolean;
  public verTorta: boolean;
  public verTabla: boolean;
  public listaClientes: Cliente[];
  public listaClientesSel: Cliente[];
  public clientes: Cliente[] = [];
  public clientesSel: Cliente[];
  public listaConsultores: Consultor[];
  public listaConsultoresSel: Consultor[];
  public consultores: Consultor[] = [];
  public consultoresSel: Consultor[];
  public http: HttpClient;
  public baseUrl: string;
  public chart: Chart = null;
  public torta: Chart = null;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    this.puedeMostrarClientes = false;
    this.obteniendoDatos = true;

    http.get<Consultor[]>(baseUrl + 'api/ComercialPerformance/ObtenerConsultores').subscribe(result => {
      this.listaConsultores = result;
      this.obteniendoDatos = false;
    }, error => console.error(error));

    http.get<Cliente[]>(baseUrl + 'api/ComercialPerformance/ObtenerClientes').subscribe(result => {
      this.listaClientes = result;
      this.obteniendoDatos = false;
    }, error => console.error(error));
  }
  public mostrarClientes($event: any) {
    $event.preventDefault();

    
    
  }

  public mostrarConsultores($event: any) {
    $event.preventDefault();
    this.puedeMostrarClientes = false;
  }

  public agregarClientes($event: any) {
    $event.preventDefault();
    if (this.listaClientesSel) {
      this.listaClientesSel.forEach((el) => {
        if (this.clientes.filter(old => old.id == el.id).length == 0) {
          this.clientes.push(el);
        }
      });
    }
  }

  public quitarClientes($event: any) {
    $event.preventDefault();
    if (this.clientesSel) {
      this.clientesSel.forEach((el) => {
        var search = this.clientes.filter(old => old.id == el.id);
        if (search.length > 0) {
          this.clientes.splice(this.clientes.indexOf(search[0]));
        }
      });
    }
  }
  public agregarConsultores($event: any) {
    $event.preventDefault();
    if (this.listaConsultoresSel) {
      this.listaConsultoresSel.forEach((el) => {
        if (this.consultores.filter(old => old.id == el.id).length == 0) {
          this.consultores.push(el);
        }
      });
    }
  }

  public quitarConsultores($event: any) {
    $event.preventDefault();
    if (this.consultoresSel) {
      this.consultoresSel.forEach((el) => {
        var search = this.consultores.filter(old => old.id == el.id);
        if (search.length > 0) {
          this.consultores.splice(this.consultores.indexOf(search[0]));
        }
      });
    }
  }

  ngOnInit() {
  }

  public onSubmit(f: NgForm) {
    let params = new HttpParams()
      .set('DesdeMes', this.ContactModel.desdeMes.toString())
      .set('DesdeAnio', this.ContactModel.desdeAnio.toString())
      .set('HastaMes', this.ContactModel.hastaMes.toString())
      .set('HastaAnio', this.ContactModel.hastaAnio.toString());
    this.consultores.forEach(a => params = params.append('consultorIds', a.id));
    console.log(params.toString());
    this.http.get<GananciasPorConsultor[]>(this.baseUrl + 'api/ComercialPerformance/ObtenerGananciasPorConsultor', { params: params }).subscribe(result => {
      this.verBarras = false;
      this.verTorta = false;
      this.verTabla = true;
      this.gananciaConsultores = result;
    }, error => console.error(error));
  }

  public mostrarBarras($event: any) {
    $event.preventDefault();
    this.verBarras = true;
    this.verTorta = false;
    this.verTabla = false;
    let params = new HttpParams()
      .set('DesdeMes', this.ContactModel.desdeMes.toString())
      .set('DesdeAnio', this.ContactModel.desdeAnio.toString())
      .set('HastaMes', this.ContactModel.hastaMes.toString())
      .set('HastaAnio', this.ContactModel.hastaAnio.toString());
    this.consultores.forEach(a => params = params.append('consultorIds', a.id));
    console.log(params.toString());
    this.http.get<any>(this.baseUrl + 'api/ComercialPerformance/ObtenerGananciasPorConsultorBar', { params: params }).subscribe(result => {
      
      var chartOptions = {
        responsive: true,
        legend: {
          position: "top"
        },
        title: {
          display: true,
        },
        scales: {
          yAxes: [{
            ticks: {
              beginAtZero: true
            }
          }]
        }
      }
      if(this.chart == null){
        this.chart = new Chart('canvas', {
          type: "bar",
          data: result,
          options: chartOptions
        });
      }else{
        this.chart.data = result;
        this.chart.update();
      }
    }, error => console.error(error));
  }

  public mostrarTorta($event: any) {
    $event.preventDefault();
    this.verBarras = false;
    this.verTorta = true;
    this.verTabla = false;
    
    let params = new HttpParams()
      .set('DesdeMes', this.ContactModel.desdeMes.toString())
      .set('DesdeAnio', this.ContactModel.desdeAnio.toString())
      .set('HastaMes', this.ContactModel.hastaMes.toString())
      .set('HastaAnio', this.ContactModel.hastaAnio.toString());
    this.consultores.forEach(a => params = params.append('consultorIds', a.id));
    console.log(params.toString());
    this.http.get<any>(this.baseUrl + 'api/ComercialPerformance/ObtenerGananciasPorConsultorTorta', { params: params }).subscribe(result => {
      if(this.torta == null){
    var config = {
      type: 'doughnut',
      data: result,
      options: {
        showTooltips: false,
        responsive: true,
        legend: {
          position: 'top',
        },
        title: {
          display: false,
          text: 'Chart.js Doughnut Chart'
        },
        animation: {
          animateScale: true,
          animateRotate: true
        },
        tooltips: {
          callbacks: {
            label: function(tooltipItem, data) {
              var dataset = data.datasets[tooltipItem.datasetIndex];
              var total = dataset.data.reduce(function(previousValue, currentValue, currentIndex, array) {
                return previousValue + currentValue;
              });
              var currentValue = dataset.data[tooltipItem.index];
              var precentage = Math.floor(((currentValue/total) * 100)+0.5);         
              return precentage + "%";
            }
          }
        }
      }
    };
    this.torta = new Chart('torta-canvas', config);
  }else{
    this.torta.data = result;
    this.torta.update();
  }
  }, error => console.error(error));
}

}

interface GananciasPorConsultor {
  consultorId: number;
  nombre: string;
  detalle: GananciasPorConsultorDetalle[];
}

interface GananciasPorConsultorDetalle {
  receitaLiquida: number;
  comision: number;
  salario: number;
  lucro: number;
  anio: number;
  mes: number;
}
class BusquedaForm {
  public desdeMes: number = 1;
  public desdeAnio: number = 2005;
  public hastaMes: number = 12;
  public hastaAnio: number = 2007;
  public clientes: Cliente[];
}
interface Cliente {
  id: number;
  descripcion: string;
}
interface Consultor {
  id: string;
  nombre: string;
}
