. .\core.ps1

Remove-Item –path ./client –recurse

Invoke-WebRequest -Uri 'https://api.cloudmersive.com/virus/docs/v1/swagger' -OutFile '.\virus-api-swagger.json'
(Get-Content .\virus-api-swagger.json).replace('localhost', "api.cloudmersive.com") | Set-Content .\virus-api-swagger.json
(Get-Content .\virus-api-swagger.json).replace('"http"', '"https"') | Set-Content .\virus-api-swagger.json

java -jar ./openapi-generator-cli-7.12.0.jar generate -i virus-api-swagger.json -g csharp -o client -c packageconfig.json

## (Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
## (Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
## & npm build ./client


$csprojpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.VirusScan/Cloudmersive.APIClient.NET.VirusScan.csproj
$csprojtestpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.VirusScan.Test/Cloudmersive.APIClient.NET.VirusScan.Test.csproj
#$nuspecpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.VirusScan/Cloudmersive.APIClient.NET.VirusScan.nuspec
$slnpath = Resolve-Path ./client/Cloudmersive.APIClient.NET.VirusScan.sln


# (Get-Content $nuspecpath).replace('<title>Swagger Library</title>', "<title>Image Recognition and Processing APIs</title><licenseUrl>https://www.apache.org/licenses/LICENSE-2.0.txt</licenseUrl>") | Set-Content $nuspecpath
# (Get-Content $nuspecpath).replace('<authors>$author$</authors>', "<authors>Cloudmersive</authors>") | Set-Content $nuspecpath
# (Get-Content $nuspecpath).replace('<owners>$author$</owners>', "<owners>Cloudmersive</owners>") | Set-Content $nuspecpath
# (Get-Content $nuspecpath).replace('<description>A library generated from a Swagger doc</description>', "<description>Cloudmersive Virus Scan allows you to scan files, URLs, and webistes for viruses, malware, trojans, ransomware, spyware, and many other types of threats.  Multi-factor scanninga cross many delivery methods including polymorphic and multipartite.  Scanning supports files, archives, and recursive file formats.</description>") | Set-Content $nuspecpath
# (Get-Content $nuspecpath).replace('<!-- Authors contain text that appears directly on the gallery -->', "<iconUrl>https://cloudmersive.com/images/cmsdk.png</iconUrl>") | Set-Content $nuspecpath
# (Get-Content $nuspecpath).replace('<dependencies>', "<projectUrl>https://cloudmersive.com/virus-api</projectUrl><dependencies>") | Set-Content $nuspecpath




(Get-Content $csprojpath).replace('<RepositoryUrl>https://github.com/Cloudmersive/Cloudmersive.APIClient.NET.VirusScan.git</RepositoryUrl>', '<RepositoryUrl>https://github.com/Cloudmersive/Cloudmersive.APIClient.NET.VirusScan.git</RepositoryUrl><PackageProjectUrl>https://cloudmersive.com/virus-api</PackageProjectUrl><PackageIconUrl>https://cloudmersive.com/images/cmsdk.png</PackageIconUrl>') | Set-Content $csprojpath


# RestSharp 106.6.10 - Core Project
# (Get-Content $csprojpath).replace('<PackageReference Include="RestSharp" Version="105.1.0" />', '<PackageReference Include="RestSharp" Version="106.6.10" />') | Set-Content $csprojpath

# (Get-Content $nuspecpath).replace('<dependency id="RestSharp" version="105.1.0" />', '<dependency id="RestSharp" version="106.6.10" />') | Set-Content $nuspecpath

# (Get-Content $csprojpath).replace('<TargetFrameworkVersion>v4.5</TargetFrameworkVersion>', '<TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>') | Set-Content $csprojpath
# (Get-Content $csprojpath).replace('<Reference Include="RestSharp">', '<Reference Include="RestSharp, Version=106.6.10.0, Culture=neutral, PublicKeyToken=598062e77f915f75, processorArchitecture=MSIL">') | Set-Content $csprojpath

# (Get-Content $csprojpath).replace('$(SolutionDir)\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '$(SolutionDir)\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath
# (Get-Content $csprojpath).replace('..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath
# (Get-Content $csprojpath).replace('..\..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath
# (Get-Content $csprojpath).replace('..\..\vendor\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\vendor\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojpath

# # RestSharp 106.6.10 - Test Project
# (Get-Content $csprojtestpath).replace('<PackageReference Include="RestSharp" Version="105.1.0" />', '<PackageReference Include="RestSharp" Version="106.6.10" />') | Set-Content $csprojtestpath

# (Get-Content $csprojtestpath).replace('<TargetFrameworkVersion>v4.5</TargetFrameworkVersion>', '<TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>') | Set-Content $csprojtestpath
# (Get-Content $csprojtestpath).replace('<Reference Include="RestSharp">', '<Reference Include="RestSharp, Version=106.6.10.0, Culture=neutral, PublicKeyToken=598062e77f915f75, processorArchitecture=MSIL">') | Set-Content $csprojtestpath

