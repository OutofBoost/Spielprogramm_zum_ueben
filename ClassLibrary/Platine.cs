using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGmbH.Test.ClassLibrary
{
    public class Platine
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Platine"/>-Klasse.
        /// </summary>
        private string _platinenBezeichnung;
        private List<Bauteil> _bauteile = new List<Bauteil>();

        public string PlatinenBezeichnung
        {
            get { return _platinenBezeichnung; }
            set { _platinenBezeichnung = value; }
        }
        /// <summary>
        /// Fügt ein Bauteil zur Platine hinzu.
        /// </summary>
        /// <param name="bauteil"></param>
        public void Bauteilhinzufügen(Bauteil bauteil)
        {
            _bauteile.Add(bauteil);
        }
        /// <summary>
        /// Entfernt ein Bauteil von der Platine.
        /// </summary>
        /// <param name="bauteil"></param>
        public void Bauteilentfernen(Bauteil bauteil)
        {
            _bauteile.Remove(bauteil);
        }
        /// <summary>
        /// Erstellt eine List der Bauteile auf der Platine.
        /// </summary>
        /// <returns></returns>
        public string StücklisteErstellen()
        {
            StringBuilder Stückliste = new StringBuilder();
            foreach (var bauteil in _bauteile)
            {
                Stückliste.AppendLine($"Bezeichnung: {bauteil.Bezeichnung}, Bauform: {bauteil.Bauform}, Stückpreis: {bauteil.Stückpreis}, Stückzahl: {bauteil.Stückzahl}");
            }
            return Stückliste.ToString();
        }
        /// <summary>
        /// Berechnet die Gesamtkosten der Platine basierend auf den Bauteilen.
        /// </summary>
        /// <returns></returns>
        public decimal BerechneGesamtkosten()
        {
            decimal gesamtkosten = 0;
            foreach (var bauteil in _bauteile)
            {
                decimal kosten = bauteil.Stückpreis * bauteil.Stückzahl;
                Console.WriteLine($"Bauteil: {bauteil.Bezeichnung}, Kosten: {kosten}");
                gesamtkosten += kosten;
            }
            return gesamtkosten;
        }
    }
}
