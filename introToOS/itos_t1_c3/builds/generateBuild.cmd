REM this is a comment
:: this is a comment
:: echo, if, goto,

if "%1"=="help" goto help

echo "Hello World"
goto end

:help
@echo Usage: %0

dir /w