# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy the solution file and project folder, then restore dependencies
COPY TelephonyUI.sln .
COPY TelephonyUI/ TelephonyUI/
RUN dotnet restore TelephonyUI.sln

# Publish the application
RUN dotnet publish "TelephonyUI/TelephonyUI.csproj" -c Release -o /app --no-restore

# Stage 2: Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app .

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "TelephonyUI.dll"]
