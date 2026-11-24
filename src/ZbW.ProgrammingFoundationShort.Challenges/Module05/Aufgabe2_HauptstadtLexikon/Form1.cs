namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe2_HauptstadtLexikon;

public partial class Form1 : Form
{
  private static Dictionary<string, string> _lexi = new();
  public Form1()
  {
    InitializeComponent();
    _lexi.Add("Schweiz", "Bern");
    _lexi.Add("Deutschland", "Berlin");
    _lexi.Add("Österreich", "Wien");
    _lexi.Add("Spanien", "Madrid");
    _lexi.Add("Frankreich", "Paris");
  }

  private void CmdHauptstadt_Click(object sender, EventArgs e)
  {
    int counter = 0;
    if (!string.IsNullOrWhiteSpace(TxtSuche.Text))
    {
      foreach (var stadt in _lexi)
      {
        if (stadt.Key  == TxtSuche.Text)
        {
          TxtAusgabe.Text = stadt.Value;
          counter++;
        }
      }
      if(counter == 0)
      {
        MessageBox.Show("Keine Hauptstadt gefunden");
        TxtAusgabe.Text = "";
      }
    }
    else
    {
      MessageBox.Show("Kein gültiger Input!");
    }
  }

  private void CmdLand_Click(object sender, EventArgs e)
  {
    int counter = 0;
    if (!string.IsNullOrWhiteSpace(TxtSuche.Text))
    {
      foreach (var land in _lexi)
      {
        if (land.Value  == TxtSuche.Text)
        {
          TxtAusgabe.Text = land.Key;
          counter++;
        }
      }
      if(counter == 0)
      {
        MessageBox.Show("Kein Land gefunden");
        TxtAusgabe.Text = "";
      }
    }
    else
    {
      MessageBox.Show("Kein gültiger Input!");
    }
  }

  private void CmdEintragHinzufuegen_Click(object sender, EventArgs e)
  {
    if (!string.IsNullOrWhiteSpace(TxtLandNeu.Text) && !string.IsNullOrWhiteSpace(TxtStadtNeu.Text))
    {
      if (_lexi.ContainsKey(TxtLandNeu.Text))
      {
        MessageBox.Show("Land hat schon eine Stadt eingetragen.");
      }
      else
      {
        _lexi.Add(TxtLandNeu.Text,TxtStadtNeu.Text);
        MessageBox.Show($"{TxtLandNeu.Text} -> {TxtStadtNeu.Text} eingetragen.");
      }
    }
    else
    {
      MessageBox.Show("Kein gültiger Input! (Leere Felder)");
    }
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    TxtAusgabe.Text = "";
    foreach (var ausgabe in _lexi)
    {
      TxtAusgabe.Text += $"{ausgabe.Key} -> {ausgabe.Value}\r\n";
    }
  }
}

