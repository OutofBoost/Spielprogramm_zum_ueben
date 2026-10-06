using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbh.Test.ClassLibrary
{
    /// <summary>
    /// Repräsentiert ein Bauteil.
    /// </summary>
    internal class Bauteil
    {
        private string _bezeichnung;
        private decimal _stückpreis;
        private int _stückzahl;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Bauteil"/>-Klasse.
        /// </summary>
        public string Bezeichnung
        {
            get { return _bezeichnung; }
            set { _bezeichnung = value; }
        }

        public decimal Stückpreis
        {
            get { return _stückpreis; }
            set { _stückpreis = value; }
        }

        public int Stückzahl
        {
            get { return _stückzahl; }
            set { _stückzahl = value; }
        }
    }
}
