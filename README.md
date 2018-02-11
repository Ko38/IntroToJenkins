## Introduction to Jenkins

[Download Nuget](https://www.nuget.org/downloads)  
[Download MSBuild](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=BuildTools&rel=15) (Path: C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe)    
[Download Git for windows](https://git-scm.com/download/win)  (Path: C:\Program Files\Git\bin\git.exe)  
[Download Nunit3-console](https://github.com/nunit/nunit-console/releases/tag/3.8) (Path: C:\Program Files (x86)\NUnit.org\nunit-console\nunit3-console.exe)  

Some Jenkins Plugins we may need  
* Build Pipeline Plugin
* Powershell Plugin
* Git Plugin
* Warnings Plugin
* Nunit Plugin
* MSBuild Plugin

```
nuget restore
msbuild \t:Clean
nunit3-console.exe dll
```