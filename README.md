# Gerenciador de Livros

Este é um projeto WEB desenvolvido com **Angular** e **.NET**, que contém um CRUD para gerenciar livros.

Neste projeto é possível **visualizar**, **cadastrar**, **atualizar** e **deletar** informações de livros.

## Estrutura

Cada livro contém os seguintes atributos:
```js
    {
        id: number,
        titulo: string,
        autor: string,
        genero: string,
        ano: number
    }
```

## Tecnologias que Foram Utilizadas

- Angular 19
- Bootstrap 5
- HTML, TypeScript, CSS
- C#, .NET Core 8, Entity Framework

## Instruções para Iniciar o Projeto

### Instalações Necessárias

- VSCode - https://code.visualstudio.com/Download
- Visual Studio - https://visualstudio.microsoft.com/pt-br/downloads/
- Node - https://nodejs.org/pt/download

Baixe o repositório completo em sua máquina

### Frontend

1. Abra a pasta /GerenciadorLivrosFrontEnd no seu VSCode
2. ~~Adicione a variável de ambiente "" em /environments/environments.ts~~ (como o projeto está rodando localmente, a variável da url da api está inclusa)
3. Rode o comando ```ng serve```
4. Abra o navegar em http://localhost:4200
5. **Pronto!** O frontend está rodando

### Backend

1. Execute o arquivo /GerenciadorLivrosBackend/GerenciadorLivrosBackend.sln ou abra a pasta no seu Visual Studio
2. Inicie a aplicação
3. Para conferir se está funcionando, navegue em  https://localhost:7159/swagger/index.html, uma lista dos endpoints deverá ser exibido
4. **Tudo Pronto!** O backend está no ar

Basta voltar ao frontend e realizar as operações!

