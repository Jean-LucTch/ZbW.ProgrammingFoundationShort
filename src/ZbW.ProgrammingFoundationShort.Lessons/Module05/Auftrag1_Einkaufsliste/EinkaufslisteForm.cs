namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag1_Einkaufsliste;

// ============================================================
// AUFTRAG 1 – Einkaufsliste (⭐ Einfach | ~15 Min.)
//
// Verwaltet eine Einkaufsliste mit List<string>.
//
// Anforderungen:
//   - TxtArtikel: Artikel eingeben
//   - CmdHinzufuegen: Zur Liste hinzufügen
//   - CmdEntfernen: Ausgewählten Artikel entfernen
//   - CmdAlleLoeschen: Alle löschen
//   - LblAnzahl: Anzahl anzeigen
// ============================================================

public partial class EinkaufslisteForm : Form
{
  // Liste erstellen: private List<string> _artikel = new();
  private List<string> _artikel = new();
  public EinkaufslisteForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    int anzahl = 0;
    // Leere Eingabe prüfen
    if (TxtArtikel.Text != "")
    {
      // _artikel.Add(TxtArtikel.Text.Trim())
      _artikel.Add(TxtArtikel.Text.Trim());

      // ListBox aktualisieren, LblAnzahl setzen
      AktualisiereListBox();

      // TTxtArtikel leeren und fokussieren

      TxtArtikel.Clear();
      TxtArtikel.Focus();
    }
    else { MessageBox.Show("Feld Muss gefüllt sein"); }
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    // SelectedIndex prüfen (>= 0)
    if (LstArtikel.SelectedIndex >= 0)
    {
      // _artikel.RemoveAt(LstArtikel.SelectedIndex)  – Index statt Text (Duplikate!)
      _artikel.RemoveAt(LstArtikel.SelectedIndex);
      // ListBox aktualisieren
      AktualisiereListBox();
    }
    else
    {
      MessageBox.Show("Wähle einen Eintrag in der Liste zum löschen.");
    }
  }

  private void CmdAlleLoeschen_Click(object sender, EventArgs e)
  {
    // TODO 9: _artikel.Clear(), ListBox leeren, LblAnzahl = "0"
    LstArtikel.Items.Clear();
    _artikel.Clear();
    LblAnzahl.Text = $"Artikel: {_artikel.Count}";
  }

  private void AktualisiereListBox()
  {
    //          LstArtikel.Items.Clear();
    //          foreach (string a in _artikel) LstArtikel.Items.Add(a);
    //          LblAnzahl.Text = $"Artikel: {_artikel.Count}";
    LstArtikel.Items.Clear();
    foreach (string a in _artikel) LstArtikel.Items.Add(a);
    LblAnzahl.Text = $"Artikel: {_artikel.Count}";
  }
}
