namespace WebApiCantina.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static WebApplication UseApplicationConfiguration(this WebApplication app)
        {

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

            // Configuração de CORS
            app.UseCors("AllowAll");

            app.UseHttpsRedirection();// Redirecionar as requisições http para https.

            app.UseAuthorization();// Define os níveis de autorização para verificar as permissões
                                   // de acesso.

            app.MapControllers();//Mapeamento dos controladores da aplicação.

            return app;
        }
    }
}
