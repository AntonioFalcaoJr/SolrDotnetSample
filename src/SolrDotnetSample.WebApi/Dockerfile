ARG ASPNET_VERSION="3.1.4-alpine3.11"
ARG SDK_VERSION="3.1.300-alpine3.11"

FROM mcr.microsoft.com/dotnet/core/aspnet:$ASPNET_VERSION AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://*:5000

RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

FROM mcr.microsoft.com/dotnet/core/sdk:$SDK_VERSION AS build
WORKDIR /src

COPY ./src/SolrDotnetSample.Domain/*.csproj ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/*.csproj ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Services/*.csproj ./SolrDotnetSample.Services/
COPY ./src/SolrDotnetSample.WebApi/*.csproj ./SolrDotnetSample.WebApi/

COPY ./NuGet.Config /
RUN dotnet restore ./SolrDotnetSample.WebApi

COPY ./src/SolrDotnetSample.Domain/. ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/. ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Services/. ./SolrDotnetSample.Services/
COPY ./src/SolrDotnetSample.WebApi/. ./SolrDotnetSample.WebApi/

WORKDIR /src/SolrDotnetSample.WebApi/
RUN dotnet build -c Release -o /app/build 

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SolrDotnetSample.WebApi.dll"]