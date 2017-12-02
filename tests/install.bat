cd ../

mono nuget.exe update -self
nuget.exe install Newtonsoft.Json -Version 8.0.3 -o packages
nuget.exe install RestSharp -Version 105.1.0 -o packages
nuget.exe install NUnit -Version 2.6.4 -o packages
nuget.exe install NUnit.Runners -Version 3.2.1 -o packages

call build.bat

cd ./tests

if not exist bin mkdir bin

copy ..\packages\NUnit.2.6.4\lib\nunit.framework.dll .\bin\nunit.framework.dll
copy ..\packages\RestSharp.105.1.0\lib\net4\RestSharp.dll .\bin\RestSharp.dll
copy ..\packages\Newtonsoft.Json.8.0.3\lib\net40\Newtonsoft.Json.dll .\bin\Newtonsoft.Json.dll
copy ..\bin\WebApi.ActiveQueryBuilder.dll .\bin\WebApi.ActiveQueryBuilder.dll
