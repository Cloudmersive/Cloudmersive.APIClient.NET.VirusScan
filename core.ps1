# ─── helper: locate MSBuild 17.x (VS 2022 “Current”) ─────────────────────────────
function Get-LatestMsBuild {
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
    if (-not (Test-Path $vswhere)) {
        throw "vswhere.exe not found. Install VS Build Tools or Visual Studio 2022."
    }

    $installPath = & $vswhere -latest -requires Microsoft.Component.MSBuild -property installationPath
    if (-not $installPath) { throw "No VS installation with MSBuild found." }

    return Join-Path $installPath "MSBuild\Current\Bin\MSBuild.exe"
}
