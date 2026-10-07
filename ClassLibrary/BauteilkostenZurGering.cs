using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
{
    public class BauteilkostenZurGering : Exception
    {
                public BauteilkostenZurGering(string message) : base(message) { }
    }
}
