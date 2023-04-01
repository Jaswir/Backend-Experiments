#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#Debug
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MonoServiceDemo/MonoServiceDemo.csproj", "MonoServiceDemo/"]
RUN dotnet restore "MonoServiceDemo/MonoServiceDemo.csproj"
COPY . .
WORKDIR "/src/MonoServiceDemo"
RUN dotnet build "MonoServiceDemo.csproj" -c Release -o /app/build

#Release
FROM build AS publish
RUN dotnet publish "MonoServiceDemo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MonoServiceDemo.dll"]


# Multiple stages
