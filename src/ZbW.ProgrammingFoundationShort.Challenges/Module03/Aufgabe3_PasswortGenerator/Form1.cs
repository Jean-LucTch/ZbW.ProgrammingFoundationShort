using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe3_PasswortGenerator
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    const string grossbuchstanbenpool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string kleinbuchstanbenpool = "abcdefghijklmnopqrstuvwxyz";
    const string zahlenpool = "0123456789";
    const string sonderzeichenpool = "!@#$%^&*";

    private void CmdGenerieren_Click(object sender, EventArgs e)
    {
      int laenge = Laenge();
      string password = "";

      if (!(laenge < 8 || laenge > 32)) { password = GeneriereZufallsPassword(laenge); }
      else { MessageBox.Show("Länge ist nicht zwischen 8-32!"); return; }

      LblPasswort.Text = password;
    }

    private void CmdKopieren_Click(object sender, EventArgs e)
    {
      string passworttocopy = LblPasswort.Text;
      Clipboard.SetData(DataFormats.Text, (Object)passworttocopy);
    }

    private int Laenge()
    {
      if (int.TryParse(TxtLaenge.Text, out int laenge)) { }
      return laenge;
    }

    private string GeneriereZufallsPassword(int laenge)
    {
      string Finalpool = "";

      if (ChkGross.Checked) { Finalpool += grossbuchstanbenpool; }
      if (ChkKlein.Checked) { Finalpool += kleinbuchstanbenpool; }
      if (ChkZahlen.Checked) { Finalpool += zahlenpool; }
      if (ChkSonder.Checked) { Finalpool += sonderzeichenpool; }

      try
      {
        char[] ergebnis = new char[laenge];

        for (int i = 0; i < laenge; i++)
        {
          int randomIndex = Random.Shared.Next(Finalpool.Length);
          ergebnis[i] = Finalpool[randomIndex];
          
        }
        CmdKopieren.Enabled = true;
        return new string(ergebnis);
      }
      catch (IndexOutOfRangeException)
      {
        MessageBox.Show("Du hast keine CheckBox ausgewählt, Passwort konnte nicht generiert werden!");
        Finalpool = "Passwort konnte nicht generiert werden!";
        CmdKopieren.Enabled = false;
      }
      return new string(Finalpool);
    }
  }
}
