
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FamillyTree.App/FamillyTree.App.csproj", "FamillyTree.App/"]
COPY ["FamillyTree.Application/FamillyTree.Application.csproj", "FamillyTree.Application/"]
COPY ["FamillyTree.Data/FamillyTree.Data.csproj", "FamillyTree.Data/"]
COPY ["FamillyTree.Web/FamillyTree.Web.csproj", "FamillyTree.Web/"]
RUN dotnet restore "FamillyTree.App/FamillyTree.App.csproj"
COPY . .
WORKDIR "/src/FamillyTree.App"
RUN dotnet build "FamillyTree.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FamillyTree.App.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FamillyTree.App.dll"]