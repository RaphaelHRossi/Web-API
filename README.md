# EFAPI
## Descrição do Projeto
Este projeto é uma aplicação desenvolvida utilizando Angular e ASP.NET Core, visando fornecer uma plataforma para gerenciamento de departamentos e funcionários em uma empresa. A aplicação permite a criação, edição, exclusão e listagem de departamentos e seus respectivos funcionários. O objetivo principal é demonstrar o uso prático das tecnologias Angular e ASP.NET Core em um ambiente de desenvolvimento de aplicativos web.

## Tecnologias Utilizadas
* ASP.NET Core
* Entity Framework Core
* SQL Server

## Testando as Funcionalidades da API
### Endpoints Disponíveis

Listar Departamentos:

Método: GET
Endpoint: https://localhost:porta/api/departamento
Obter Departamento por ID:

Método: GET
Endpoint: https://localhost:porta/api/departamento/{id}
Criar Novo Departamento:

Método: POST
Endpoint: https://localhost:porta/api/departamento
Payload:
{
  "nome": "Nome do Departamento",
  "sigla": "SIG"
}

Editar Departamento por ID:

Método: PUT
Endpoint: https://localhost:porta/api/departamento/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "sigla": "NN"
}

Excluir Departamento por ID:

Método: DELETE
Endpoint: https://localhost:porta/api/departamento/{id}
Listar Funcionários de um Departamento:

Método: GET
Endpoint: https://localhost:porta/api/departamento/{id}/funcionarios
Obter Funcionário por ID:

Método: GET
Endpoint: https://localhost:porta/api/funcionario/{id}
Criar Novo Funcionário:

Método: POST
Endpoint: https://localhost:porta/api/funcionario
Payload:
{
  "nome": "Nome do Funcionário",
  "foto": "url_da_foto",
  "rg": "123456",
  "departamentoId": 1
}

Editar Funcionário por ID:

Método: PUT
Endpoint: https://localhost:porta/api/funcionario/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "foto": "nova_url_da_foto",
  "rg": "654321",
  "departamentoId": 1
}

Excluir Funcionário por ID:

Método: DELETE
Endpoint: https://localhost:porta/api/funcionario/{id}