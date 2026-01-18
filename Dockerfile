FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["aspnet-webapi-versioning/aspnet-webapi-versioning.csproj", "aspnet-webapi-versioning/"]
RUN dotnet restore "aspnet-webapi-versioning/aspnet-webapi-versioning.csproj"
COPY . .
WORKDIR "/src/aspnet-webapi-versioning"
RUN dotnet build "aspnet-webapi-versioning.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "aspnet-webapi-versioning.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "aspnet-webapi-versioning.dll"]