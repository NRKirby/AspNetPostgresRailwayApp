FROM mcr.microsoft.com/dotnet/sdk:5.0 as build 
WORKDIR /app 

COPY ./AspNetPostgresRailwayApp.sln .
COPY ./AspNetPostgresRailwayApp.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish --no-restore -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out . 
ENTRYPOINT [ "./AspNetPostgresRailwayApp" ]