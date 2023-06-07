FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env
WORKDIR /app

# Copy source
COPY ../Workr.Api/. .
COPY ../Workr.Application/. .
COPY ../Workr.Core/. .
COPY ../Workr.Domain/. .
COPY ../Workr.Infrastructure/. .

# Build and publish a release
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "Workr.Api.dll" ]
