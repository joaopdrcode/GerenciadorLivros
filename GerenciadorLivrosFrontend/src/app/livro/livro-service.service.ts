import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Livro {
  status: boolean,
  mensagem: string,
  dados: []
}

@Injectable({
  providedIn: 'root'
})
export class LivroServiceService {
  private api = "https://localhost:7159/api/livros"
  constructor(private http: HttpClient) { }

  getLivros(): Observable<Livro[]> {
    return this.http.get<Livro[]>(this.api);
  }

  addLivro(livro: Omit<Livro, 'id'>): Observable<Livro> {
    return this.http.post<Livro>(this.api, livro);
  }

  updateLivro(livro: Livro, id: any): Observable<Livro> {
    return this.http.put<Livro>(this.api+"/"+id, livro);
  }

  deleteLivro(id: number): Observable<void> {
    return this.http.delete<void>(this.api+"/"+id);
  }
}
