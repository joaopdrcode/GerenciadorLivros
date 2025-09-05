import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LivroServiceService, Livro } from '../livro-service.service';
import { FormularioLivroComponent } from '../formulario-livro/formulario-livro.component';

@Component({
  selector: 'app-tabela-livro',
  standalone: true,
  imports: [CommonModule, FormularioLivroComponent],
  templateUrl: './tabela-livro.component.html',
  styleUrl: './tabela-livro.component.css'
})
export class TabelaLivroComponent {
  livros: Livro[] = [];
  livrosTabela: any = [];
  livroSelecionado: Livro | null = null;
  hiddenForm = true;

  constructor(private livroService: LivroServiceService){
    this.buscaLivros();
  }

  buscaLivros() {
    this.livroService.getLivros().subscribe(data => {
      this.livros = data;
      this.livrosTabela = this.livros;
    })
  }

  novoLivro() {
    this.livroSelecionado = null;
    this.hiddenForm = false;
  }

  editar(livro: Livro) {
    this.livroSelecionado = livro;
    this.hiddenForm = false;
  }

  excluir(id: number) {
    this.livroService.deleteLivro(id).subscribe(() => this.buscaLivros());
  }

  salvar(livro: Livro | Omit<Livro, 'id'>) {
    if('id' in livro){
      this.livroService.updateLivro(livro, livro.id).subscribe(() => {
        this.buscaLivros();
        this.hiddenForm = true;
      });
    }else {
      this.livroService.addLivro(livro).subscribe(() => {
        this.buscaLivros();
        this.hiddenForm = true;
      });
    }
  }

  cancelar(){
    this.hiddenForm = true;
  }

}
