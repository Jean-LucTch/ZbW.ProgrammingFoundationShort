namespace ZbW.ProgrammingFoundationShort.Lessons;

// ============================================================
// STARTUP-KONFIGURATION
// Kommentiere die Form ein, die du testen möchtest.
// Alle anderen Zeilen müssen auskommentiert sein.
// ============================================================

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();

    // ---- Modul 01 ----
    ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner.Taschenrechner.Start();
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner.TemperaturrechnerForm());
    // ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz.DatentypQuiz.Start();

    // ---- Modul 02 ----
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner.NotenrechnerForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp.WochentageAppForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator.RabattKalkulatorForm());

    // ---- Modul 03 ----
    // ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten.Zahlenraten.Start();
    // ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator.PasswortValidator.Start();
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser.SichererDateiLeserForm());

    // ---- Modul 04 ----
    // ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner.StatistikRechner.Start();
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung.NotenVerwaltungForm());
    // ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag3_MatrixMultiplikation.MatrixRechner.Start();

    // ---- Modul 05 ----
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag1_Einkaufsliste.EinkaufslisteForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp.WoerterbuchAppForm());
    // ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag3_FilmarchivAuswertung.FilmarchivAuswertung.Start();

    // ---- Modul 06 ----
    // ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag1_BankAccount.BankAccountDemo.Start();
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag2_FahrzeugVerwaltung.FahrzeugVerwaltungForm());
    // ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag3_ValidierteProperties.PersonDemo.Start();

    // ---- Modul 07 ----
    // ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag1_ReferenzExperiment.ReferenzExperimentDemo.Start();
    // ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag2_EqualsUeberschreiben.ProductEqualsDemo.Start();
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager.KontaktmanagerForm());

    // ---- Modul 08 ----
    // ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag1_StatischerZaehler.StatischerZaehlerDemo.Start();
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils.MathUtilsForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger.TrafficLightForm());

    // ---- Modul 09 ----
    // ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag1_AnimalHierarchy.AnimalHierarchy.Start();
    // ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag2_AbstractShape.ShapeDemo.Start();
    // ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_MediaHierarchy.MediaDemo.Start();

    // ---- Modul 10 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag1_AblaufPlanen.AblaufPlanen.EvaluatePointsDraft(85));
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag2_TodosUmsetzen.TodosUmsetzen.RunDemo());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag3_DatenstrukturWahl.DatenstrukturWahl.RunDemo());

    // ---- Modul 11 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module11.Auftrag1_IterationRekursion._Loesung.IterationRekursionLoesung.RunDemo());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module11.Auftrag2_BinaereSuche._Loesung.BinaereSucheLoesung.RunDemo());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module11.Auftrag3_GreedyWechselgeld._Loesung.GreedyWechselgeldLoesung.RunDemo());

    // ---- Modul 12 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module12.Auftrag1_StackQueue._Loesung.StackQueueBeispieleLoesung.RunDemo());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module12.Auftrag2_HashSetDictionary._Loesung.HashSetDictionaryBeispieleLoesung.RunDemo());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module12.Auftrag3_PriorityQueue._Loesung.PriorityQueueBeispieleLoesung.RunDemo());
  }
}

