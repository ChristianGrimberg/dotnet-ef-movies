FROM mcr.microsoft.com/dotnet/runtime:5.0.3 AS base
WORKDIR /movies

FROM mcr.microsoft.com/dotnet/sdk:5.0.200 AS build
WORKDIR /src
COPY . .
RUN dotnet tool install --global dotnet-ef --version 5.0.3
#RUN dotnet restore
#RUN dotnet build --configuration Release --no-restore

#FROM build AS test
#RUN dotnet test --no-restore --verbosity normal

#FROM build AS publish
#RUN dotnet publish --self-contained -r linux-x64 -c Release

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /src/app/bin/Release/net5.0/linux-x64/ .
#ENTRYPOINT ["dotnet", "app.dll"]
