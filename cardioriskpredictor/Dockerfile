# Dockerfile

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY cardioriskpredictor/*.csproj ./cardioriskpredictor/
COPY cardioriskpredictor.Models/*.csproj ./cardioriskpredictor.Models/

RUN dotnet restore

# Copy everything else and build
COPY cardioriskpredictor/. ./cardioriskpredictor/
COPY cardioriskpredictor.Models/. ./cardioriskpredictor.Models/

WORKDIR /app/cardioriskpredictor
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app

COPY --from=build-env /app/cardioriskpredictor/out .

# Run the app on container startup
# Use your project name for the second parameter
# e.g. MyProject.dll
CMD ASPNETCORE_URLS=http://*:$PORT dotnet cardioriskpredictor.dll
