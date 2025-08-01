FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copiar los .csproj
COPY FesajoStudios/Server/FesajoStudios.Server.csproj FesajoStudios/Server/
COPY FesajoStudios/Shared/FesajoStudios.Shared.csproj FesajoStudios/Shared/
COPY FesajoStudios/Client/FesajoStudios.Client.csproj FesajoStudios/Client/
COPY FesajoStudios.DataAccess/FesajoStudios.DataAccess.csproj FesajoStudios.DataAccess/
COPY FesajoStudios.Entities/FesajoStudios.Entities.csproj FesajoStudios.Entities/
COPY FesajoStudios.Repositories/FesajoStudios.Repositories.csproj FesajoStudios.Repositories/

RUN dotnet restore FesajoStudios/Server/FesajoStudios.Server.csproj

COPY . .

WORKDIR /src/FesajoStudios/Server
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "FesajoStudios.Server.dll"]
