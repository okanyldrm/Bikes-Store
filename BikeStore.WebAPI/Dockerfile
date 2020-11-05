FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY ["BikeStore.WebAPI/BikeStore.WebAPI.csproj", "app/BikeStore/"]
COPY ["BikeStore.Business/BikeStore.Business.csproj", "app/BikeStore/"]
COPY ["BikeStore.DataAccess/BikeStore.DataAccess.csproj", "app/BikeStore/"]
COPY ["BikeStore.Core/BikeStore.Core.csproj", "app/BikeStore/"]
COPY ["BikeStore.Entities/BikeStore.Entities.csproj", "app/BikeStore/"]
COPY ["BikeStore.Cache/BikeStore.RediCache.csproj", "app/BikeStore/"]

RUN dotnet restore "BikeStore.WebAPI/BikeStore.WebAPI.csproj"
COPY . .
WORKDIR "/src/BikeStore"
RUN dotnet build "BikeStore.WebAPI.csproj" -c Release -o /app/build
#RUN dotnet build "BikeStore.Business.csproj" -c Release -o /app/build
#RUN dotnet build "BikeStore.DataAccess.csproj" -c Release -o /app/build
#RUN dotnet build "BikeStore.Entities.csproj" -c Release -o /app/build
#RUN dotnet build "BikeStore.Core.csproj" -c Release -o /app/build
#RUN dotnet build "BikeStore.RediCache.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "BikeStore.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BikeStore.WebAPI.dll"]
