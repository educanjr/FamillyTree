FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["FamilyTree.*/*.csproj", "./"]
RUN dotnet restore "FamilyTree.App/FamilyTree.App.csproj"
COPY . .
WORKDIR "/src/FamilyTree.App"
RUN dotnet build "FamilyTree.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FamilyTree.App.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "FamilyTree.App.dll"]