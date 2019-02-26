#tool "nuget:?package=GitVersion.CommandLine&version=4.0.0"

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
string semVer = Argument("semver", "0.0.0");

///////////////////////////////////////////////////////////////////////////////
// VARIABLES
///////////////////////////////////////////////////////////////////////////////
var srcDirectory = "./src";
var distDirectory = "./dist";
var solutionFile = "./src/Nullforce.Api.DeviantArt.Rest.sln";

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(ctx =>
{
   // Executed BEFORE the first task.
   Information("Running tasks...");
});

Teardown(ctx =>
{
   // Executed AFTER the last task.
   Information("Finished running tasks.");
});

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("GetVersionInfo")
.Does(() => {
    if (semVer == "0.0.0" && DirectoryExists("./.git"))
    {
        var result = GitVersion();
        Information($"Branch: {result.BranchName}");
        Information($"Assembly File Version: {result.AssemblySemFileVer}");
        Information($"Assembly Version: {result.AssemblySemFileVer}");
        Information($"Full Sem Version: {result.FullSemVer}");
        Information($"Legacy Sem Version: {result.LegacySemVer}");
        Information($"Legacy Sem Version Padded: {result.LegacySemVerPadded}");
        Information($"Major Minor Patch: {result.MajorMinorPatch}");
        Information($"Sem Ver: {result.SemVer}");

        semVer = result.LegacySemVerPadded;
    }

    Information($"Using '{semVer}' as the version.");
});

Task("CleanStep")
.Does(() => {
    CleanDirectory(distDirectory);
});

Task("RestoreStep")
.Does(() =>
{
    DotNetCoreRestore(solutionFile);
});

Task("BuildStep")
.Does(() => {
    DotNetCoreBuild(solutionFile);
});

Task("TestStep")
.Does(() => {
    var testProjects = GetFiles("./src/**/*.Tests.csproj");
    foreach (var testProject in testProjects)
    {
        DotNetCoreTest(testProject.FullPath);
    }
});

Task("PackageStep")
.Does(() => {
    var settings = new DotNetCorePackSettings
    {
        Configuration = configuration,
        OutputDirectory = distDirectory,

        ArgumentCustomization = (args) => {
            return args
                .Append("/p:Version={0}", semVer);
        }
    };

    DotNetCorePack("./src/Nullforce.Api.DeviantArt.Rest/Nullforce.Api.DeviantArt.Rest.csproj", settings);
});

Task("Default")
.IsDependentOn("CleanStep")
.IsDependentOn("RestoreStep")
.IsDependentOn("GetVersionInfo")
.IsDependentOn("BuildStep")
.IsDependentOn("TestStep")
.IsDependentOn("PackageStep")
.Does(() => {
   Information("Hello Cake!");
});

RunTarget(target);