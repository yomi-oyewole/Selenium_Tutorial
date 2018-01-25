@echo off
Set ConsoleRunnerExe=nunit3-console.exe /result:sampleTestResult.xml
Set TestDllPath= "c:\Users\Benjamin\source\repos\Selenium Tutorial\TestFramework\bin\Debug\TestFramework.dll"
Set Test=--test="TestFramework.TestSuite.LetsCodeTest"
start %ConsoleRunnerExe% %TestDllPath% %Test%