@echo off
set package=%1
if "%package%"=="" set /p package="Enter package number: "
nuget push LLBLGen.Linq.Prefetch.%package%.nupkg