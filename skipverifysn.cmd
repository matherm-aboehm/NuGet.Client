for /D %%F in ("%WindowsSDK_ExecutablePath_x86%";"%WindowsSDK_ExecutablePath_x64%") DO (
"%%~F"sn.exe /Vr NuGet.Build.Tasks,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Commands,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Common,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Configuration,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Console,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.Credentials,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.DependencyResolver.Core,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Frameworks,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Indexing,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.LibraryModel,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.PackageManagement,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.PackageManagement.PowerShellCmdlets,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.PackageManagement.UI,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.PackageManagement.VisualStudio,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.Packaging,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.ProjectModel,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Protocol,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.Resolver,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.SolutionRestoreManager,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.Tools,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.Versioning,31bf3856ad364e35
"%%~F"sn.exe /Vr NuGet.VisualStudio,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.VisualStudio.Common,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.VisualStudio.Implementation,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGet.VisualStudio.Interop,b03f5f7f11d50a3a
"%%~F"sn.exe /Vr NuGetConsole.Host.PowerShell,31bf3856ad364e35
"%%~F"sn.exe /Vr Microsoft.Build.NuGetSdkResolver,31bf3856ad364e35

"%%~F"sn.exe /Vl
)