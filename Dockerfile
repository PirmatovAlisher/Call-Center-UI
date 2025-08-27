# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy the solution file and the entire project directory
# This ensures that all files needed for the build are present.
COPY TelephonyUI.sln .
COPY TelephonyUI/ TelephonyUI/

# Restore dependencies for the entire solution
RUN dotnet restore TelephonyUI.sln

# Publish the application to a specific, temporary location
# We're publishing to /app/publish in this stage, which is a good practice.
RUN dotnet publish "TelephonyUI/TelephonyUI.csproj" -c Release -o /app/publish --no-restore

# Stage 2: Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy the published output from the previous stage to the final image's working directory
# We're copying everything from the temporary /app/publish folder.
COPY --from=build /app/publish .

# Set the entry point to run the published application's DLL
ENTRYPOINT ["dotnet", "TelephonyUI.dll"]
