import { PensamentoService } from 'src/app/core/services/pensamento.service';
import { Pensamento } from './../../../core/types/pensamento';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-excluir-pensamento',
  templateUrl: './excluir-pensamento.component.html',
  styleUrls: ['./excluir-pensamento.component.css']
})
export class ExcluirPensamentoComponent implements OnInit {
  pensamento: Pensamento = {
    id: '',
    conteudo: '',
    autoria: '',
    modelo: ''
  }

  constructor(
    private service: PensamentoService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id')
    this.service.buscarPorId(id!).subscribe(pensamento => {
      this.pensamento = pensamento
    })
  }

  excluirPensamento() {
    this.service.excluir(this.pensamento.id).subscribe(() => {
      this.router.navigate(['/'])
    })
  }

  cancelarPensamento() {
    this.router.navigate(['/'])
  }
}
