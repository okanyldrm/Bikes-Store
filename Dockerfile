FROM mcr.microsoft.com/dotnet/sdk:3.1 as build
WORKDIR /app

COPY ./BikeStore.Core/*.csproj ./BikeStore.Core/
COPY ./BikeStore.DataAccess/*.csproj ./BikeStore.DataAccess/
COPY ./BikeStore.Business/*.csproj ./BikeStore.Business/
COPY ./BikeStore.Cache/*.csproj ./BikeStore.Cache/
COPY ./BikeStore.Entities/*.csproj ./BikeStore.Entities/
COPY ./BikeStore.WebUI/*.csproj ./BikeStore.WebUI/
COPY ./BikeStore.WebAPI/*.csproj ./BikeStore.WebAPI/
COPY *.sln .

RUN dotnet restore
COPY . .
RUN dotnet publish ./BikeStore.WebUI/*.csproj -o /publish/

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS="http://*:4500"
ENTRYPOINT [ "dotnet","BikeStore.WebUI.dll" ]