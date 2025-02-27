﻿using PMDG_TerminalX.Base;
using PMDG_TerminalX.Common;
using System;
using System.Collections.Generic;
using System.Text;


namespace PMDG_TerminalX.Geo
{
    public class Latitude : GeoPointBase
    {
        public NorthSouth NSHemisphere => _decimalValue < 0 ? NorthSouth.South : NorthSouth.North;
        public override string ToString()
        {
            return base.ToString() + (NSHemisphere.ToStr());
        }
    }
}
