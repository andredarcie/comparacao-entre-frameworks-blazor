# Comparação entre frameworks Blazor

Todos os projetos são feitos usando Blazor Server

## Abp

[Oficial website](https://abp.io/)

dotnet tool install -g Volo.Abp.Cli

abp new Acme.BookStore -t app-nolayers -u blazor-server -dbms PostgreSQL -csf 

dotnet ef database update --project .\Acme.BookStore.sln