ARG DOTNET_VERSION="3.1-alpine"

FROM mcr.microsoft.com/dotnet/core/aspnet:$DOTNET_VERSION AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://*:5000
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/core/sdk:$DOTNET_VERSION AS build
WORKDIR /src

COPY ./src/SolrDotnetSample.Domain/*.csproj ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/*.csproj ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Services/*.csproj ./SolrDotnetSample.Services/
COPY ./src/SolrDotnetSample.WebApi/*.csproj ./SolrDotnetSample.WebApi/

RUN dotnet restore ./SolrDotnetSample.WebApi

COPY ./src/SolrDotnetSample.Domain/. ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/. ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Services/. ./SolrDotnetSample.Services/
COPY ./src/SolrDotnetSample.WebApi/. ./SolrDotnetSample.WebApi/

WORKDIR /src/SolrDotnetSample.WebApi/
RUN dotnet build -c Release --no-restore -o /app/build 

FROM build AS publish
RUN dotnet publish -c Release --no-restore -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SolrDotnetSample.WebApi.dll"]