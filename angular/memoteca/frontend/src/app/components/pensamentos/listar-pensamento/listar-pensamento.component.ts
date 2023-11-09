import { Component, OnInit } from '@angular/core';
import { PensamentoService } from 'src/app/core/services/pensamento.service';
import { Pensamento } from 'src/app/core/types/pensamento';

@Component({
  selector: 'app-listar-pensamento',
  templateUrl: './listar-pensamento.component.html',
  styleUrls: ['./listar-pensamento.component.css']
})
export class ListarPensamentoComponent implements OnInit {
  listaPensamento: Pensamento[] = [];
  paginaAtual: number = 1;
  haMaisPensamentos: boolean = true;
  filtro: string = ''

  constructor(
    private readonly service: PensamentoService
  ) {}


  ngOnInit(): void {
    this.service.listar(this.paginaAtual, this.filtro).subscribe(lista => {
      this.listaPensamento = lista
    })
  }

  carregarMaisPensamentos() {
    this.service.listar(++this.paginaAtual, this.filtro)
      .subscribe(listaPensamentos => {
        this.listaPensamento.push(...listaPensamentos);
        if(!listaPensamentos.length) {
          this.haMaisPensamentos = false
        }
      })
  }

  pesquisarPensamentos() {

    this.haMaisPensamentos = true;
    this.paginaAtual = 1;
    this.service.listar(this.paginaAtual, this.filtro)
      .subscribe(listaPensamentos => {
        this.listaPensamento = listaPensamentos
      })
  }
}
