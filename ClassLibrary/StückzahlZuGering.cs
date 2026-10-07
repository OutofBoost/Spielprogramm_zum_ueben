using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
{
    public class StückzahlZuGering : Exception
    {
        public StückzahlZuGering(string message) : base(message) { }
    }
}
