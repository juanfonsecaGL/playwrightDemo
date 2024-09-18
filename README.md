# playwrightDemo
2024 Juan Fonseca for GL. Based on [workshop](https://drive.google.com/file/d/16Jv9SwX9UOOwhfEDlfwbF2yQFdKcyK_7/view?usp=drive_link) provided by Marlon Cabraca for GL.

## VSCode setup
* Extensions > Playwright Test for VSCode.
* Gear icon > Command Palette > Test: Install PlayWright

## Installation
Followed the instructions explained [here](https://playwright.dev/dotnet/docs/intro):
1. Run `dotnet new nunit -n PlaywrightTestsDotNet.
2. Open the created folder.
3. Run `dotnet add package Microsoft.Playwright.NUnit`.
4. Run `brew install powershell/tap/powershell`.
5. Run `pwsh bin/Debug/net8.0/playwright.ps1 install`.

**Note:** contrary to what was explained [here](https://news.ycombinator.com/item?id=27460329), I didn't have to install NodeJS.

## Execution
1. Run `dotnet build`.
2. Run `dotnet test`.

## Reporting
Per issues [#1](https://github.com/microsoft/playwright-dotnet/issues/2681) there is no native reporting for DotNet yet.