# (Get-Content $csprojtestpath).replace('$(SolutionDir)\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '$(SolutionDir)\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
# (Get-Content $csprojtestpath).replace('..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
# (Get-Content $csprojtestpath).replace('..\..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\packages\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath
# (Get-Content $csprojtestpath).replace('..\..\vendor\RestSharp.105.1.0\lib\net45\RestSharp.dll', '..\..\vendor\RestSharp.106.6.10\lib\net452\RestSharp.dll') | Set-Content $csprojtestpath


# Packages.config

# (Get-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\packages.config').replace('<package id="RestSharp" version="105.1.0" targetFramework="net45" developmentDependency="true" />', '<package id="RestSharp" version="106.6.10" targetFramework="net45" developmentDependency="true" />') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\packages.config'
# (Get-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\Client\ApiClient.cs').replace('request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);', 'request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentLength, param.Value.ContentType);') | Set-Content '.\client\src\Cloudmersive.APIClient.NET.VirusScan\Client\ApiClient.cs'







./nuget.exe restore $csprojpath -SolutionDirectory ./client

./nuget.exe restore $csprojtestpath -SolutionDirectory ./client

#C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe $slnpath /t:rebuild
$configuration = 'Release'

# Strong name key is kept out of this repo. Every build machine must have
# C:\CodeSigning checked out with the StrongNameKeysDotNet key pair present.
$strongNameKey = 'C:\CodeSigning\StrongNameKeysDotNet\StrongNameKey.snk'
if (-not (Test-Path -LiteralPath $strongNameKey)) {
    throw "Strong name key not found at $strongNameKey. Ensure C:\CodeSigning is checked out on this build machine."
}

dotnet build $slnpath -c $configuration /p:SignAssembly=true /p:AssemblyOriginatorKeyFile=$strongNameKey

#$msbuild = Get-LatestMsBuild
#& $msbuild $slnpath /t:Rebuild /p:Configuration=$configuration

$builtDll = './client/src/Cloudmersive.APIClient.NET.VirusScan/bin/Release/netstandard2.0/Cloudmersive.APIClient.NET.VirusScan.dll'

