REM Ocultando la salida
@echo off
REM Script:       EjecutarPowerShell.bat
REM Descripción:  Este script ejecuta un archivo de script de PowerShell de manera asincrónica.
REM Autor:        Andrés García
REM Fecha:        28 de agosto de 2023

REM Inicio del script
echo Iniciando el script para ejecutar un archivo de script de PowerShell asincrónicamente...

REM Comando para ejecutar el archivo de script de PowerShell de manera asincrónica
start /b powershell.exe -ExecutionPolicy Bypass -File "program.ps1"

REM Fin del script
echo Ejecución de script de PowerShell en segundo plano iniciada.
