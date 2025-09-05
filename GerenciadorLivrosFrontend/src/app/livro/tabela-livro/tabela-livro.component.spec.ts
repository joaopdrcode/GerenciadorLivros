import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabelaLivroComponent } from './tabela-livro.component';

describe('TabelaLivroComponent', () => {
  let component: TabelaLivroComponent;
  let fixture: ComponentFixture<TabelaLivroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TabelaLivroComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabelaLivroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
