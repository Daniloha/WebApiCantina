using Microsoft.EntityFrameworkCore;
using WebApiCantina.Data.Context;
using WebApiCantina.Data.Services.Repositories;
using WebApiCantina.Domain.Services.Interfaces;

namespace WebApiCantina.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            /**************************************************************/
            //SERVIÇOS DE CONEXÃO AO BANCO DE DADOS
            /**************************************************************/

            /*
             * Cria a minha string de conexão com o banco de dados a partir do meu 
             * arquivo de configuração appsettings.json
             */
            string? mySqlConnection = configuration.GetConnectionString("DefaultConnection");

            /*
             * Cria o serviço de conexão com o meu banco de dados utilizando minha classe
             * de contexto do entityFramework baseado no RGBD escolhido e minha string de
             * conexão.
             */
            services.AddDbContext<AppDbContext>(options =>
                                options.UseMySql(mySqlConnection,
                                ServerVersion.AutoDetect(mySqlConnection)));


            services.AddControllers();

            /**************************************************************/
            //SERVIÇOS DE CONFIGURAÇÃO DE CORS
            /**************************************************************/
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAngularApp",
                    policy =>
        {
                        policy.WithOrigins("https://projeto-cantina-web.onrender.com/home") // URL do Angular no Render
                        .AllowAnyHeader()
                        .AllowAnyMethod();
        });
            });



            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();


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

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProdutosRepository, ProdutosRepository>();

            return services;
        }
    }
}
