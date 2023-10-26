import { Component } from '@angular/core';
import { Pensamento } from 'src/app/core/types/pensamento';

@Component({
  selector: 'app-listar-pensamento',
  templateUrl: './listar-pensamento.component.html',
  styleUrls: ['./listar-pensamento.component.css']
})
export class ListarPensamentoComponent {
  listaPensamento: Pensamento[] = [
    {
      conteudo: 'Passo informaçoes para o componentes filhos',
      autoria: 'Pai',
      modelo: "modelo3",
      id: '3'
    },
    {
      conteudo: 'Mussum Ipsum, cacilds vidis litro abertis. Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi. Diuretics paradis num copo é motivis de denguis. Atirei o pau no gatis, per gatis num morreus. Interessantiss quisso pudia ce receita de bolis, mais bolis eu num gostis. Sapien in monti palavris qui num significa nadis i pareci latim',
      autoria: 'Lorem',
      modelo: "modelo1",
      id: '3'
    },
    {
      conteudo: 'Minha propriedade é decorada com @Input()',
      autoria: 'Compomente filho',
      modelo: "modelo2",
      id: '3'
    }
  ]
}
