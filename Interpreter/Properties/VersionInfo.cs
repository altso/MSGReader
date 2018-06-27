// name       : VersionInfo.cs
// project    : RTF Framelet
// created    : Jani Giannoudis - 2008.05.29
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland

// ReSharper disable CheckNamespace

namespace Itenso.Rtf.Interpreter
// ReSharper restore CheckNamespace
{
    public sealed class VersionInfo
    {
        /// <value>Provides easy access to the assemblies version as a string.</value>
        public static readonly string AssemblyVersion = typeof(VersionInfo).Assembly.GetName().Version.ToString();
    } // class VersionInfo
}