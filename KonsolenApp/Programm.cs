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
            Widerstand widerstand = new Widerstand("Widerstand", "1k", Bauform.THT, 0.1m, 10);
            try
            {
                Kondesator kondesator = new Kondesator("Kondesator", "1000µF", Bauform.THT, 0.2m, 5);

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