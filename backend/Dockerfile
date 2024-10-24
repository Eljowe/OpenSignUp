# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /backend
EXPOSE 80
EXPOSE 443
EXPOSE 7777

# Use the official SDK to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the .csproj file and restore dependencies
COPY backend.csproj ./
RUN dotnet restore backend.csproj

# Copy the remaining project files
COPY . ./

# Build the app with the Release configuration and output to /backend/build
RUN dotnet build backend.csproj -c Release -o /backend/build

# Perform the publish step (publish the application to /backend/publish)
FROM build AS publish
RUN dotnet publish backend.csproj -c Release -o /backend/publish

# Debugging step: List the content of /backend/publish after publishing
RUN ls -la /backend/publish

# Use the base image to run the app
FROM base AS final
WORKDIR /backend
COPY --from=publish /backend/publish .

# Entry point for the application
ENTRYPOINT ["dotnet", "backend.dll"]