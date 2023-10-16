# EFAPI
## Descrição do Projeto
Este projeto é uma aplicação desenvolvida utilizando Angular e ASP.NET Core, visando fornecer uma plataforma para gerenciamento de departamentos e funcionários em uma empresa. A aplicação permite a criação, edição, exclusão e listagem de departamentos e seus respectivos funcionários. O objetivo principal é demonstrar o uso prático das tecnologias Angular e ASP.NET Core em um ambiente de desenvolvimento de aplicativos web.

## Tecnologias Utilizadas
* ASP.NET Core
* Entity Framework Core
* SQL Server

## Testando as Funcionalidades da API
### Endpoints Disponíveis

Método: GET Listar Departamentos

Endpoint: https://localhost:porta/api/departamento

Método: GET Obter Departamento por ID:
Endpoint: https://localhost:porta/api/departamento/{id}

Método: POST Criar Novo Departamento

Endpoint: https://localhost:porta/api/departamento
Payload:
{
  "nome": "Nome do Departamento",
  "sigla": "SIG"
}

Método: PUT Editar Departamento por ID

Endpoint: https://localhost:porta/api/departamento/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "sigla": "NN"
}

Método: DELETE Excluir Departamento por ID

Endpoint: https://localhost:porta/api/departamento/{id}

Método: GET Listar Funcionários de um Departamento

Endpoint: https://localhost:porta/api/departamento/{id}/funcionarios

Método: GET Obter Funcionário por ID

Endpoint: https://localhost:porta/api/funcionario/{id}

Método: POST Criar Novo Funcionário

Endpoint: https://localhost:porta/api/funcionario
Payload:
{
  "nome": "Nome do Funcionário",
  "foto": "url_da_foto",
  "rg": "123456",
  "departamentoId": 1
}

Método: PUT Editar Funcionário por ID

Endpoint: https://localhost:porta/api/funcionario/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "foto": "nova_url_da_foto",
  "rg": "654321",
  "departamentoId": 1
}

Método: DELETE Excluir Funcionário por ID

Endpoint: https://localhost:porta/api/funcionario/{id}