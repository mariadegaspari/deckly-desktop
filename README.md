# Deckly — Sistema Desktop

O Deckly Desktop é a versão desktop do projeto Deckly, desenvolvido em C# com Windows Forms.

## Funcionalidades

* Gerenciamento de produtos, categorias e marcas.
* Gerenciamento de clientes.
* Gerenciamento de funcionários e cargos.
* Fluxo de vendas, com atualização de estoque.
* Relatórios do sistema, com filtros.
* Acesso a todas as funcionalidades por meio de uma interface desktop.

## Tecnologias utilizadas

* C#
* Windows Forms
* MySQL
* Visual Studio

## Telas

<img width="1919" height="1079" alt="Captura de tela 2026-10-23 114314" src="https://github.com/user-attachments/assets/cc21fa85-3623-482c-8554-6ce6470d0896" />


## Banco de dados

O sistema utiliza o banco de dados do projeto Deckly (veja o SQL na pasta `database` da [versão web](https://github.com/mariadegaspari/deckly-web)). Configure a conexão com o banco de dados no ambiente local antes de executar a aplicação.

## Como executar

1. Abra o arquivo `SistemaDeckly.sln` no Visual Studio.
2. Restaure os pacotes necessários.
3. Configure a conexão com o banco de dados.
4. Compile e execute o projeto.
5. É de extrema importância que antes de executar o sistema desktop, já se tenha colocado o sistema web no caminho correto(xampp/htdocs/INFO_53/Deckly/) para que o upload de fotos de produtos esteja funcionando no desktop.

## Observação

Este projeto faz parte do ecossistema Deckly, que também possui uma [versão web](https://github.com/mariadegaspari/deckly-web).
