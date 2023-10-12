FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BetterTogetherAPI/BetterTogetherAPI.csproj", "BetterTogetherAPI/"]
RUN dotnet restore "BetterTogetherAPI/BetterTogetherAPI.csproj"
COPY . .
WORKDIR "/src/BetterTogetherAPI"
RUN dotnet build "BetterTogetherAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BetterTogetherAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BetterTogetherAPI.dll"]
