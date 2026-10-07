using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
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
        /// Initialisiert neue Instanzen der <see cref="Bauteil"/>-Klasse.
        /// </summary>
        public string Bezeichnung
        {
            get { return _bezeichnung; }
            set { _bezeichnung = value; }
        }

        public decimal Stückpreis
        {
            get { return _stückpreis; }
            set 
            {
                if (value > 0)
                {
                    _stückpreis = value;

                }
                else
                {
                    throw new BauteilkostenZurGering($"Der Stückpreis von {Bezeichnung} muss größer als 0 sein!");
                }
            }
        }

        public int Stückzahl
        {
            get { return _stückzahl; }
            set 
            {
                if (value > 0)
                {
                    _stückzahl = value;
                }
                else
                {
                    throw new StückzahlZuGering($"Die Stückzahl von {Bezeichnung} kann nicht negativ sein!");
                }
            }
        }

        public Bauteil() { }
        public Bauteil(string bezeichnung, decimal stückpreis, int stückzahl)
        {
            Bezeichnung = bezeichnung;
            Stückpreis = stückpreis;
            Stückzahl = stückzahl;
        }

        public decimal BerechneGesamtwert()
        {
            return _stückpreis * _stückzahl;
        }

        public string GetInfo()
        {
            return $"Bauteil: {_bezeichnung}, Kosten pro Bauteil: {_stückpreis}€, Stückzahl: {_stückzahl}, Gesamtwert: {BerechneGesamtwert()}€";
        }
    }
}
