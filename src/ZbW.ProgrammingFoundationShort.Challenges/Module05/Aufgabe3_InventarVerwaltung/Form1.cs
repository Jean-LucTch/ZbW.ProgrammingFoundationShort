namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe3_InventarVerwaltung;

public partial class Form1 : Form
{
  private static Dictionary<string, int> _inventar = new();
  public Form1()
  {
    InitializeComponent();
    _inventar.Add("Kleberolle", 5);
    _inventar.Add("GPU", 20);
    _inventar.Add("CPU", 1337);
    _inventar.Add("M4-Schrauben", 50000);
    _inventar.Add("PS5", 1);
    countArtikel();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    if (!string.IsNullOrWhiteSpace(TxtArtikel.Text) && int.TryParse(TxtMenge.Text, out int value))
    {
      if (_inventar.ContainsKey(TxtArtikel.Text))
      {
        int aktuell = _inventar.GetValueOrDefault(TxtArtikel.Text);

        _inventar.Remove(TxtArtikel.Text);
        _inventar.Add(TxtArtikel.Text, aktuell + value);
        countArtikel();
      }
      else
      {
        _inventar.Add(TxtArtikel.Text, value);
        MessageBox.Show($"{TxtArtikel.Text} -> {TxtMenge.Text} eingetragen.");
        countArtikel();
      }
    }
    else
    {
      MessageBox.Show("Kein gültiger Input! (Leere Felder)");
    }
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    if (!string.IsNullOrWhiteSpace(TxtArtikel.Text) && int.TryParse(TxtMenge.Text, out int value))
    {
      if (_inventar.ContainsKey(TxtArtikel.Text))
      {
        int aktuell = _inventar.GetValueOrDefault(TxtArtikel.Text);

        _inventar.Remove(TxtArtikel.Text);

        if ((aktuell - value) < 0)
        {
          _inventar.Add(TxtArtikel.Text, 0);
        }
        else{_inventar.Add(TxtArtikel.Text, aktuell - value);}
        countArtikel();
      }
      else
      {
        MessageBox.Show($"{TxtArtikel.Text} gibts nicht.");
      }
    }
    else
    {
      MessageBox.Show("Kein gültiger Input! (Leere Felder)");
    }
  }

  private void CmdSuchen_Click(object sender, EventArgs e)
  {
    if (_inventar.ContainsKey(TxtArtikel.Text))
    {
      LstInventar.Items.Clear();
      LstInventar.Items.Add($"{TxtArtikel.Text} -> {_inventar.GetValueOrDefault(TxtArtikel.Text)}");
    }
    else
    {
      MessageBox.Show($"{TxtArtikel.Text} nicht gefunden!");
    }
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    LstInventar.Items.Clear();
    foreach (var ausgabe in _inventar)
    {
      if (ausgabe.Value == 0)
      {
        LstInventar.Items.Add($"{ausgabe.Key} -> {ausgabe.Value} <<Ausverkauft>>");
      }
      else
      {
        LstInventar.Items.Add($"{ausgabe.Key} -> {ausgabe.Value}");
      }
    }
  }

  private void countArtikel()
  {
    int sum = 0;
    foreach (var ausgabe in _inventar)
    {
      sum += ausgabe.Value;
    }
    LblGesamt.Text = $"Gesamtmenge: {sum.ToString()}";
  }
}

