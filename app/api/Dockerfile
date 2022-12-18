FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
# Define the location of your project
COPY ./NetCoreApp/NetCoreApp.csproj .
# dotnet restore command uses NuGet to restore dependencies 
#  as well as project-specific tools that are specified in the project file
RUN dotnet restore "./NetCoreApp.csproj"
COPY ./NetCoreApp .
WORKDIR "/src/."
RUN dotnet build "NetCoreApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NetCoreApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NetCoreApp.dll"]