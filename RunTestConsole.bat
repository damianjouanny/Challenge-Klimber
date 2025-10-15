@echo off
REM Script para compilar y ejecutar TestConsole

echo Compilando TestConsole...
"C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\Roslyn\csc.exe" /target:exe /out:TestConsole.exe /reference:DevelopmentChallenge.Data\bin\Debug\DevelopmentChallenge.Data.dll TestConsole.cs

if %ERRORLEVEL% NEQ 0 (
    echo Error al compilar TestConsole
    pause
    exit /b 1
)

echo Copiando DLLs necesarias...
copy /Y DevelopmentChallenge.Data\bin\Debug\DevelopmentChallenge.Data.dll . > nul
xcopy /E /I /Y DevelopmentChallenge.Data\bin\Debug\es es > nul
xcopy /E /I /Y DevelopmentChallenge.Data\bin\Debug\en en > nul
xcopy /E /I /Y DevelopmentChallenge.Data\bin\Debug\it it > nul

echo.
echo ========================================
echo Ejecutando TestConsole...
echo ========================================
echo.

TestConsole.exe

pause
