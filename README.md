# coverage-test
Test .NET Core "solution" for multiple projects

Structure

* root
** .gitignore - standard .NET .gitignore file.
** global.json - specifies what folder the build system should search for projectes when resolving dependencies. See: https://docs.microsoft.com/en-us/dotnet/articles/core/tools/global-json
** omnisharp.json - configuration information for Omnisharp-Rosyln (may come with VS Code) 
** src - source code projects for this solution (this is not just code, but the project folders)
** test - test projects for this solution 

Add src packages:
# Open commandline 
# cd src
# yo aspnet: 