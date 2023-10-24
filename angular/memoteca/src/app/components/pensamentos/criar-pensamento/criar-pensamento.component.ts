import { Component } from '@angular/core';
import { Pensamento } from 'src/app/core/types/pensamento';

@Component({
  selector: 'app-criar-pensamento',
  templateUrl: './criar-pensamento.component.html',
  styleUrls: ['./criar-pensamento.component.css']
})
export class CriarPensamentoComponent {
  pensamento: Pensamento = {
    id: '1',
    conteudo: '',
    autoria: '',
    modelo: ''
  }
}
