using System.Diagnostics.Metrics;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

// ============================================================
// AUFTRAG 1 – StatistikRechner (⭐ Einfach | ~15 Min.)
//
// Liest 5 Zahlen ein und berechnet Minimum, Maximum, Durchschnitt.
//
// Anforderungen:
//   - int[5]-Array per Konsoleneingabe befüllen
//   - Methoden: Minimum(int[]), Maximum(int[]), Average(int[])
//   - Ergebnis ausgeben
// ============================================================

public static class StatistikRechner
{
  public static void Start()
  {
    // TODO 1: int[5]-Array deklarieren
    //         5 Zahlen einlesen und im Array speichern
    int counter = 1;
    int[] zahlenarray = new int[5];
    Console.WriteLine("Gebe 5 Zahlen ein");

    for (int i = 0; i < 5; i++)
    {
      Console.Write($"\n{counter}. Zahl vergeben: ");
      if (int.TryParse(Console.ReadLine(), out int akutellezahl)) { }
      else { MessageBox.Show("Keine Gültige Zahl eingegeben"); i--; continue; }

      zahlenarray[i] = akutellezahl;
      counter++;
    }

    // TODO 2: Methoden aufrufen und Ergebnis ausgeben
    //         Console.WriteLine($"Min: {Minimum(zahlen)}, Max: {Maximum(zahlen)}, Avg: {Average(zahlen):F2}");
    Console.WriteLine($"\r\nMin: {Minimum(zahlenarray)}, Max: {Maximum(zahlenarray)}, Avg: {Average(zahlenarray):F2}");
  }

  public static int Minimum(int[] zahlen)
  {
    // TODO: Kleinste Zahl finden (Schleife, kein LINQ)
    int counter = 0;
    int akuellezahl = zahlen[0];
    do
    {
      if (zahlen[counter] < akuellezahl)
      {
        akuellezahl = zahlen[counter];
      }

      counter++;
    } while (counter < 5);
    return akuellezahl;
  }

  public static int Maximum(int[] zahlen)
  {
    // TODO: Grösste Zahl finden (Schleife, kein LINQ)
    int counter = 0;
    int akuellezahl = zahlen[0];
    do
    {
      if (zahlen[counter] > akuellezahl)
      {
        akuellezahl = (int)zahlen[counter];
      }

      counter++;
    } while (counter < 5);
    return akuellezahl;
  }

  public static double Average(int[] zahlen)
  {
    // TODO: Durchschnitt berechnen (Summe / Länge)
    int summe = 0;
    foreach(int i in zahlen)
    {
      summe += i;
    }
    return summe / 5;
  }
}
