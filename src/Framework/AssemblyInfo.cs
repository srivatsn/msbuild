﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//-----------------------------------------------------------------------
// </copyright>
// <summary>Assembly info.</summary>
//-----------------------------------------------------------------------

using System;
using System.Reflection;
using System.Resources;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Windows.Markup;

// A combination of RequestMinimum and RequestOptional causes the permissions granted to 
// the assembly to only be the permission requested (like a PermitOnly). More generally
// the equation for the PermissionSet granted at load time is:
//
//        Granted = (MaxGrant intersect (ReqMin union ReqOpt)) - ReqRefuse
//
// Where,
//        MaxGrant -- the permissions granted by policy.
//        ReqMin -- the permissions that RequestMinimum is specified for.
//        ReqOpt -- the permissions that RequestOptional is specified for.
//        ReqRefuse -- the permissions that Request refuse is specified for.
//
// Note that if ReqOpt is the empty set, then it is consider to be "FullTrust" and this 
// equation becomes:
//
//        Granted = MaxGrant - ReqRefuse
//
// Regardless of whether ReqMin is empty or not.
#pragma warning disable 618
[assembly: SecurityPermission(SecurityAction.RequestMinimum, Flags = SecurityPermissionFlag.Execution)]
#pragma warning restore 618

[assembly: InternalsVisibleTo("Microsoft.Build.Framework.UnitTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010015c01ae1f50e8cc09ba9eac9147cf8fd9fce2cfe9f8dce4f7301c4132ca9fb50ce8cbf1df4dc18dd4d210e4345c744ecb3365ed327efdbc52603faa5e21daa11234c8c4a73e51f03bf192544581ebe107adee3a34928e39d04e524a9ce729d5090bfd7dad9d10c722c0def9ccc08ff0a03790e48bcd1f9b6c476063e1966a1c4")]
[assembly: InternalsVisibleTo("Microsoft.Build.Tasks.UnitTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010015c01ae1f50e8cc09ba9eac9147cf8fd9fce2cfe9f8dce4f7301c4132ca9fb50ce8cbf1df4dc18dd4d210e4345c744ecb3365ed327efdbc52603faa5e21daa11234c8c4a73e51f03bf192544581ebe107adee3a34928e39d04e524a9ce729d5090bfd7dad9d10c722c0def9ccc08ff0a03790e48bcd1f9b6c476063e1966a1c4")]
[assembly: InternalsVisibleTo("Microsoft.Build.Framework.Whidbey.Unittest, PublicKey=002400000480000094000000060200000024000052534131000400000100010015c01ae1f50e8cc09ba9eac9147cf8fd9fce2cfe9f8dce4f7301c4132ca9fb50ce8cbf1df4dc18dd4d210e4345c744ecb3365ed327efdbc52603faa5e21daa11234c8c4a73e51f03bf192544581ebe107adee3a34928e39d04e524a9ce729d5090bfd7dad9d10c722c0def9ccc08ff0a03790e48bcd1f9b6c476063e1966a1c4")]

// This is the assembly-level GUID, and the GUID for the TypeLib associated with
// this assembly.  We should specify this explicitly, as opposed to letting 
// tlbexp just pick whatever it wants.
[assembly: GuidAttribute("D8A9BA71-4724-481d-9CA7-0DA23A1D615C")]

[assembly: XmlnsDefinition("http://schemas.microsoft.com/build/2009/properties", "Microsoft.Build.Framework.XamlTypes")]

// This will enable passing the SafeDirectories flag to any P/Invoke calls/implementations within the assembly, 
// so that we don't run into known security issues with loading libraries from unsafe locations 
[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]

#if (LOCALIZED_BUILD)
// Needed for the "hub-and-spoke model to locate and retrieve localized resources": https://msdn.microsoft.com/en-us/library/21a15yht(v=vs.110).aspx
[assembly: NeutralResourcesLanguage("en", UltimateResourceFallbackLocation.Satellite)]
#endif

[assembly: CLSCompliant(true)]

[assembly: AssemblyTitle("Microsoft.Build.Framework.dll")]
[assembly: AssemblyDescription("Microsoft.Build.Framework.dll")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® Build Tools®")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
