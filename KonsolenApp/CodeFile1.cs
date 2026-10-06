using InstaGmbh.Test.ClassLibrary;

namespace InstaGmbH.Test.KonsolenApp
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Bauteile();
        }

        /// <summary>
        /// Demonstriert die Verwendung der Bauteil-Klasse.
        /// </summary>
        internal static void Bauteile()
        {
            Bauteil widerstand = new Bauteil("Widerstand", 0.10m, 100);
            Bauteil spule = new Bauteil("Spule", 0.50m, 50);

            widerstand.BerechneGesamtwert();
            spule.BerechneGesamtwert();

            Console.Write($"Bauteil: {widerstand.Bezeichnung}, Kosten pro Bauteil: {widerstand.Stückpreis}, Stückzahl: {widerstand.Stückzahl}, Gesamtwert: {widerstand.BerechneGesamtwert()}\n");
            Console.Write($"Bauteil: {spule.Bezeichnung}, Kosten pro Bauteil: {spule.Stückpreis}, Stückzahl: {spule.Stückzahl}, Gesamtwert: {spule.BerechneGesamtwert()}");
        }
    }
}