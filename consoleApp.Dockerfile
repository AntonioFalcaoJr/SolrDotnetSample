ARG ASPNET_VERSION="3.1.4-alpine3.11"
ARG SDK_VERSION="3.1.300-alpine3.11"

FROM mcr.microsoft.com/dotnet/core/aspnet AS base
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/core/sdk AS build
WORKDIR /src

COPY ./src/SolrDotnetSample.Domain/*.csproj ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/*.csproj ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Services/*.csproj ./SolrDotnetSample.Services/
COPY ./src/SolrDotnetSample.Application/*.csproj ./SolrDotnetSample.Application/

RUN dotnet restore ./SolrDotnetSample.Application --disable-parallel

COPY ./src/SolrDotnetSample.Domain/. ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/. ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Services/. ./SolrDotnetSample.Services/
COPY ./src/SolrDotnetSample.Application/. ./SolrDotnetSample.Application/

WORKDIR /src/SolrDotnetSample.Application/
RUN dotnet build -c Release --no-restore -o /app/build 

FROM build AS publish
RUN dotnet publish -c Release --no-restore -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SolrDotnetSample.Application.dll"]