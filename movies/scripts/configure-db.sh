#!/bin/bash

echo "======= STARTING MSSQL SERVER ========" | tee -a ./config.log

# wait for MSSQL server to start
export STATUS=1
i=0

while [[ $STATUS -ne 0 ]] && [[ $i -lt $TIMEOUT ]]; do
	i=$i+1
	/opt/mssql-tools/bin/sqlcmd -t 1 -U sa -P $SA_PASSWORD -Q "SELECT 1;" >> /dev/null
	STATUS=$?
	sleep 0.5
done

if [ $STATUS -ne 0 ]; then 
	echo "Error: MSSQL SERVER took more than 30 seconds to start up."
	exit 1
fi

echo "======= MSSQL SERVER HAS STARTED ========" | tee -a ./config.log