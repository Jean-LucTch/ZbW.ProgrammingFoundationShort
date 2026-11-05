namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe1_Multiplikationstabelle
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void CmdAnzeigen_Click(object sender, EventArgs e)
    {
      if (int.TryParse(TxtZahl.Text, out int zahl) && !(zahl < 1 || zahl > 10)) {  }
      else { MessageBox.Show("Deine Zahl ist nicht zwischen 1-10"); return; }
      TxtAusgabe.Text = "";


      if (!ChkRueckwaerts.Checked)
      {
        for (int i = 1; i <= 10; i++)
        {
          int berechung = zahl * i;
          TxtAusgabe.Text += $"{zahl} -> ({zahl}*{i}={berechung}) \r\n";
        }
      }
      else
      {
        for (int i = 10; i >= 1; i--)
        {
          int berechung = zahl * i;
          TxtAusgabe.Text += $"{zahl} -> ({zahl}*{i}={berechung}) \r\n";
        }
      }
    }
  }
}
