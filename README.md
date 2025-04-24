___
# WebApiCantina


## :page_facing_up: Sobre o Projeto

Este projeto foi desenvolvido utilizando a linguagem de programação C# e a plataforma .NET para criar um backend robusto e seguro, adequado para a gestão de recursos de uma cantina. O frontend é desenvolvido em Angular, permitindo a construção de uma interface de usuário dinâmica e responsiva para a web. O desenvolvimento é feito utilizando o Visual Studio Code e Visual Studio, proporcionando um ambiente de desenvolvimento integrado (IDE) eficiente para programação em C# e Angular.

Para o armazenamento e gerenciamento dos dados, utiliza-se o banco de dados MySQL, que é adequado para a manutenção de informações de estoque, transações e usuários de forma segura e eficiente. O controle de versão do código é realizado com Git, e os repositórios são hospedados no GitHub, garantindo a colaboração entre desenvolvedores e o versionamento do projeto. Além disso, a ferramenta Miro é utilizada para a criação de diagramas e fluxos, facilitando a visualização dos processos de desenvolvimento e arquitetura do sistema.

___

## :open_file_folder: Estrutura do Projeto
```WebApiCantina.sln
│── /WebApiCantina.Api             -> API e Configuração
│── /WebApiCantina.Application     -> Casos de Uso, Handlers, Perfis do AutoMapper, Serviços e DTOs
│── /WebApiCantina.Domain          -> Entidades, VOs, Repositórios (somente interfaces) e Regras de Negócio
│── /WebApiCantina.Infrastructure  -> Contexto, Implementação dos Repositórios e Configuração do EF Core
│── /WebApiCantina.Shared          -> Enums, Requests, Responses, Paginação, etc.
│── /tests
│   │── /WebApiCantina.Api.Test             -> Testes da API
│   │── /WebApiCantina.Application.Test     -> Testes de Casos de Uso e Serviços
│   │── /WebApiCantina.Domain.Test          -> Testes de Domínio (Entidades e VOs)
│   │── /WebApiCantina.Infrastructure.Test  -> Testes do Repositório e Banco de Dados
```

---

## :white_check_mark: Checklist de Desenvolvimento

### :one: - Criar a Solução e Projetos
1. :white_check_mark: **Criar a solução no .NET**
2. :white_check_mark: **Adicionar os projetos à solução**
3. :white_check_mark: **Configurar referências entre os projetos**

### :two: - Definir o Domínio (WebApiCantina.Domain)
1. :white_check_mark: **Criar Entidades**  
   - :white_check_mark: :bust_in_silhouette: Usuario
   - :white_check_mark: :briefcase: Administrador 
   - :white_check_mark: :construction_worker: Colaborador  
   - :white_check_mark: :man: Comum 
   - :white_check_mark: :pencil: Categoria  
   - :white_check_mark: :hamburger: Produtos
   - :white_check_mark: :money_with_wings: Carrinho
2. :white_check_mark: **Criar Value Objects (VOs) se necessário**
   - :white_check_mark: :email: Email
   - :white_check_mark: :pager: Cpf
   - :white_check_mark: :calendar: Data
   - :white_check_mark: :moneybag: Preco
   - :white_check_mark: 📦 Quantidade
   - :white_check_mark: :iphone: Telefone
   - :white_check_mark: :city_sunset: UrlImagem
3. :black_square_button: **Criar Interfaces de Repositórios**
   - :white_check_mark: GenericRepository
   - :white_check_mark: ProdutosRepository
4. :white_check_mark: **Criar Exceções de Domínio (DomainException)**
5. :black_square_button: **Criar Regras de Negócio dentro das entidades**

### :three: - Criar Casos de Uso (WebApiCantina.Application)
1. :black_square_button: **Criar DTOs**  
2. :black_square_button: **Criar Interfaces de Serviços**
3. :black_square_button: **Criar Implementação de Serviços**
4. :black_square_button: **Criar Handlers (se usar CQRS)**
5. :black_square_button: **Configurar Perfis de mapeamento para converter Entidades <-> DTOs**

### :four: - Implementar a Infraestrutura (WebApiCantina.Infrastructure)
1. :white_check_mark: **Criar o DbContext com Entity Framework Core**
2. :black_square_button: **Configurar Entidades com Fluent API**
3. :black_square_button: **Implementar os Repositórios**
4. :white_check_mark: **Criar Migrations e Atualizar o Banco**

### :five: - Criar a API e Configurar Dependências (WebApiCantina.Api)
1. :white_check_mark: **Criar o Program.cs com Minimal API**(Ou utilizando controllers)
2. :black_square_button: **Configurar Injeção de Dependência (DI)**
3. :white_check_mark: **Adicionar Swagger**
4. :black_square_button: **Criar Controllers:**  
   - :white_check_mark: ProdurtosController
   - :white_check_mark: CategoriasController
   - :black_square_button: ColaboradoresController
   - :black_square_button: ClientesController
5. :black_square_button: **Criar Middlewares (tratamento de erro, logs, autenticação, etc.)**
6. :white_check_mark: **Adicionar Autenticação e Autorização**
7. :black_square_button: **Implementar Integração com Front**

### :six: - Criar Testes
#### :flags: Testes de Unidade
1. :black_square_button: **Testes para Entidades e Regras de Negócio (WebApiCantina.Domain.Test)**
2. :black_square_button: **Testes para Serviços e Casos de Uso (WebApiCantina.Application.Test)**

#### :link: Testes de Integração
1. :black_square_button: **Testes para Repositórios (WebApiCantina.Infrastructure.Test)**
2. :black_square_button: **Testes para Endpoints da API (WebApiCantina.Api.Test)**

### :seven: - Configurar CI/CD e Publicação
1. :black_square_button: **Criar um Dockerfile**
2. :black_square_button: **Configurar pipeline CI/CD (GitHub Actions ou Azure DevOps)**
3. :black_square_button: **Publicar a API em um ambiente (ex: Railway, Azure, AWS, Render)**

___

## :bar_chart: Funcionalidades Principais

- **Cadastro e Gerenciamento de Produtos:**  
  Inclui Categoria, nome, quantidade, descrição, preço, dentre outros atributos.

- **Dashboard Interativo:**  
  - Total de produtos e suprimentos disponíveis  
  - Gráficos de suprimentos mais recorrentes (Pizza)  
  - Produtos predominantes (Barras verticais)

- **Gerenciamento de Status:**  
  Definição de status do colaborador (Online, Almoço, Ocupado, Ausente, Offline).

- **Alerta de mínimo:**  
  Alerta sobre a quantidade mínima de items em estoque.

- **Cardápio padronizado:**  
  Exibe produtos e preços.

- **Relatório:**  
  - Exporta relatório mensal em .csv.

- **Limpeza Mensal Automática:**  
  No primeiro dia de cada mês, os dados do mês anterior são arquivados e a base atual é limpa.

___

## :triangular_ruler: Diagrama de Dependências

```
WebApiCantina.Api  --->  WebApiCantina.Application  --->  WebApiCantina.Domain
       |                            |                          |
       v                            v                          v
WebApiCantina.Infrastructure  WebApiCantina.Shared     WebApiCantina.Shared
```

