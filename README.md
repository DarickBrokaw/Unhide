Force the computer to sleep with C# exe

I did not build this project in Visual Studio as it would not create a Single-file.exe deployment. Rather I used the command prompt to cd into the project folder and ran the following at the command prompt to build the .exe as a single file with no .dlls or other dependencies.

dotnet publish -r [win-x64] -c Release /p:PublishSingleFile=true --self-contained true

Reference: https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-publish
