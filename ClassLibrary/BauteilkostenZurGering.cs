using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
{
    public class BauteilkostenZuGering : Exception
    {
                public BauteilkostenZuGering(string message) : base(message) { }
    }
}
