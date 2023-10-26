import { Component } from '@angular/core';
import { CreatePensamentoDto } from 'src/app/core/types/create-pensamento-dto';

@Component({
  selector: 'app-criar-pensamento',
  templateUrl: './criar-pensamento.component.html',
  styleUrls: ['./criar-pensamento.component.css']
})
export class CriarPensamentoComponent {
  pensamento: CreatePensamentoDto = {
    conteudo: '',
    autoria: '',
    modelo: 'modelo1'
  }

  criarPensamento(): void {
    alert("Novo pensamento")
  }

  cancelarPensamento(): void {
    alert("Cancelar")
  }
}
