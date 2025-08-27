# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY TelephonyUI.sln .
COPY TelephonyUI/TelephonyUI.csproj TelephonyUI/

# Restore dependencies
RUN dotnet restore

# Copy everything else and build
COPY . .
WORKDIR /src/TelephonyUI
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Set environment and expose port
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "TelephonyUI.dll"]
