using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
{
    public class Kondesator : Bauteil
    {
        private String _kapazität;
        public String Kapazität
        {
            get { return _kapazität; }
            set { _kapazität = value; }
        }
        public Kondesator(string bezeichnung, String kapazität, Bauform bauform, decimal stückpreis, int stückzahl) : base(bauform, bezeichnung, stückpreis, stückzahl)
        {
            Kapazität = kapazität;
        }

        public override string GetInfo()
        {
            StringBuilder bauteilinformation = new StringBuilder();
            bauteilinformation.AppendLine($"Bauteil: {Bezeichnung}, Kapazität: {Kapazität}F, {base.GetInfo()}");
            return bauteilinformation.ToString();
        }
    }
}
