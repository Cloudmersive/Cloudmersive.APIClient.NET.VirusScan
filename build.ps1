﻿Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/virus -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client






(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive Virus Scan API Client</AssemblyTitle>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>Virus Scan API lets you scan files and content for viruses and identify security issues with content.</Description>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj







& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.VirusScan/Cloudmersive.APIClient.NETCore.VirusScan.csproj -c Release