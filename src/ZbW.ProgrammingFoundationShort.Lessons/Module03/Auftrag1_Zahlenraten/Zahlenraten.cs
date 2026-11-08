namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
    // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
    var random = new Random();
    int geheimzahl = random.Next(1, 101);



    // TODO 2: Variablen für Versuchszähler und geraten-Flag
    int versuche = 0;
    bool geraten = false;

    // TODO 3: while-Schleife (!geraten)
    //         - Eingabe lesen
    //         - int.TryParse prüfen
    //         - Hinweis ausgeben (zu klein / zu gross / richtig)
    //         - Versuchszähler erhöhen
    while (!geraten)
    {

      Console.Write("\nEingabe: ");
      if (int.TryParse(Console.ReadLine(), out int zahl)) { }

      if (zahl == geheimzahl) { Console.WriteLine("richtig"); geraten = true; }
      else if (zahl == 0) { Console.WriteLine("Unglütige Wert"); }
      else if (zahl > geheimzahl) { Console.WriteLine("zu gross"); }
      else if (zahl < geheimzahl) { Console.WriteLine("zu klein"); }
      else { Console.WriteLine("Ungültige eingabe"); }
      versuche += 1;
    }


    // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben
    Console.WriteLine($"\n\nGlückwunsch du hast {versuche} Versuche gebraucht");
  }
}
