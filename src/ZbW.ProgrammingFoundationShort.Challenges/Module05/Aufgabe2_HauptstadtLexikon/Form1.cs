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
    if (!string.IsNullOrWhiteSpace(TxtSuche.Text))
    {
      foreach (var stadt in _lexi)
      {
        if (stadt.Key == TxtSuche.Text)
        {
          TxtAusgabe.Text = stadt.Value;
        }
        else
        {
          MessageBox.Show("Keine Hauptstadt gefunden");
        }
      }
    }
    else
    {
      MessageBox.Show("Kein gültiger Input!");
    }
  }

  private void CmdLand_Click(object sender, EventArgs e)
  {
    throw new System.NotImplementedException();
  }

  private void CmdEintragHinzufuegen_Click(object sender, EventArgs e)
  {
    throw new System.NotImplementedException();
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    throw new System.NotImplementedException();
  }
}

