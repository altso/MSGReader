// name       : VersionInfo.cs
// project    : System Framelet
// created    : Leon Poyyayil - 2007.01.12
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland

using System.Reflection;

// ReSharper disable CheckNamespace

namespace Itenso.Sys
// ReSharper restore CheckNamespace
{
    public sealed class VersionInfo
    {
        /// <value>Provides easy access to the assemblies version as a string.</value>
        public static readonly string AssemblyVersion = typeof(VersionInfo).Assembly.GetName().Version.ToString();
    }
}