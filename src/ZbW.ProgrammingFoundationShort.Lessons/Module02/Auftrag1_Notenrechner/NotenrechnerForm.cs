namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

// ============================================================
// AUFTRAG 1 – Notenrechner (⭐ Einfach | ~15 Min.)
//
// Berechne eine Note anhand von Punkten mittels if/else-Kette.
//
// Anforderungen:
//   - TxtPunkte: Punktezahl (0–100) einlesen
//   - if/else-Kette:
//       90–100 → Note 6 / "Sehr gut"
//       75–89  → Note 5 / "Gut"
//       60–74  → Note 4 / "Genügend"
//       < 60   → Note 3 / "Ungenügend"
//   - Ergebnis in LblNote und LblBewertung anzeigen
// ============================================================

public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Punkte aus TxtPunkte lesen (int.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    if(int.TryParse(TxtPunkte.Text, out int punkte) && punkte <= 100 && punkte >=0) { }
    else { MessageBox.Show("Ungültige Eingabe"); LblBewertung.Text = ""; LblNote.Text = ""; return; }

    // TODO 2: if/else-Kette für Noten
    //         90-100 → Note 6 / "Sehr gut"
    //         75-89  → Note 5 / "Gut"
    //         60-74  → Note 4 / "Genügend"
    //         < 60   → Note 3 / "Ungenügend"

    int note;
    string bewertung;

    if (punkte <= 100 && punkte >= 90)
    {
      note = 6;
      bewertung = "Sehr gut";
    }
    else if (punkte <= 89 && punkte >= 75)
    {
      note = 5;
      bewertung = "Gut";
    }
    else if (punkte <= 74 && punkte >= 60)
    {
      note = 4;
      bewertung = "Genügend";
    }
    else
    {
      note = 3;
      bewertung = "Ungenügend";
    }

    // TODO 3: LblNote.Text und LblBewertung.Text setzen

    LblNote.Text = $"Note: {note}";
    LblBewertung.Text = bewertung;
  }
}
