#!/bin/sh

mono ../nuget.exe install ./packages/packages.config -o packages
mono ../nuget.exe install NUnit.Runners -Version 3.2.1 -OutputDirectory packages

mkdir -p ./bin

cp ./packages/NUnit.2.6.4/lib/nunit.framework.dll ./bin/nunit.framework.dll
cp ./packages/RestSharp.105.1.0/lib/net4/RestSharp.dll ./bin/RestSharp.dll
cp ./packages/Newtonsoft.Json.8.0.3/lib/net40/Newtonsoft.Json.dll ./bin/Newtonsoft.Json.dll
cp ../bin/WebApi.ActiveQueryBuilder.dll ./bin/WebApi.ActiveQueryBuilder.dll
