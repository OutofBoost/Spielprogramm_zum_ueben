using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
{
    public class Widerstand : Bauteil
    {
        private String _widerstandswert;

        public String Widerstandswert
        {
            get { return _widerstandswert; }
            set { _widerstandswert = value; }
        }

        public Widerstand(string bezeichnung, String widerstandswert, Bauform bauform, decimal stückpreis, int stückzahl) : base(bauform, bezeichnung, stückpreis, stückzahl)
        {
            Widerstandswert = widerstandswert;
        }

        public override string GetInfo()
        {
            StringBuilder bauteilinformation = new StringBuilder();
            bauteilinformation.AppendLine($"Bauteil: {Bezeichnung}, Widerstandswert: {Widerstandswert}Ohm, {base.GetInfo()}");
            return bauteilinformation.ToString();
        }
    }
}
