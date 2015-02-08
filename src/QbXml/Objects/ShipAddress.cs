﻿using QBSync.QbXml.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QBSync.QbXml.Objects
{
    public class ShipAddress : Address
    {
        public StrType Name { get; set; }
        public BoolType DefaultShipTo { get; set; }
    }
}