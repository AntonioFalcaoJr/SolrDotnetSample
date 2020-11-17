ARG RUNTIME_VERSION="3.1.4-alpine3.11"
ARG SDK_VERSION="3.1.300-alpine3.11"

FROM mcr.microsoft.com/dotnet/core/runtime:$RUNTIME_VERSION AS base
WORKDIR /app

RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

FROM mcr.microsoft.com/dotnet/core/sdk:$SDK_VERSION AS build
WORKDIR /src

COPY ./src/SolrDotnetSample.Domain/*.csproj ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/*.csproj ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Application/*.csproj ./SolrDotnetSample.Application/

COPY ./NuGet.Config /
RUN dotnet restore ./SolrDotnetSample.Application

COPY ./src/SolrDotnetSample.Domain/. ./SolrDotnetSample.Domain/
COPY ./src/SolrDotnetSample.Repositories/. ./SolrDotnetSample.Repositories/
COPY ./src/SolrDotnetSample.Application/. ./SolrDotnetSample.Application/

WORKDIR /src/SolrDotnetSample.Application/
RUN dotnet build -c Release -o /app/build 

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SolrDotnetSample.Application.dll"]