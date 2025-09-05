import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Livro } from '../livro-service.service';
import { ReactiveFormsModule, FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-formulario-livro',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './formulario-livro.component.html',
  styleUrl: './formulario-livro.component.css'
})
export class FormularioLivroComponent {
  @Input() livro: Livro | null = null;
  @Output() grava = new EventEmitter<Livro | Omit<Livro, 'id'>>();
  @Output() cancela = new EventEmitter<void>();

  body: any = {id: "", titulo: "", autor: "", genero: "", ano: 0}

  dadosForm = new FormGroup({
    id: new FormControl(''),
    titulo: new FormControl('', [Validators.required]),
    autor: new FormControl('', [Validators.required]),
    genero: new FormControl('', [Validators.required]),
    ano: new FormControl('', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1800), Validators.max(2025)])
  })

  ngOnChanges() {
    debugger
    if(this.livro){
      var auxiliarLivro : any;
      auxiliarLivro = this.livro;
      this.dadosForm.setValue({id: auxiliarLivro.id, ano: auxiliarLivro.ano, genero: auxiliarLivro.genero, autor: auxiliarLivro.autor, titulo: auxiliarLivro.titulo})
    } else{
      this.body = {titulo: "", autor: "", genero: "", ano: 0};
    }
  }

  onSubmit() {
    debugger
    if(this.dadosForm.valid){
      this.body = this.dadosForm.value;
      this.grava.emit(this.body);
    }else{
      this.dadosForm.markAllAsTouched();
    }
  }
}
