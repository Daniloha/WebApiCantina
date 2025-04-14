___
# WebApiCantina


## 📄 Sobre o Projeto

Este projeto foi desenvolvido utilizando a linguagem de programação C# e a plataforma .NET para criar um backend robusto e seguro, adequado para a gestão de recursos de uma cantina. O frontend é desenvolvido em Angular, permitindo a construção de uma interface de usuário dinâmica e responsiva para a web. O desenvolvimento é feito utilizando o Visual Studio Code e Visual Studio, proporcionando um ambiente de desenvolvimento integrado (IDE) eficiente para programação em C# e Angular.

Para o armazenamento e gerenciamento dos dados, utiliza-se o banco de dados MySQL, que é adequado para a manutenção de informações de estoque, transações e usuários de forma segura e eficiente. O controle de versão do código é realizado com Git, e os repositórios são hospedados no GitHub, garantindo a colaboração entre desenvolvedores e o versionamento do projeto. Além disso, a ferramenta Miro é utilizada para a criação de diagramas e fluxos, facilitando a visualização dos processos de desenvolvimento e arquitetura do sistema.

___

## 📂 Estrutura do Projeto
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

## ✅ Checklist de Desenvolvimento

### 1️⃣ - Criar a Solução e Projetos
1. ✅ **Criar a solução no .NET**
2. ✅ **Adicionar os projetos à solução**
3. ✅ **Configurar referências entre os projetos**

### 2️⃣ - Definir o Domínio (WebApiCantina.Domain)
1. ✅ **Criar Entidades**  
   - ✅Usuario
   - ✅Administrador 
   - ✅Colaborador  
   - ✅Comum 
   - ✅Categoria  
   - ✅Produtos
   - ✅Carrinho
2. 🔲 **Criar Value Objects (VOs) se necessário**
3. 🔲 **Criar Interfaces de Repositórios**
4. 🔲 **Criar Exceções de Domínio (DomainException)**
5. 🔲 **Criar Regras de Negócio dentro das entidades**

### 3️⃣ - Criar Casos de Uso (WebApiCantina.Application)
1. 🔲 **Criar DTOs**  
2. 🔲 **Criar Interfaces de Serviços**
3. 🔲 **Criar Implementação de Serviços**
4. 🔲 **Criar Handlers (se usar CQRS)**
5. 🔲 **Configurar Perfis de mapeamento para converter Entidades <-> DTOs**

### 4️⃣ - Implementar a Infraestrutura (WebApiCantina.Infrastructure)
1. ✅ **Criar o DbContext com Entity Framework Core**
2. 🔲 **Configurar Entidades com Fluent API**
3. 🔲 **Implementar os Repositórios**
4. ✅ **Criar Migrations e Atualizar o Banco**

### 5️⃣ - Criar a API e Configurar Dependências (WebApiCantina.Api)
1. ✅ **Criar o Program.cs com Minimal API**(Ou utilizando controllers)
2. 🔲 **Configurar Injeção de Dependência (DI)**
3. ✅ **Adicionar Swagger**
4. 🔲 **Criar Endpoints:**  
   - 🔲Registro de chamados  
   - 🔲Consultas e atualizações  
   - 🔲Gestão de escalonamentos  
   - 🔲Padrões de tratativas  
5. 🔲 **Criar Middlewares (tratamento de erro, logs, autenticação, etc.)**
6. ✅ **Adicionar Autenticação e Autorização**
7. 🔲 **Implementar Integração com Front**

### 6️⃣ - Criar Testes
#### 🟠 Testes de Unidade
1. 🔲 **Testes para Entidades e Regras de Negócio (WebApiCantina.Domain.Test)**
2. 🔲 **Testes para Serviços e Casos de Uso (WebApiCantina.Application.Test)**

#### 🔵 Testes de Integração
1. 🔲 **Testes para Repositórios (WebApiCantina.Infrastructure.Test)**
2. 🔲 **Testes para Endpoints da API (WebApiCantina.Api.Test)**

### 7️⃣ - Configurar CI/CD e Publicação
1. 🔲 **Criar um Dockerfile**
2. 🔲 **Configurar pipeline CI/CD (GitHub Actions ou Azure DevOps)**
3. 🔲 **Publicar a API em um ambiente (ex: Railway, Azure, AWS, Render)**

___

## 📊 Funcionalidades Principais

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

## 📐 Diagrama de Dependências

```
WebApiCantina.Api  --->  WebApiCantina.Application  --->  WebApiCantina.Domain
       |                            |                          |
       v                            v                          v
WebApiCantina.Infrastructure  WebApiCantina.Shared     WebApiCantina.Shared
```

