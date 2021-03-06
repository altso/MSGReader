﻿// name       : IRtfFontCollection.cs
// project    : RTF Framelet
// created    : Leon Poyyayil - 2008.05.20
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland

using System.Collections;

namespace Itenso.Rtf
{
    public interface IRtfFontCollection : IEnumerable
    {
        int Count { get; }

        IRtfFont this[int index] { get; }

        IRtfFont this[string id] { get; }

        bool ContainsFontWithId(string fontId);

        void CopyTo(IRtfFont[] array, int index);
    }
}