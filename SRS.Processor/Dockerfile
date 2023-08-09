#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SRS.Processor/SRS.Processor.csproj", "SRS.Processor/"]
COPY ["SRS.Postgres/SRS.Postgres.csproj", "SRS.Postgres/"]
COPY ["Library.CommonEnums/Library.CommonEnums.csproj", "Library.CommonEnums/"]
COPY ["SRS.Core/SRS.Core.csproj", "SRS.Core/"]
COPY ["Library.ApiClients/Library.ApiClients.csproj", "Library.ApiClients/"]
COPY ["Library.ResilientHttpClient/Library.ResilientHttpClient.csproj", "Library.ResilientHttpClient/"]
COPY ["Library.Logger/Library.Logger.csproj", "Library.Logger/"]
COPY ["SRS.SqlServer/SRS.SqlServer.csproj", "SRS.SqlServer/"]
RUN dotnet restore "SRS.Processor/SRS.Processor.csproj"
COPY . .
WORKDIR "/src/SRS.Processor"
RUN dotnet build "SRS.Processor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SRS.Processor.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SRS.Processor.dll"]