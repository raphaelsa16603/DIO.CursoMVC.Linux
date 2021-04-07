## Código da Aplicação CRUD com ASP.NET MVC usando comandos no linux.

## Criação do aplicativo MVC
- dotnet new mvc -n CursoMVC

## Patotes necessários
#### O SqlServer é necessário para funcionar o CodeGeneration
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer 

## Instalando globalmente o EF
- dotnet tool install --global dotnet-ef

## EF Criação da base de dados
- dotnet ef migrations add InitCategorias
- dotnet ef database update


## Instalando globalmente o Gerador de código do Asp.NET
- dotnet tool install -g dotnet-aspnet-codegenerator

## Instalando componente de geração no projeto
- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design 

## Dica: https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-5.0
## Criando o scaffolder controller da base Categoria...
- dotnet aspnet-codegenerator controller -name CategoriasController --model Categoria --dataContext Context --relativeFolderPath Controllers --force --useDefaultLayout 

## Criando o scaffolder controller... ", we need to use the command below:"
## Não funcionou --- dotnet aspnet-codegenerator controller -name CategoriasController --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --readWriteActions


## Criando o scaffolder da view ", the command is like below:"
## Não funcionou e não é necessário --- dotnet aspnet-codegenerator view Index List -m Categoria -outDir Views/Categorias --useDefaultLayout --referenceScriptLibraries
## Não funcionou e não é necessário --- dotnet aspnet-codegenerator view Create -m Categoria -outDir Views/Categorias --useDefaultLayout --referenceScriptLibraries
## Não funcionou e não é necessário --- dotnet aspnet-codegenerator view Edit -m Categoria -outDir Views/Categorias --useDefaultLayout --referenceScriptLibraries
## Não funcionou e não é necessário ---  dotnet aspnet-codegenerator view Delete -m Categoria -outDir Views/Categorias --useDefaultLayout --referenceScriptLibraries
## Não funcionou e não é necessário ---  dotnet aspnet-codegenerator view Details -m Categoria -outDir Views/Categorias --useDefaultLayout --referenceScriptLibraries


## EF Criação da base de dados de Produtos
- dotnet ef migrations add TabelaProdutos
- dotnet ef database update

## Criando NOVAMENTE o scaffolder controller da base Categoria...
- dotnet aspnet-codegenerator controller -name CategoriasController --model Categoria --dataContext Context --relativeFolderPath Controllers --force --useDefaultLayout 
## Criando o scaffolder controller da base Produtos...
- dotnet aspnet-codegenerator controller -name ProdutosController --model Produto --dataContext Context --relativeFolderPath Controllers --force --useDefaultLayout 
