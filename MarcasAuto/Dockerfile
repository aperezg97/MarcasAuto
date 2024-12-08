#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
# RUN mkdir -p MarcasAuto
# RUN echo "PWD is: $PWD"
# COPY ["MarcasAuto/MarcasAuto.csproj", "MarcasAuto/"]
# C:\Users\alex\source\repos\MarcasAuto\MarcasAuto\MarcasAuto.csproj
COPY ["MarcasAuto.csproj", "MarcasAuto/"]
RUN dotnet restore "./MarcasAuto/MarcasAuto.csproj"
WORKDIR "/src/MarcasAuto"
COPY . .
RUN dotnet build "MarcasAuto.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
# RUN dotnet publish "./MarcasAuto.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
RUN dotnet publish "./MarcasAuto.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarcasAuto.dll"]