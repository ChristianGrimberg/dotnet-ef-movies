FROM  csgrimberg/mssqlserver:latest AS Database
WORKDIR /var/opt/mssql/scripts/
COPY movies/scripts/ .
RUN chmod +x entrypoint.sh configure-db.sh

FROM Database AS Build
RUN mkdir /src /src/movies
WORKDIR /src
COPY dotnet-ef-movies.sln .
COPY movies/movies.csproj movies/
COPY movies/Program.cs movies/
COPY movies/appsettings.json movies/
RUN dotnet restore
RUN dotnet build --configuration Release --no-restore

#FROM build AS test
#RUN dotnet test --no-restore --verbosity normal

FROM Build AS Publish
RUN dotnet publish --self-contained -r linux-x64 -c Release

FROM Database AS Final
WORKDIR /movies
COPY --from=Publish /src/movies/bin/Release/net5.0/linux-x64/ .
COPY --from=Build /src /src
#CMD [ "/opt/mssql/bin/sqlservr" ]
ENTRYPOINT [ "/var/opt/mssql/scripts/entrypoint.sh" ]
#ENTRYPOINT ["dotnet", "movies.dll"]

# Tail the setup logs to trap the process
CMD ["tail -f /dev/null"]

HEALTHCHECK --interval=300s CMD /opt/mssql-tools/bin/sqlcmd -U sa -P $SA_PASSWORD -Q "select 1" && grep -q "MSSQL SERVER HAS STARTED" ./config.log

# Default SQL Server TCP/Port.
EXPOSE 1433