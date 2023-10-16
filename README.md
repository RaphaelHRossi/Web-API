# EFAPI
## Descri��o do Projeto
Este projeto � uma aplica��o desenvolvida utilizando Angular e ASP.NET Core, visando fornecer uma plataforma para gerenciamento de departamentos e funcion�rios em uma empresa. A aplica��o permite a cria��o, edi��o, exclus�o e listagem de departamentos e seus respectivos funcion�rios. O objetivo principal � demonstrar o uso pr�tico das tecnologias Angular e ASP.NET Core em um ambiente de desenvolvimento de aplicativos web.

## Tecnologias Utilizadas
* ASP.NET Core
* Entity Framework Core
* SQL Server

## Testando as Funcionalidades da API
### Endpoints Dispon�veis

M�todo: GET Listar Departamentos

Endpoint: https://localhost:porta/api/departamento

M�todo: GET Obter Departamento por ID:
Endpoint: https://localhost:porta/api/departamento/{id}

M�todo: POST Criar Novo Departamento

Endpoint: https://localhost:porta/api/departamento
Payload:
{
  "nome": "Nome do Departamento",
  "sigla": "SIG"
}

M�todo: PUT Editar Departamento por ID

Endpoint: https://localhost:porta/api/departamento/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "sigla": "NN"
}

M�todo: DELETE Excluir Departamento por ID

Endpoint: https://localhost:porta/api/departamento/{id}

M�todo: GET Listar Funcion�rios de um Departamento

Endpoint: https://localhost:porta/api/departamento/{id}/funcionarios

M�todo: GET Obter Funcion�rio por ID

Endpoint: https://localhost:porta/api/funcionario/{id}

M�todo: POST Criar Novo Funcion�rio

Endpoint: https://localhost:porta/api/funcionario
Payload:
{
  "nome": "Nome do Funcion�rio",
  "foto": "url_da_foto",
  "rg": "123456",
  "departamentoId": 1
}

M�todo: PUT Editar Funcion�rio por ID

Endpoint: https://localhost:porta/api/funcionario/{id}
Payload:
{
  "id": 1,
  "nome": "Novo Nome",
  "foto": "nova_url_da_foto",
  "rg": "654321",
  "departamentoId": 1
}

M�todo: DELETE Excluir Funcion�rio por ID

Endpoint: https://localhost:porta/api/funcionario/{id}