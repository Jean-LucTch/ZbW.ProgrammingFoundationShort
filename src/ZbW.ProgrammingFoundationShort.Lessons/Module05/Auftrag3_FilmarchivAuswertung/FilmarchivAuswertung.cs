namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag3_FilmarchivAuswertung;

// ============================================================
// AUFTRAG 3 – FilmarchivAuswertung (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Wertet ein Filmarchiv mit Dictionary, foreach und if aus.
// LINQ ist nur Bonus und wird hier nicht vorausgesetzt.
//
// Anforderungen:
//   - Dictionary<string, int>: Film → Erscheinungsjahr
//   - Alle Filme mit foreach ausgeben
//   - Filme ab 2000 mit foreach + if ausgeben
//   - Frühstes/spätestes Jahr und Anzahl Filme nach 2010 zählen
//   - Bonus: Dieselben Auswertungen mit LINQ lösen
// ============================================================

public static class FilmarchivAuswertung
{
  private static Dictionary<string, int> _filmen = new();
  public static void Start()
  {
    // Dictionary mit 8 Filmen anlegen
    //         "The Shawshank Redemption" → 1994, "The Dark Knight" → 2008, ...
    _filmen.Add("The Dark Knight", 2008);
    _filmen.Add("The Odyssey", 2026);
    _filmen.Add("Intouchables", 2011);
    _filmen.Add("The Hunger Games: The Ballad of Songbirds & Snakes", 2023);
    _filmen.Add("Star Wars: The Rise of Skywalker", 2019);
    _filmen.Add("Dune", 2021);
    _filmen.Add("The Empire Strikes Back", 1980);
    _filmen.Add("Zodiac", 2007);


    // Mit foreach und if auswerten:
    //         - Alle Filme ausgeben
    //         - Alle Filme ab 2000 ausgeben
    //         - Frühstes Erscheinungsjahr bestimmen
    //         - Spätestes Erscheinungsjahr bestimmen
    //         - Anzahl Filme nach 2010 zählen

    // Ergebnisse ausgeben

    var aelter = 0;
    var frueher = 10000;
    var after2010 = 0;

    Console.WriteLine("Alle Filme aus dem Archive:");
    foreach (var filme in _filmen)
    {
      Console.WriteLine($"{filme.Key} -> {filme.Value}");
    }

    Console.WriteLine($"\n\nAlle Filme ab 2000:");
    foreach (var filme in _filmen)
    {
      if (filme.Value >= 2000)
      {
        Console.WriteLine($"{filme.Key} -> {filme.Value}");
      }
    }

    Console.WriteLine($"\n\nFrühste Erscheinungsjahr: ");
    foreach (var filme in _filmen)
    {
      if (filme.Value < frueher){ frueher = filme.Value; }
    }
    Console.Write(frueher);

    Console.WriteLine($"\n\nSpäteste Erscheinungsjahr: ");
    foreach (var filme in _filmen)
    {
      if (filme.Value > aelter){ aelter = filme.Value; }
    }
    Console.Write(aelter);

    Console.WriteLine($"\n\nAnzahl Filme nach 2010: ");
    foreach (var filme in _filmen)
    {
      if (filme.Value > 2010)
      {
        after2010++;
      }
    }
    Console.Write(after2010);

    // BONUS: Dieselben Auswertungen zusätzlich mit LINQ formulieren.
  }
}
