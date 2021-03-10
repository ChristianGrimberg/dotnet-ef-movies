#!/bin/bash

# Start SQL Server
/opt/mssql/bin/sqlservr &

# Start the script to create the DB and user
/var/opt/mssql/scripts/configure-db.sh

# Information about the DbContext
sleep 2
echo "======= SEE THE DB CONTEXT & MIGRATE CODE FIRST TO DATABASE ========" | tee -a ./config.log
$HOME/.dotnet/tools/dotnet-ef --project /src/movies dbcontext info
$HOME/.dotnet/tools/dotnet-ef --project /src/movies migrations add Test
$HOME/.dotnet/tools/dotnet-ef --project /src/movies migrations list
$HOME/.dotnet/tools/dotnet-ef --project /src/movies database update -v

# Run the application
sleep 2
echo "======= RUN THE APPLICATION ========" | tee -a ./config.log
dotnet /movies/movies.dll "Test"

# Call extra command
eval $1