#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Online.Classified.App/Online.Classified.App.csproj", "Online.Classified.App/"]
COPY ["Online.Classified.Data/Online.Classified.Data.csproj", "Online.Classified.Data/"]
COPY ["Online.Classified.Services/Online.Classified.Services.csproj", "Online.Classified.Services/"]
RUN dotnet restore "Online.Classified.App/Online.Classified.App.csproj"
COPY . .
WORKDIR "/src/Online.Classified.App"
RUN dotnet build "Online.Classified.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Online.Classified.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Online.Classified.App.dll"]

CMD ASPNETCORE_URLS=http://*:$PORT dotnet Online.Classified.App.dll