@echo off
set configuration=%1
if "%configuration%"=="" set /p configuration="Enter configuration (Release|Debug): "
nuget pack -sym LLBLGen.Linq.Prefetch.csproj -Properties Configuration=%configuration%