# --- Strong-name diagnostic helper -------------------------------------------
function Test-StrongNameDiagnostic {
    param([string]$DllPath, [string]$Stage)

    Write-Host ""
    Write-Host "=== Strong-name check ($Stage) ===" -ForegroundColor Cyan
    Write-Host "DLL: $DllPath"

    # Prefer modern sn.exe (Windows Kits 10 / NETFX 4.x Tools) over the ancient v3.5 one.
    $snCandidates = @()
    foreach ($root in 'C:\Program Files (x86)\Windows Kits\10\bin','C:\Program Files\Windows Kits\10\bin') {
        if (Test-Path -LiteralPath $root) {
            $snCandidates += Get-ChildItem $root -Recurse -Filter sn.exe -ErrorAction SilentlyContinue |
                Where-Object { $_.FullName -match 'NETFX 4' -and $_.FullName -match 'x64' } |
                Sort-Object FullName -Descending | Select-Object -ExpandProperty FullName
        }
    }
    foreach ($root in 'C:\Program Files (x86)\Microsoft SDKs\Windows','C:\Program Files\Microsoft SDKs\Windows') {
        if (Test-Path -LiteralPath $root) {
            $snCandidates += Get-ChildItem $root -Recurse -Filter sn.exe -ErrorAction SilentlyContinue |
                Where-Object { $_.FullName -match 'NETFX 4' -and $_.FullName -match 'x64' } |
                Sort-Object FullName -Descending | Select-Object -ExpandProperty FullName
        }
    }
    $snCandidates += (Get-Command sn.exe -ErrorAction SilentlyContinue | Select-Object -ExpandProperty Source)
    # Fall back to any sn.exe we can find, preferring newer paths.
    foreach ($root in 'C:\Program Files (x86)\Microsoft SDKs\Windows','C:\Program Files\Microsoft SDKs\Windows') {
        if (Test-Path -LiteralPath $root) {
            $snCandidates += Get-ChildItem $root -Recurse -Filter sn.exe -ErrorAction SilentlyContinue |
                Sort-Object FullName -Descending | Select-Object -ExpandProperty FullName
        }
    }
    $snExe = $snCandidates | Where-Object { $_ -and (Test-Path -LiteralPath $_) } | Select-Object -First 1

    try {
        $asm = [System.Reflection.AssemblyName]::GetAssemblyName((Resolve-Path $DllPath))
        $token = ($asm.GetPublicKeyToken() | ForEach-Object { $_.ToString('x2') }) -join ''
        $pubKey = $asm.GetPublicKey()
        Write-Host "PublicKeyToken : $token"
        Write-Host "PublicKey size : $($pubKey.Length) bytes (160 = typical 2048-bit RSA public key blob)"
    } catch {
        Write-Host "Could not read assembly metadata: $($_.Exception.Message)" -ForegroundColor Red
    }

    # Independent check: read the CLR header's StrongNameSignature directory.
    # If size is zero, the assembly has no signature slot allocated at all (shouldn't happen
    # with SignAssembly=true). If size is non-zero and the slot contains all-zero bytes,
    # the assembly is delay-signed (public key + empty hash). Otherwise it is fully signed.
    try {
        $bytes = [System.IO.File]::ReadAllBytes((Resolve-Path $DllPath))
        $peOffset = [BitConverter]::ToInt32($bytes, 0x3C)
        $optHdrOffset = $peOffset + 24
        $magic = [BitConverter]::ToUInt16($bytes, $optHdrOffset)
        $cliHdrRvaOffset = if ($magic -eq 0x20B) { $optHdrOffset + 112 + 14*8 } else { $optHdrOffset + 96 + 14*8 }
        $cliHdrRva  = [BitConverter]::ToInt32($bytes, $cliHdrRvaOffset)
        $cliHdrSize = [BitConverter]::ToInt32($bytes, $cliHdrRvaOffset + 4)

        # Find the section containing the CLI header so we can translate RVA -> file offset.
        $numSections = [BitConverter]::ToUInt16($bytes, $peOffset + 6)
        $sizeOfOptHdr = [BitConverter]::ToUInt16($bytes, $peOffset + 20)
        $sectionTableOffset = $peOffset + 24 + $sizeOfOptHdr
        function Rva2Offset {
            param([int]$Rva, [byte[]]$Bytes, [int]$SectionTableOffset, [int]$NumSections)
            for ($i = 0; $i -lt $NumSections; $i++) {
                $s = $SectionTableOffset + 40*$i
                $vSize = [BitConverter]::ToInt32($Bytes, $s + 8)
                $vAddr = [BitConverter]::ToInt32($Bytes, $s + 12)
                $rawPtr = [BitConverter]::ToInt32($Bytes, $s + 20)
                if ($Rva -ge $vAddr -and $Rva -lt ($vAddr + $vSize)) {
                    return $rawPtr + ($Rva - $vAddr)
                }
            }
            return -1
        }
        $cliHdrFileOffset = Rva2Offset $cliHdrRva $bytes $sectionTableOffset $numSections
        # CLI header layout: StrongNameSignature directory is at offset 32 (RVA + size).
        $snRva  = [BitConverter]::ToInt32($bytes, $cliHdrFileOffset + 32)
        $snSize = [BitConverter]::ToInt32($bytes, $cliHdrFileOffset + 36)
        $clrFlags = [BitConverter]::ToInt32($bytes, $cliHdrFileOffset + 16)
        Write-Host ("CLR flags      : 0x{0:X8}  (bit 0x8 = StrongNameSigned)" -f $clrFlags)
        Write-Host ("StrongNameSig  : RVA=0x{0:X} size={1} bytes" -f $snRva, $snSize)
        if ($snSize -gt 0) {
            $snOffset = Rva2Offset $snRva $bytes $sectionTableOffset $numSections
            $allZero = $true
            for ($i = 0; $i -lt $snSize; $i++) { if ($bytes[$snOffset + $i] -ne 0) { $allZero = $false; break } }
            if ($allZero) {
                Write-Host "Signature slot : ALL ZEROS -> assembly is DELAY-SIGNED (no real signature)" -ForegroundColor Red
            } else {
                Write-Host "Signature slot : contains non-zero data (fully signed or signature present)" -ForegroundColor Green
            }
        } else {
            Write-Host "Signature slot : NOT ALLOCATED -> assembly is not strong-named at all" -ForegroundColor Red
        }
    } catch {
        Write-Host "PE header inspection failed: $($_.Exception.Message)" -ForegroundColor Yellow
    }

    if ($snExe) {
        Write-Host "Verifying with : $snExe"
        & $snExe -vf $DllPath
        Write-Host "sn.exe exit code: $LASTEXITCODE"
    } else {
        Write-Host "sn.exe not found; skipping signature verification." -ForegroundColor Yellow
    }
    Write-Host "=== end strong-name check ($Stage) ===" -ForegroundColor Cyan
    Write-Host ""
}

Test-StrongNameDiagnostic -DllPath $builtDll -Stage 'after dotnet build (pre-Authenticode)'

& C:\CodeSigning\sign-gcp.ps1 $builtDll

Test-StrongNameDiagnostic -DllPath $builtDll -Stage 'after Authenticode signing'

Write-Host "Packing..."

#./nuget.exe pack $csprojpath -Properties Configuration=$configuration

dotnet pack  $csprojpath -c $configuration -o ./nupkgs --no-build

(Get-Content ./client/README.md).replace(' automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project', " for the [Cloudmersive Virus Scan API](https://www.cloudmersive.com/virus-api)") | Set-Content ./client/README.md

Copy-Item ./client/README.md ./README.md