# EFAPI
## Descri��o do Projeto
Este projeto � uma aplica��o desenvolvida utilizando Angular e ASP.NET Core, visando fornecer uma plataforma para gerenciamento de departamentos e funcion�rios em uma empresa. A aplica��o permite a cria��o, edi��o, exclus�o e listagem de departamentos e seus respectivos funcion�rios. O objetivo principal � demonstrar o uso pr�tico das tecnologias Angular e ASP.NET Core em um ambiente de desenvolvimento de aplicativos web.

## Tecnologias Utilizadas
* ASP.NET Core
* Entity Framework Core
* SQL Server

## Testando as Funcionalidades da API
### Endpoints Dispon�veis

Listar Departamentos:

M�todo: GET
Endpoint: https://localhost:porta/api/departamento
Obter Departamento por ID:

M�todo: GET
Endpoint: https://localhost:porta/api/departamento/{id}
Criar Novo Departamento:

M�todo: POST
Endpoint: https://localhost:porta/api/departamento
Payload:
{
  "nome": "Nome do Departamento",
  "sigla": "SIG"
}

Editar Departamento por ID:

M�todo: PUT
Endpoint: https://localhost:porta/api/departamento/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "sigla": "NN"
}

Excluir Departamento por ID:

M�todo: DELETE
Endpoint: https://localhost:porta/api/departamento/{id}
Listar Funcion�rios de um Departamento:

M�todo: GET
Endpoint: https://localhost:porta/api/departamento/{id}/funcionarios
Obter Funcion�rio por ID:

M�todo: GET
Endpoint: https://localhost:porta/api/funcionario/{id}
Criar Novo Funcion�rio:

M�todo: POST
Endpoint: https://localhost:porta/api/funcionario
Payload:
{
  "nome": "Nome do Funcion�rio",
  "foto": "url_da_foto",
  "rg": "123456",
  "departamentoId": 1
}

Editar Funcion�rio por ID:

M�todo: PUT
Endpoint: https://localhost:porta/api/funcionario/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "foto": "nova_url_da_foto",
  "rg": "654321",
  "departamentoId": 1
}

Excluir Funcion�rio por ID:

M�todo: DELETE
Endpoint: https://localhost:porta/api/funcionario/{id}