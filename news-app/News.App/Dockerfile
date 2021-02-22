#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["News.App/News.App.csproj", "News.App/"]
COPY ["News.Data/News.Data.csproj", "News.Data/"]
COPY ["News.Service/News.Service.csproj", "News.Service/"]
RUN dotnet restore "News.App/News.App.csproj"
COPY . .
WORKDIR "/src/News.App"
RUN dotnet build "News.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "News.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "News.App.dll"]