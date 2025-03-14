# Use the .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code and build the application
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Use the .NET ASP.NET Core runtime image for running the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/publish .

# Expose port 8080 for the application
EXPOSE 8080

# Set the entry point for the application
ENTRYPOINT ["dotnet", "Aspire.Dashboard.dll"]
