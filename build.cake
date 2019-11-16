/*
#########################################################################################
Installing

    Windows - powershell

        Invoke-WebRequest http://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
        .\build.ps1

        Get-ExecutionPolicy -List
        Set-ExecutionPolicy RemoteSigned -Scope Process
        Unblock-File .\build.ps1

    Windows - cmd.exe prompt

        powershell ^
            Invoke-WebRequest http://cakebuild.net/download/bootstrapper/windows -OutFile build.ps1
        powershell ^
            .\build.ps1

    Mac OSX

        rm -fr tools/; mkdir ./tools/ ; \
        cp cake.packages.config ./tools/packages.config ; \
        curl -Lsfo build.sh http://cakebuild.net/download/bootstrapper/osx ; \
        sh ./build.sh

        chmod +x ./build.sh ;
        ./build.sh

    Linux

        curl -Lsfo build.sh http://cakebuild.net/download/bootstrapper/linux
        chmod +x ./build.sh && ./build.sh

Running Cake to Build targets

    Windows

        tools\Cake\Cake.exe --verbosity=diagnostic --target=libs
        tools\Cake\Cake.exe --verbosity=diagnostic --target=nuget
        tools\Cake\Cake.exe --verbosity=diagnostic --target=samples


    Mac OSX

        mono tools/Cake/Cake.exe --verbosity=diagnostic --target=libs
        mono tools/Cake/Cake.exe --verbosity=diagnostic --target=nuget

        mono tools/nunit.consolerunner/NUnit.ConsoleRunner/tools/nunit3-console.exe \




#########################################################################################
*/
#addin nuget:?package=Cake.FileHelpers


//---------------------------------------------------------------------------------------
// unit testing
#tool nuget:?package=NUnit.ConsoleRunner&version=3.9.0
#tool nuget:?package=xunit.runner.console
//---------------------------------------------------------------------------------------
// coverage
#tool "nuget:?package=OpenCover"
// dotCover is commercial
// #tool "nuget:?package=JetBrains.dotCover.CommandLineTools"
//---------------------------------------------------------------------------------------
// reporting
#tool "nuget:?package=ReportUnit"
#tool "nuget:?package=ReportGenerator"

//---------------------------------------------------------------------------------------
var TARGET = Argument ("t", Argument ("target", "Default"));

string[] directories_to_clean = new string[]
{
    "./external/repos-downloaded/",
    "./output/",
    "./tools/",
    "./source/**/bin/",
    "./source/**/obj/",
    "./samples/**/bin/",
    "./samples/**/obj/",
    "./tests/**/bin/",
    "./tests/**/obj/",
    "./source/**/.vs/",
    "./samples/**/.vs/",
    "./tests/**/.vs/",
    "./source/**/.idea/",
    "./samples/**/.idea/",
    "./tests/**/.idea/",
    "./**/packages/",
};

string[] files_to_clean = new string[]
{
    "./**/*.binlog",
    "./**/.DS_Store",
};

string NUGET_VERSION="0.0.0.0";
//.....................................................................
// source (library)
string source_solutions = $"./source/**/*Source.sln";
string source_projects = $"./source/**/*.csproj";

FilePathCollection SourceLibSolutions = GetFiles(source_solutions);
FilePathCollection SourceLibProjects  = GetFiles(source_projects);
//.....................................................................

//.....................................................................
string samples_solutions = $"./samples/**/*Sample*.sln";
string samples_projects  = $"./samples/**/*.csproj";

FilePathCollection SamplesSolutions = GetFiles(samples_solutions);
FilePathCollection SamplesProjects  = GetFiles(samples_projects);
//.....................................................................

#load "./scripts/cake/common/externals.cake"
#load "./scripts/cake/private-protected-sensitive/externals.private.cake"
#load "./scripts/cake/common/main.cake"
#load "./scripts/cake/common/nuget-restore.cake"
#load "./scripts/cake/common/libs.cake"
#load "./scripts/cake/common/nuget-pack.cake"
#load "./scripts/cake/common/tests-unit-tests.cake"
#load "./scripts/cake/common/tests-benchmarks.cake"


// FilePathCollection UnitTestsNUnitMobileProjects = GetFiles($"./tests/unit-tests/project-references/**/*.NUnit.Xamarin*.csproj");
// FilePathCollection UnitTestsXUnitProjects = GetFiles($"./tests/unit-tests/project-references/**/*.XUnit.csproj");
// FilePathCollection UnitTestsMSTestProjects = GetFiles($"./tests/unit-tests/project-references/**/*.NUnit.csproj");


Task("Default")
.Does
    (
        () =>
        {
            RunTarget("libs");
            RunTarget("nuget");
            RunTarget("samples");
            //RunTarget("tests-unit-tests");
            //RunTarget("tests-benchmarks");
        }
    );

RunTarget (TARGET);

if( ! IsRunningOnWindows())
{
    try
    {
        int exit_code = StartProcess
                                (
                                    "tree",
                                    new ProcessSettings
                                    {
                                        Arguments = @"./output"
                                    }
                                );
    }
    catch(Exception ex)
    {
        Information($"unable to start process - tree {ex.Message}");
    }
}
else
{
    // int exit_code = StartProcess
    //                         (
    //                             "dir",
    //                             new ProcessSettings
    //                             {
    //                                 Arguments = @"output"
    //                             }
    //                         );

}
