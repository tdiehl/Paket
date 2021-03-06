﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket.Core")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A package dependency manager for .NET with support for NuGet packages and GitHub repositories.")>]
[<assembly: AssemblyVersionAttribute("2.31.1")>]
[<assembly: AssemblyFileVersionAttribute("2.31.1")>]
[<assembly: AssemblyInformationalVersionAttribute("2.31.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.31.1"
