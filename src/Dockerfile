FROM mcr.microsoft.com/dotnet/aspnet:8.0 as base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
WORKDIR /src
COPY ["Workr.Api/Workr.Api.csproj", "Workr.Api/"]
RUN dotnet restore "Workr.Api/Workr.Api.csproj"
COPY . .
WORKDIR "/src/Workr.Api"
RUN dotnet build "Workr.Api.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish -c Release -o /app/publish

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "Workr.Api.dll" ]
