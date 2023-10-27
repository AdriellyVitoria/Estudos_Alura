import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PensamentoService } from 'src/app/core/services/pensamento.service';
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

  constructor(
    private service: PensamentoService,
    private router: Router 
  ) { }

  criarPensamento(): void {
    this.service.criar(this.pensamento).subscribe(() => {
      this.router.navigate(['/'])
    })
  }

  cancelarPensamento() {
    this.router.navigate(['/'])
  }


}
