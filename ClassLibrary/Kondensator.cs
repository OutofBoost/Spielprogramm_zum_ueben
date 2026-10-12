using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
{
    public class Kondensator : Bauteil
    {
        private String _kapazität;
        public String Kapazität
        {
            get { return _kapazität; }
            set { _kapazität = value; }
        }
        public Kondensator(string bezeichnung, String kapazität, Bauform bauform, decimal stückpreis, int stückzahl) : base(bauform, bezeichnung, stückpreis, stückzahl)
        {
            Kapazität = kapazität;
        }

        public override string GetInfo()
        {
            Console.WriteLine($"Bauteil: {Bezeichnung}, Kapazität: {Kapazität}F, {base.GetInfo()}");
            return string.Empty;
        }
    }
}
