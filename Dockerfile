# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia tudo para dentro do container
COPY . .

# Restaura dependências e compila o projeto principal da API
RUN dotnet restore "./WebApiCantina/WebApiCantina.Api.csproj"
RUN dotnet publish "./WebApiCantina/WebApiCantina.Api.csproj" -c Release -o /app/publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Render expõe a porta 10000
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# Executa a API
ENTRYPOINT ["dotnet", "WebApiCantina.Api.dll"]
