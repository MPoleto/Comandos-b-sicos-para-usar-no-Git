# 🧾 API de Cadastro

A plataforma DIO em parceria com a Pottencial Insurtech realizaram o evento online **Pottencial Dev Week**, no qual foi desenvolvido este projeto: uma API REST em .NET para cadastro de pessoas (clientes) e seus respectivos contratos.

## Tecnologias

- .NET 6
- Entity Framework Core 6
- Banco de dados em memória do EF Core 6
- Swagger

## Desenvolvimento

### Durante o evento foi desenvolvido a estrutura funcional do projeto:  
  
- `Models` - as classes que servem de modelo para a criação das tabelas no banco de dados
- `Context`- a classe que representa o banco de dados
- `Controller` - a classe com os métodos de ação, que servem como *endpoints* para as requisições HTTP
- Configuração da conexão com o banco de dados em memória

### Após o evento fiz as seguintes modificações:  
  
- `Repository` - adicionei a classe para lidar com o acesso ao banco de dados
- `Service` - adicionei a classe para lidar com as regras de negócio  
- `Controller` - editei a classe para se adequar às classes `Repository` e `Service`
  - Em cada método de ação: acrescentei atributos para especificar os códigos de status HTTP e comentários xml para melhorar a documentação da API
