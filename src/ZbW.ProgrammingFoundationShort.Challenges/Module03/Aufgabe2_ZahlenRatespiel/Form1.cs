using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe2_ZahlenRatespiel
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    int secretnumber;
    int versuche;

    private void CmdRaten_Click(object sender, EventArgs e)
    {
      if(int.TryParse(TxtVermutung.Text, out int vermutung) && !(vermutung < 1 || vermutung > 100)) { }
      else { MessageBox.Show("Eingabe muss eine Zahl sein zwischen 1-100"); return; }

      if(vermutung == secretnumber)
      {
        versuche++;
        LblHinweis.Text = "Richtig!";
        MessageBox.Show($"Glückwunsch!!! Du hast die Zahl {secretnumber} erraten mit ({versuche} Versuchen)");
      }
      else if (vermutung > secretnumber)
      {
        LblHinweis.Text = "Zu gross!";
        versuche++;
      }
      else
      {
        LblHinweis.Text = "Zu klein!";
        versuche++;
      }
      LblVersuche.Text = $"Versuche: {versuche}";
    }

    private void CmdNeuSpiel_Click(object sender, EventArgs e)
    {
      NeuesSpiel();
      CmdRaten.Enabled = true;
      versuche = 0;
      LblVersuche.Text = $"Versuche: {versuche}";
      LblHinweis.Text = "";
    }

    private int NeuesSpiel()
    {
      var random = new Random();
      return secretnumber = random.Next(1, 101);
    }
  }
}
