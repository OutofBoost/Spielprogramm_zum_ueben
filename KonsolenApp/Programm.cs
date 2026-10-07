using InstaGmbH.Test.ClassLibrary;

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
            Bauteil spule = new Bauteil();
            try
            {
                spule = new Bauteil("Spule", 0.50m, -50);

            }
            catch (BauteilkostenZuGering ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
            catch(StückzahlZuGering ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }

            Console.WriteLine(widerstand.GetInfo());
            //spule.GetInfo();
        }
    }
}