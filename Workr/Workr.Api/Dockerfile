FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Workr.Api/Workr.Api.csproj", "Workr.Api/"]
RUN dotnet restore "Workr.Api/Workr.Api.csproj"
COPY . .
WORKDIR "/src/Workr.Api"
RUN dotnet build "Workr.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Workr.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Workr.Api.dll"]
