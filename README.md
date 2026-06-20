# Sistema Acadêmico - ASP.NET Core MVC

## Descrição

Sistema acadêmico desenvolvido em ASP.NET Core MVC utilizando Entity Framework Core e SQL Server LocalDB.

O projeto permite o gerenciamento de alunos, instituições e departamentos através de operações CRUD (Create, Read, Update e Delete).

## Tecnologias Utilizadas

* ASP.NET Core MVC
* Entity Framework Core
* SQL Server LocalDB
* C#
* Bootstrap

## Funcionalidades

### Alunos

* Cadastrar aluno
* Consultar aluno
* Editar aluno
* Excluir aluno

### Instituições

* Cadastrar instituição
* Consultar instituição
* Editar instituição
* Excluir instituição

### Departamentos

* Cadastrar departamento
* Consultar departamento
* Editar departamento
* Excluir departamento

## Banco de Dados

O banco de dados é criado através do Entity Framework Core utilizando Migrations.

Relacionamento implementado:

Instituição (1) → (N) Departamentos

## Estrutura do Projeto

* Controllers
* Models
* Views
* Data
* Migrations
* Repositories

## Autor

Artur Sant Anna das Chagas

## Curso

Análise e Desenvolvimento de Sistemas - UniFOA
