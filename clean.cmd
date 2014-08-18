REM Set your app's folder path appropriately here
SET APP_PATH=src\E5R.Krunt\

REM cleaning all the generated files and installed nuget packages
rmdir /S /Q .nuget
rmdir /S /Q  artifacts
rmdir /S /Q packages
rmdir /S /Q %APP_PATH%\bin
rmdir /S /Q %APP_PATH%\obj
