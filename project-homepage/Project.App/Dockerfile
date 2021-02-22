#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Project.App/Project.App.csproj", "Project.App/"]
COPY ["Project.Data/Project.Data.csproj", "Project.Data/"]
COPY ["Project.Services/Project.Services.csproj", "Project.Services/"]
RUN dotnet restore "Project.App/Project.App.csproj"
COPY . .
WORKDIR "/src/Project.App"
RUN dotnet build "Project.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project.App.dll"]