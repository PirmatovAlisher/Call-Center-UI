# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy the project file and restore dependencies from the TelephonyUi folder
COPY TelephonyUi/TelephonyUi.csproj TelephonyUi/
RUN dotnet restore TelephonyUi/TelephonyUi.csproj

# Copy the rest of the application code
COPY TelephonyUi/ .

# Publish the application
RUN dotnet publish "TelephonyUi/TelephonyUi.csproj" -c Release -o /app --no-restore

# Stage 2: Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app .

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "TelephonyUi.dll"]
