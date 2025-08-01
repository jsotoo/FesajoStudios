# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY ["FesajoStudios.Client/FesajoStudios.Client.csproj", "FesajoStudios.Client/"]
COPY ["FesajoStudios.Shared/FesajoStudios.Shared.csproj", "FesajoStudios.Shared/"]
RUN dotnet restore "FesajoStudios.Client/FesajoStudios.Client.csproj"
COPY . .
WORKDIR "/app/FesajoStudios.Client"
RUN dotnet publish -c Release -o /app/dist

# Etapa 2: Servir con Nginx
FROM nginx:alpine
COPY --from=build /app/dist/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
