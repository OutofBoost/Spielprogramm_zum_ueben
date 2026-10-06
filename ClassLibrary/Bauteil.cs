using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbh.Test.ClassLibrary
{
    /// <summary>
    /// Repräsentiert ein Bauteil.
    /// </summary>
    public class Bauteil
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
        public Bauteil(string bezeichnung, decimal stückpreis, int stückzahl)
        {
            _bezeichnung = bezeichnung;
            _stückpreis = stückpreis;
            _stückzahl = stückzahl;
        }

        public decimal BerechneGesamtwert()
        {
            return _stückpreis * _stückzahl;
        }
    }
}
