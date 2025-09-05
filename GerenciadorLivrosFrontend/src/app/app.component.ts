import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TabelaLivroComponent } from './livro/tabela-livro/tabela-livro.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [TabelaLivroComponent],
  template: `<app-tabela-livro></app-tabela-livro>`
})
export class AppComponent {
  title = 'GerenciadorLivrosFrontend';
}
