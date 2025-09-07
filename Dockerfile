# Imagen base de ASP.NET Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
# Render necesita exponer el puerto dinámico (usaremos 8080 por defecto)
EXPOSE 80

# Imagen para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia el archivo csproj y restaura dependencias
COPY ["appsales.csproj", "./"]
RUN dotnet restore "./appsales.csproj"

# Copia todo el código
COPY . .

# Publica la aplicación en modo Release
RUN dotnet publish "appsales.csproj" -c Release -o /app/publish

# Imagen final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Render usará este comando para ejecutar tu API
ENTRYPOINT ["dotnet", "appsales.dll"]
