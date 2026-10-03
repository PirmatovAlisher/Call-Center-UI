# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

COPY TelephonyUI.sln .
COPY TelephonyUI/ TelephonyUI/

RUN dotnet restore TelephonyUI.sln
RUN dotnet publish "TelephonyUI/TelephonyUI.csproj" -c Release -o /app/publish --no-restore

# Stage 2: Serve static files with nginx
FROM nginx:alpine AS final
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
