FROM mcr.microsoft.com/dotnet/sdk:3.1 AS builder
WORKDIR /src
COPY ./ProductAPI.csproj .
RUN dotnet restore ProductAPI.csproj
COPY . .
RUN dotnet build ProductAPI.csproj -c Debug -o /src/out
# using ASP.NET Core SDK to run the image inside the container
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=builder /src/out .

EXPOSE 80
ENTRYPOINT [ "dotnet", "ProductAPI.dll"]