rm ./bin/test.dll 2> /dev/null

mcs test.cs /r:./bin/WebApi.ActiveQueryBuilder.dll /r:./bin/nunit.framework.dll /t:library /out:./bin/test.dll

mono ./packages/NUnit.ConsoleRunner.3.2.1/tools/nunit3-console.exe ./bin/test.dll
