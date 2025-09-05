import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Livro } from '../livro-service.service';

@Component({
  selector: 'app-formulario-livro',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './formulario-livro.component.html',
  styleUrl: './formulario-livro.component.css'
})
export class FormularioLivroComponent {
  @Input() livro: Livro | null = null;
  @Output() grava = new EventEmitter<Livro | Omit<Livro, 'id'>>();
  @Output() cancela = new EventEmitter<void>();

  body: any = {titulo: "", autor: "", genero: "", ano: 0}

  ngOnChanges() {
    if(this.livro){
      this.body = {...this.livro};
    } else{
      this.body = {titulo: "", autor: "", genero: "", ano: 0};
    }
  }

  onSubmit() {
    this.grava.emit(this.body);
  }
}
