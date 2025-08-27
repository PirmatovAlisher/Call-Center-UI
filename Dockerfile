# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY TelephonyUI.sln .
COPY TelephonyUI/TelephonyUI.csproj TelephonyUI/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the source
COPY . .

# Build and publish the project
WORKDIR /src/TelephonyUI
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy build output
COPY --from=build /app/publish .

# Configure environment
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Start the application
ENTRYPOINT ["dotnet", "TelephonyUI.dll"]
