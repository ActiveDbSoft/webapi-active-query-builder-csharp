#!/bin/sh

cd ../

mono nuget.exe update -self
mono nuget.exe install Newtonsoft.Json -Version 8.0.3 -o packages
mono nuget.exe install RestSharp -Version 105.1.0 -o packages
mono nuget.exe install NUnit -Version 2.6.4 -o packages
mono nuget.exe install NUnit.Runners -Version 3.2.1 -o packages

sh build.sh

cd ./tests

mkdir -p ./bin

cp ../packages/NUnit.2.6.4/lib/nunit.framework.dll ./bin/nunit.framework.dll
cp ../packages/RestSharp.105.1.0/lib/net4/RestSharp.dll ./bin/RestSharp.dll
cp ../packages/Newtonsoft.Json.8.0.3/lib/net40/Newtonsoft.Json.dll ./bin/Newtonsoft.Json.dll
cp ../bin/WebApi.ActiveQueryBuilder.dll ./bin/WebApi.ActiveQueryBuilder.dll
