import { Pensamento } from 'src/app/core/types/pensamento';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreatePensamentoDto } from '../types/create-pensamento-dto';

@Injectable({
  providedIn: 'root'
})
export class PensamentoService {
  
  private readonly apiUrl = environment.apiUrl

  constructor(
    private http: HttpClient
  ) { }

  listar(): Observable<Pensamento[]> {
    return this.http.get<Pensamento[]>(this.apiUrl)
  }

  criar(pensamento: CreatePensamentoDto): Observable<Pensamento> {
    return this.http.post<Pensamento>(this.apiUrl, pensamento)
  }

  excluir(id: string): Observable<Pensamento> {
    return this.http.delete<Pensamento>(`${this.apiUrl}/${id}`)
  }

  buscarPorId(id: string): Observable<Pensamento> {
    return this.http.get<Pensamento>(`${this.apiUrl}/${id}`)
  }
}
