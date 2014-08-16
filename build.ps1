Write-Host "Build from PowerShell..."
Write-Host ""

$NUGET=".nuget\NuGet.exe"
$KREVERSION="1.0.0-alpha4-10274"

Write-Host "Select KRE..."
kvm use $KREVERSION -svrc50 -x64

echo Restore...
kpm restore

echo Building...
kpm build

echo Pack...
kpm pack
