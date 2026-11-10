namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

// ============================================================
// AUFTRAG 2 – NotenVerwaltung (⭐⭐ Mittel | ~30 Min.)
//
// Verwaltet bis zu 10 Noten in einem double[]-Array.
//
// Anforderungen:
//   - TxtNote: Note (1.0–6.0) eingeben, CmdHinzufuegen: Note ins Array
//   - Zähler _anzahl für belegte Plätze, Button deaktivieren, wenn voll
//   - Methoden MIT Parametern: Average/Best/Worst(double[] noten, int anzahl)
//   - LblNoten: Noten sortiert als Komma-Liste (Kopie mit Array.Copy, dann Array.Sort)
//   - LblStats: Durchschnitt, beste und schlechteste Note
// ============================================================

public partial class NotenVerwaltungForm : Form
{
  // TODO 1: Felder deklarieren
  private double[] _noten = new double[10];
  private double[] _labelnoten = new double[10];
  private int _anzahl = 0;

  public NotenVerwaltungForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Note validieren (double.TryParse, 1.0–6.0)
    if (double.TryParse(TxtNote.Text, out double akutellenote) && !(akutellenote < 1.0 || akutellenote > 6.0)) {}
    else { MessageBox.Show("Keine gültige Note"); return; }

    // TODO 3: Note ins Array schreiben und _anzahl erhöhen
    _noten[_anzahl] = akutellenote;
    _anzahl++;
    // TODO 4: Wenn voll: CmdHinzufuegen.Enabled = false;
    if (_anzahl == 10) { CmdHinzufuegen.Enabled = false; }
    // TODO 5: Anzeige aktualisieren (sortierte Kopie + Statistik)
    Array.Copy(_noten, _labelnoten, _anzahl);
    Array.Sort(_labelnoten);
    LblStats.Text = $"Durchschnitt: {Average(_noten, _anzahl):F2}, Beste Note: {Best(_noten, _anzahl)}, Worst: {Worst(_noten, _anzahl)}";
    UpdateLabel(_labelnoten, _anzahl);
  }

  private double Average(double[] noten, int anzahl)
  {
    // TODO: Durchschnitt der ersten "anzahl" Noten
    double calcnoten = 0;
    for (int i = 0; i < anzahl; i++)
    {
      calcnoten += noten[i];
    }
    return calcnoten / anzahl;
  }

  private double Best(double[] noten, int anzahl)
  {
    // TODO: Höchste Note finden
    double akutellenote = noten[0];
    foreach (double note in noten)
    {
      if(akutellenote < note){ akutellenote = note;}
    }
    return akutellenote;
  }

  private double Worst(double[] noten, int anzahl)
  {
    // TODO: Niedrigste Note finden
    double akutellenote = noten[0];
    foreach (double note in noten)
    {
      if(akutellenote > note && note != 0){ akutellenote = note;}
    }
    return akutellenote;
  }

  private void UpdateLabel(double[] noten, int anzahl)
  {
    LblNoten.Text = "";
    int counter = 0;
    for (int i = 0; i < anzahl; i++)
    {
      if(noten[i + counter] == 0)
      {
        counter++;
        --i;
        continue;
      }
      else {LblNoten.Text += $"{noten[i+counter]}, ";}
    }
    foreach (double x in noten)
    {
      Array.Clear(_labelnoten, 0, _labelnoten.Length);
    }
  }
}
