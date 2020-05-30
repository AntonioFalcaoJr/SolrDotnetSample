# Sample with .NET Core and SolrNet
[![CodeFactor](https://www.codefactor.io/repository/github/antoniofalcao/solrdotnetsample/badge)](https://www.codefactor.io/repository/github/antoniofalcao/solrdotnetsample)
![.NET Core](https://github.com/AntonioFalcao/SolrDotnetSample/workflows/.NET%20Core/badge.svg?branch=master)
![Console App - Docker Image CI](https://github.com/AntonioFalcao/SolrDotnetSample/workflows/Console%20App%20-%20Docker%20Image%20CI/badge.svg?branch=master)
![WebApi - Docker Image CI](https://github.com/AntonioFalcao/SolrDotnetSample/workflows/WebApi%20-%20Docker%20Image%20CI/badge.svg?branch=master)

Este projeto tem como objetivo explorar o funcionamento do **SolrNet** no consumo do serviço de search engine **Solr** em projetos .**NET Core.**

## Getting Started

Após o clone do projeto e siga os passos descritos na etapa de [instalação](#installing). 

 ```bash
 git clone https://github.com/AntonioFalcao/SolrDotnetSample.git
 ```

### Prerequisites

Se faz necessário ambiente com seguintes recursos:

* [.NET Core SDK](https://dotnet.microsoft.com/download) - The framework used.

> To check this functionality:

```bash
dotnet --version
```
> For more details
```bash
dotnet --info
```
* [Entity Framework Core .NET Command-line Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet/) - The ORM service used.
> To install:
```bash
dotnet tool install --global dotnet-ef
```
> To check this functionality:
```bash
dotnet-ef --version
```
* [Docker](https://www.docker.com/) - The container platform used
> To check this functionality:
```bash
docker --version
```
### Installing

Com o uso de **containerização**, podemos provisionar de forma prática a infraestrutura necessária.

Inicialmente utilizaremos o serviço **Solr**, para atender a necessidade de **Search Engine**, através do compose [`./solr-compose`](./solr-compose.yml).

```bash
docker-compose -f solr-compose.yml up -d
```

O índice padrão, referido como [Core](https://lucene.apache.org/solr/guide/6_6/solr-cores-and-solr-xml.html) pelo Solr está definido como `my_core` no `entrypoint`, assim como o mapeamento de porta padrão `8983:8983`:

```yaml
 services: 
# comment for brevity
    ports:
      - "8983:8983"
    entrypoint:
      - solr-precreate
      - my_core
# comment for brevity
```
#### Definindo Fields

A definição dos [Fields](https://lucene.apache.org/solr/guide/6_6/field-type-definitions-and-properties.html#field-type-definitions-and-properties) no Solr é um passo essencial, para garantir que o dado terá a mesma representação desejada pelo modelo.

Existem dois caminhos para isso, um deles é definir os detalhes dos fields no [schema.xml](https://lucene.apache.org/solr/guide/6_6/field-type-definitions-and-properties.html#FieldTypeDefinitionsandProperties-FieldTypeDefinitionsinschema.xml), a outra forma é realizando chamadas direta à API do serviço. Para segunda alternativa, existe o arquivo [solr-add-fields.http](./solr-add-fields.http) disponível no projeto:

```http request
POST http://localhost:8983/solr/my_core/schema
Content-Type: application/json

{
   "add-field":{
      "name":"Description",
      "type":"string",
      "stored":true
      },
   "add-field":{
      "name":"Title",
      "type":"string",
      "stored":true
      },
}

### comment for brevity
```
#### Semeando dados no Solr

Uma vez provisionado o ambiente e configurado os fields, podemos semear dados através dos passos:

 1.  Aplicar migrations do EF Core, que já se encarregará do Seed para o DB relacional.
 > Nesta etapa irá ocorrer a semeadura de dados para o DB relacional. 
```bash
dotnet ef database update -s ./src/SolrDotnetSample.WebApi/ -p ./src/SolrDotnetSample.Repositories/
```
 2. Executar aplicação console e selecionar opção de semeadura para o Solr.
> Duas opções estarão disponíveis, sendo: 
>1. Gerar novos dados.
>2. Migrar dados do relacional. 
```bash
docker build -t seed -f ./consoleApp.Dockerfile . && docker run -it seed
```
## Running the tests

#### Automated tests
Os testes unitários e de integração podem ser executados com o respectivo comando:
```bash
dotnet test
```
#### Functional tests
Para executarmos testes de forma funcional, devemos inicialmente executar o projeto para disponibilizar o serviço Web. 

```bash
docker build -t webapi -f ./webApi.Dockerfile . && docker run -p 5000:5000 webapi 
```

> O roteamento segue o padrão `http://hostname:port/api/v{version}/controller`

Para realizar chamadas, pode estar utilizando o arquivo [./basic-api-call.http](./basic-api-call.http) através da extensão [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client), por exemplo:.

> `/api/v1/...` utiliza o banco de dados relacional.     
> `/api/v2/...` utiliza o Solr

```http request
### V1 - Relational DB
GET http://localhost:5000/api/v1/posts

### V2 - NoSql DB
GET http://localhost:5000/api/v2/posts

### V1 - Relational DB
POST http://localhost:5000/api/v1/posts
Content-Type: application/json

{
  "Description": "Description",
  "ExpiryDate": "2020-01-01",
  "IsActive": true,
  "IsSold": true,
  "PostDate": "2020-01-01",
  "Price": 0,
  "Title": "Title"
}

### comment for brevity
```
## Deployment

Detalhes sobre esteira (CI/CD) disponíveis em [Project GitHub Actions](https://github.com/AntonioFalcao/SolrDotnetSample/actions)

## Built With

##### Microsoft Stack
* [.NET Core](https://dotnet.microsoft.com/) - The base framework used
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1) - The web framework used
* [EF Core](https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli) - ORM
* [AutoMapper](https://automapper.org/) - Library for mapping objects

##### Solr Stack
* [Solr](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwiT8fiYgdDpAhVMILkGHRapBdwQFjAAegQICBAC&url=https%3A%2F%2Flucene.apache.org%2Fsolr%2F&usg=AOvVaw220ce7CtImnLrhaQpO1SO2) - Search Engine used.
* [SolrNet](https://github.com/SolrNet/SolrNet/) - Apache Solr client for .NET

## Contributing

Available soon! 

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/AntonioFalcao/SolrDotnetSample/tags). 

## Authors

* **Antônio Falcão** - [GitHub](https://github.com/AntonioFalcao)

> See also the list of [contributors](https://github.com/AntonioFalcao/SolrDotnetSample/graphs/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Nothing more, for now.
