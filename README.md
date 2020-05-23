# Sample with .NET Core and SolrNet

![.NET Core](https://github.com/AntonioFalcao/SolrDotnetSample/workflows/.NET%20Core/badge.svg?branch=master)

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

Com o uso de **containerização**, podemos provisionar de forma prática a infraestrtutura necessária.

Inicialmente utilizaremos o serviço **Solr**, para atender a necessidade de **Search Engine**, atravez do compose [`./solr-compose`](./solr-compose.yml).

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
#### Semeando dados no Solr

Uma vez provisionado o ambiente, podemos semear dados atravez dos passos:

> 1.  Aplicar migrations do EF Core ao dbcontext relacional.
```bash
dotnet ef database update -s ./src/SolrDotnetSample.WebApi/ -p ./src/SolrDotnetSample.Repositories/
```
> 2. Executar aplicação console e selecionar opção de semeadura.

```bash
docker build -t seed -f ./consoleApp.Dockerfile . && docker run -it seed
```
> 3. Aplicar migrations ao dbcontext relacional.
```bash
docker-compose -f solr-compose.yml up
```

## Running the tests

#### Automated tests
Os testes unitários e de integração podem ser executados com o respectivo comando:
```bash
dotnet test
```
#### Functional tests
Para executarmos testes de forma funcional, devemos inicialmente executar o projeto para disponibilizar o serviço Web. O 

```bash
dotnet run -p ./src/SolrDotnetSample.WebApi/
```

> O roteamento segue o padrão `http://hostname:port/api/v{version}/controller`

Para realizar chamadas, pode estar utilizando o arquivo [./basic-api-call.http](./basic-api-call.http) atravez da extenção [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client), por exemplo:.

```http request

GET https://localhost:5001/api/v1/posts

###

POST https://localhost:5001/api/v1/posts
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
```
## Deployment

Detalhes sobre esteria (CI/CD) disponíveis em [Project GitHub Actions](https://github.com/AntonioFalcao/SolrDotnetSample/actions)

## Built With

* [.NET Core](https://dotnet.microsoft.com/) - The base framework used
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1) - The web framework used
* [EF Core](https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli) - ORM
* [SolrNet](https://github.com/SolrNet/SolrNet/) - Apache Solr client for .NET
* [AutoMapper](https://automapper.org/) - Library for mapping objects

## Contributing

Available soon! 

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Antônio Falcão** - [GitHub](https://github.com/AntonioFalcao)

> See also the list of [contributors](https://github.com/AntonioFalcao/SolrDotnetSample/graphs/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Nothing more, for now.