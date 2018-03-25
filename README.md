# Introduction to Jenkins

[Jenkins Website](https://jenkins.io/)

[Download Nuget](https://www.nuget.org/downloads)  
[Download MSBuild](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=BuildTools&rel=15) (Path: C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe)    
[Download Git for windows](https://git-scm.com/download/win)  (Path: C:\Program Files\Git\bin\git.exe)  
[Download Nunit3-console](https://github.com/nunit/nunit-console/releases/tag/3.8) (Path: C:\Program Files (x86)\NUnit.org\nunit-console\nunit3-console.exe)  

MSTest: (Path: C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe)

MSTest: Path: C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\MSTest.exe

Some Jenkins Plugins we may need  
* Build Pipeline Plugin
* Powershell Plugin
* Git Plugin
* Warnings Plugin
* Nunit Plugin
* MSBuild Plugin

```
nuget restore
msbuild /t:Clean,Build
nunit3-console.exe dll
```

To move files in Powershell with excluding
```powershell
robocopy . ../UnitTest /E /xf .git* /xd .git*
exit 0
```

## Exercise
Create three different Jenkins jobs which they do these:
1. Git pull
2. Move it to the current workspace, then build and run tests.
3. Move it to another folder (This exemplifies deploying)