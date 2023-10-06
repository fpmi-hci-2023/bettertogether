FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source
EXPOSE 7269

# copy csproj and restore as distinct layers
COPY *.sln .
COPY TestEnv/*.csproj ./TestEnv/
RUN dotnet restore

# copy everything else and build app
COPY TestEnv/. ./TestEnv/
WORKDIR /source/TestEnv
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "TestEnv.dll"]