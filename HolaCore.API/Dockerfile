#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HolaCore.API/HolaCore.API.csproj", "HolaCore.API/"]
COPY ["HolaCore.Infrastructure/HolaCore.Infrastructure.csproj", "HolaCore.Infrastructure/"]
COPY ["HolaCore.Domain/HolaCore.Domain.csproj", "HolaCore.Domain/"]
RUN dotnet restore "HolaCore.API/HolaCore.API.csproj"
COPY . .
WORKDIR "/src/HolaCore.API"
RUN dotnet build "HolaCore.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HolaCore.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HolaCore.API.dll"]
