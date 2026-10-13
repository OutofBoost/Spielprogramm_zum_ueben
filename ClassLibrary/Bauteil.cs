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
        private Bauform _bauform;
        private readonly string _bezeichnung;
        private decimal _stückpreis;
        private int _stückzahl;

        /// <summary>
        /// Initialisiert neue Instanzen der <see cref="Bauteil"/>-Klasse.
        /// </summary>
        public Bauform Bauform
        {
            get { return _bauform; }
            set { _bauform = value; }
        }

        public string Bezeichnung
        {
            get { return _bezeichnung; }
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
                    throw new BauteilkostenZuGering($"Der Stückpreis von {Bezeichnung} muss größer als 0 sein!");
                }
            }
        }
        /// <summary>
        /// Gibt die Stückzahl des Bauteils zurück oder legt sie fest.
        /// </summary>
        public int Stückzahl
        {
            get { return _stückzahl; }
            set 
            {
                if (value >= 0)
                {
                    _stückzahl = value;
                }
                else
                {
                    throw new StückzahlZuGering($"Die Stückzahl von {Bezeichnung} kann nicht negativ sein!");
                }
            }
        }
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Bauteil"/>-Klasse.
        /// </summary>
        /// <param name="bauform"></param>
        /// <param name="bezeichnung"></param>
        /// <param name="stückpreis"></param>
        /// <param name="stückzahl"></param>
        public Bauteil(Bauform bauform, string bezeichnung, decimal stückpreis, int stückzahl) 
        {
            _bauform = bauform;
            _bezeichnung = bezeichnung;
            Stückpreis = stückpreis;
            Stückzahl = stückzahl;
        }
        /// <summary>
        /// Berechnet den Gesamtpreis des Bauteils basierend auf dem Stückpreis und der Stückzahl.
        /// </summary>
        /// <returns></returns>
        public decimal BerechneGesamtwert()
        {
            return _stückpreis * _stückzahl;
        }

        public virtual string GetInfo()
        {
            return $"Bauform: {Bauform}, Kosten pro Bauteil: {_stückpreis}€, Stückzahl: {_stückzahl}, Gesamtwert: {BerechneGesamtwert()}€";
        }
    }
}
