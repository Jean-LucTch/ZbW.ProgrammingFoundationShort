namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

// ============================================================
// AUFTRAG 2 – WoerterbuchApp (⭐⭐ Mittel | ~30 Min.)
//
// Übersetzungs-App mit Dictionary<string,string>.
//
// Anforderungen:
//   - 5 Wörter vorausfüllen (Deutsch → Englisch)
//   - TxtSuche + CmdNachschlagen: TryGetValue für Übersetzung
//   - TxtKeyNeu + TxtValueNeu + CmdHinzufuegen: ContainsKey-Prüfung
//   - LstEintraege: alle Einträge anzeigen
// ============================================================

public partial class WoerterbuchAppForm : Form
{
  private Dictionary<string, string> _woerterbuch = new();

  public WoerterbuchAppForm()
  {
    InitializeComponent();

    _woerterbuch.Add("Hund", "Dog");
    _woerterbuch.Add("Katze", "Cat");
    _woerterbuch.Add("Koch", "Chef");
    _woerterbuch.Add("Huhn", "Chicken");
    _woerterbuch.Add("Videospiel", "Videogame");

    AktualisiereListBox();
  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    // TryGetValue für TxtSuche.Text
    // Gefunden: LblErgebnis anzeigen
    // Nicht gefunden: "Kein Eintrag für..."
    if (_woerterbuch.TryGetValue(TxtSuche.Text, out string wert)){LblErgebnis.Text = wert;}
    else
    {
      LblErgebnis.Text = $"Kein Eintrag gefunden für: {TxtSuche.Text}";
    }
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // Leere Felder prüfen
    // ContainsKey-Prüfung → Überschreiben bestätigen
    // _woerterbuch[key] = value;
    // AktualisiereListBox()
    if (TxtKeyNeu.Text == "" || TxtValueNeu.Text == "")
    {
      MessageBox.Show("Beide Textboxen müssen gefüllt sein!");
    }
    else if (_woerterbuch.ContainsKey(TxtKeyNeu.Text))
    {
      DialogResult ergebnis = MessageBox.Show(
        $"Willst du {TxtKeyNeu.Text} wirklich überschreiben?", // Text der Meldung
        "Überschreiben",                                    // Titel des Fensters
        MessageBoxButtons.YesNo,                                   // Ja- und Nein-Buttons
        MessageBoxIcon.Question                                    // Optionales Fragezeichen-Icon
      );
      if (ergebnis == DialogResult.Yes)
      {
        _woerterbuch[TxtKeyNeu.Text] = TxtValueNeu.Text;
        AktualisiereListBox();
      }
    }
    else
    {
      _woerterbuch.Add(TxtKeyNeu.Text, TxtValueNeu.Text);
      AktualisiereListBox();
    }
  }

  private void AktualisiereListBox()
  {
    // LstEintraege befüllen aus _woerterbuch
    LstEintraege.Items.Clear();
    foreach (var a in _woerterbuch)
    {
      LstEintraege.Items.Add($"{a.Key} -> {a.Value}");
    }
  }
}
