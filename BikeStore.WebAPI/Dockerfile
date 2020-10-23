FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app


COPY bin/Release/netcoreapp3.1 .



 
ENTRYPOINT ["dotnet", "BikeStore.WebAPI.dll"]