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

  constructor(
    private readonly service: PensamentoService
  ) {}


  ngOnInit(): void {
    this.service.listar().subscribe(lista => {
      this.listaPensamento = lista
    })
  }
}
