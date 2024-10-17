using Microsoft.EntityFrameworkCore;
using WebApiCantina.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/**************************************************************/
//SERVIÇOS DE CONEXÃO AO BANCO DE DADOS
/**************************************************************/

/*
 * Cria a minha string de conexão com o banco de dados a partir do meu 
 * arquivo de configuração appsettings.json
 */
string? mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

/*
 * Cria o serviço de conexão com o meu banco de dados utilizando minha classe
 * de contexto do entityFramework baseado no RGBD escolhido e minha string de
 * conexão.
 */
builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseMySql(mySqlConnection,
                    ServerVersion.AutoDetect(mySqlConnection)));


/**************************************************************/
/*TEMPOS DE VIDA DE UMA INSTÂNCIA
 * Singleton -> Uma única instância é criada para todo o tempo de vida da aplicação
 * Essa mesma instância é reutilizada sempre que a dependência é requisitada.
 * Ideal para serviços que precisam compartilhar dados entre todas as requisições
 * e que são seguros para acesso simultâneo (thread-safe).
 * 
 * Scoped -> Uma nova instância é criada para cada scope de requisição.
 * Em aplicações web, um novo scope é criado a cada requisição HTTP, 
 * ou seja, a mesma instância é compartilhada durante toda a requisição.
 * Ideal para objetos que mantêm estado durante o processamento de uma 
 * única requisição, mas não entre diferentes requisições.
 * 
 * Transient -> Cada vez que a dependência é requisitada, uma nova instância é criada.
 * Usado para objetos que não mantêm estado e são leves, ou que precisam ser criados 
 * sempre que requisitados.
 * É ideal para serviços que são de curta duração e que não precisam manter estado entre
 * as requisições.
 * 
/**************************************************************/

var app = builder.Build();//Instancia da aplicação WEB

//Responsável pela configuração dos Middlewares.

/*  MIDLDEWARES
 *  -> Middlewares são trechos de código que executam em cadeia sequencial para processar 
 *  a requisição e a resposta recebida pela API. Você pode criar e configurar quantas 
 *  middlewares quiser e adicionar quantos middlewares forem necessárias para o fluxo
 *  da aplicação.
 */


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())//Verificando se o ambiente é de desenvolvimento.
{
    app.UseSwagger();// Middleware do Swagger que fornece a documentação das API
    app.UseSwaggerUI();// Middleware que define a interface do usuário para interagir
                       // com a API
}

app.UseHttpsRedirection();// Redirecionar as requisições http para https.

app.UseAuthorization();// Define os níveis de autorização para verificar as permissões
                       // de acesso.

app.MapControllers();//Mapeamento dos controladores da aplicação.

app.Run();// Middleware final -> Ponta da request.

