namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe1_Leseliste;

public partial class Form1 : Form
{
  private List<string> _leseliste = new();
  private int zulesen = 0;
  private int schongelesen = 0;
  public Form1()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    if (!string.IsNullOrWhiteSpace(TxtTitel.Text) &&
        !_leseliste.Any(titel => titel.Equals(TxtTitel.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
    {
      _leseliste.Add(TxtTitel.Text.Trim());
      TxtTitel.Clear();
      TxtTitel.Focus();
      zulesen++;
      AktualisiereListBox();
    }
    else if (string.IsNullOrWhiteSpace(TxtTitel.Text)) { MessageBox.Show($"Text Feld ist leer"); }

    else
    {
      MessageBox.Show($"Das Buch {TxtTitel.Text} gibt es schon!");
    }
  }

  private void CmdGelesen_Click(object sender, EventArgs e)
  {
    if (LstBuecher.SelectedIndex >= 0)
    {
      _leseliste.RemoveAt(LstBuecher.SelectedIndex);
      schongelesen++;
      zulesen--;
      AktualisiereListBox();
    }
    else
    {
      MessageBox.Show("Wähle einen Eintrag in der Liste zum löschen.");
    }
  }

  private void CmdSortieren_Click(object sender, EventArgs e)
  {
    _leseliste.Sort();
    AktualisiereListBox();
  }

  private void CmdAlleLoeschen_Click(object sender, EventArgs e)
  {
    _leseliste.Clear();
    zulesen = 0;
    schongelesen = 0;
    LstBuecher.Text = string.Empty;
    AktualisiereListBox();
  }

  private void AktualisiereListBox()
  {
    LstBuecher.Items.Clear();
    foreach (string a in _leseliste) LstBuecher.Items.Add(a);
    LblAnzahl.Text = $"Noch zu lesen: {zulesen} | Bereits gelesen: {schongelesen}";
  }
}

