Remove-Item –path ./client –recurse

Invoke-WebRequest -Uri 'https://api.cloudmersive.com/virus/docs/v1/swagger' -OutFile '.\virus-api-swagger.json'
(Get-Content .\virus-api-swagger.json).replace('localhost', "api.cloudmersive.com") | Set-Content .\virus-api-swagger.json
(Get-Content .\virus-api-swagger.json).replace('"http"', '"https"') | Set-Content .\virus-api-swagger.json

& java -jar swagger-codegen-cli-2.4.45.jar generate -i .\virus-api-swagger.json -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client


$csprojpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.VirusScan/Cloudmersive.APIClient.NET.VirusScan.csproj
$csprojtestpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.VirusScan.Test/Cloudmersive.APIClient.NET.VirusScan.Test.csproj
$nuspecpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.VirusScan/Cloudmersive.APIClient.NET.VirusScan.nuspec
$slnpath = Resolve-Path ./client/Cloudmersive.APIClient.NET.VirusScan.sln


(Get-Content $nuspecpath).replace('<title>Swagger Library</title>', "<title>Image Recognition and Processing APIs</title><licenseUrl>https://www.apache.org/licenses/LICENSE-2.0.txt</licenseUrl>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<authors>$author$</authors>', "<authors>Cloudmersive</authors>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<owners>$author$</owners>', "<owners>Cloudmersive</owners>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<description>A library generated from a Swagger doc</description>', "<description>Cloudmersive Virus Scan allows you to scan files, URLs, and webistes for viruses, malware, trojans, ransomware, spyware, and many other types of threats.  Multi-factor scanninga cross many delivery methods including polymorphic and multipartite.  Scanning supports files, archives, and recursive file formats.</description>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<!-- Authors contain text that appears directly on the gallery -->', "<iconUrl>https://cloudmersive.com/images/cmsdk.png</iconUrl>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<dependencies>', "<projectUrl>https://cloudmersive.com/virus-api</projectUrl><dependencies>") | Set-Content $nuspecpath







# RestSharp 106.6.10 - Core Project
(Get-Content $csprojpath).replace('<PackageReference Include="RestSharp" Version="105.1.0" />', '<PackageReference Include="RestSharp" Version="106.6.10" />') | Set-Content $csprojpath

(Get-Content $nuspecpath).replace('<dependency id="RestSharp" version="105.1.0" />', '<dependency id="RestSharp" version="106.6.10" />') | Set-Content $nuspecpath

(Get-Content $csprojpath).replace('<TargetFrameworkVersion>v4.5</TargetFrameworkVersion>', '<TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>') | Set-Content $csprojpath
(Get-Content $csprojpath).replace('<Reference Include="RestSharp">', '<Reference Include="RestSharp, Version=106.6.10.0, Culture=neutral, PublicKeyToken=598062e77f915f75, processorArchitecture=MSIL">') | Set-Content $csprojpath

(Get-Content $csprojpath).replace('$(SolutionDir)\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '$(SolutionDir)\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath
(Get-Content $csprojpath).replace('..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath
(Get-Content $csprojpath).replace('..\..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath
(Get-Content $csprojpath).replace('..\..\vendor\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\vendor\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath

# RestSharp 106.6.10 - Test Project
(Get-Content $csprojtestpath).replace('<PackageReference Include="RestSharp" Version="105.1.0" />', '<PackageReference Include="RestSharp" Version="106.6.10" />') | Set-Content $csprojtestpath

(Get-Content $csprojtestpath).replace('<TargetFrameworkVersion>v4.5</TargetFrameworkVersion>', '<TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('<Reference Include="RestSharp">', '<Reference Include="RestSharp, Version=106.6.10.0, Culture=neutral, PublicKeyToken=598062e77f915f75, processorArchitecture=MSIL">') | Set-Content $csprojtestpath

(Get-Content $csprojtestpath).replace('$(SolutionDir)\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '$(SolutionDir)\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('..\..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
(Get-Content $csprojtestpath).replace('..\..\vendor\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\vendor\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath


# Packages.config

(Get-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\packages.config').replace('<package id="RestSharp" version="105.1.0" targetFramework="net45" developmentDependency="true" />', '<package id="RestSharp" version="106.6.10" targetFramework="net45" developmentDependency="true" />') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\packages.config'
(Get-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\Client\ApiClient.cs').replace('request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);', 'request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentLength, param.Value.ContentType);') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\Client\ApiClient.cs'







./nuget.exe restore $csprojpath -SolutionDirectory ./client

./nuget.exe restore $csprojtestpath -SolutionDirectory ./client

C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe $slnpath /t:rebuild 

& C:\CodeSigning\sign.ps1 ./client/src/Cloudmersive.ApiClient.NET.VirusScan/bin/Debug/Cloudmersive.APIClient.NET.VirusScan.dll

./nuget.exe pack $csprojpath

(Get-Content ./client/README.md).replace(' automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project', " for the [Cloudmersive Virus Scan API](https://www.cloudmersive.com/virus-api)") | Set-Content ./client/README.md

Copy-Item ./client/README.md ./README.md