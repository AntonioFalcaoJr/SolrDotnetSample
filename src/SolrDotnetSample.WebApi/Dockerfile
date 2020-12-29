ARG ASPNET_VERSION="5.0.0-rc.1-alpine3.12"
ARG SDK_VERSION="5.0.100-rc.1-alpine3.12"
ARG BASE_ADRESS="mcr.microsoft.com/dotnet"

FROM $BASE_ADRESS/aspnet:$ASPNET_VERSION AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://*:5000

RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

FROM $BASE_ADRESS/sdk:$SDK_VERSION AS build
WORKDIR /src

COPY ./src/SolrDotnetSample.Domain/*.csproj ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/*.csproj ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Services/*.csproj ./SolrDotnetSample.Services/
COPY ./src/SolrDotnetSample.WebApi/*.csproj ./SolrDotnetSample.WebApi/

COPY ./NuGet.Config ./
COPY ./Directory.Build.props ./

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