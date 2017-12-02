del bin\test.dll

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319
csc /r:.\bin\WebApi.ActiveQueryBuilder.dll /r:.\bin\nunit.framework.dll /t:library /out:.\bin\test.dll test.cs

..\packages\NUnit.ConsoleRunner.3.2.1\tools\nunit3-console.exe .\bin\test.dll
