using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe3_ZahlenAnalyse
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private int CalcSum()
    {
      if (int.TryParse(TxtZahl1.Text, out int Zahl1)) { }
      if (int.TryParse(TxtZahl2.Text, out int Zahl2)) { }
      if (int.TryParse(TxtZahl3.Text, out int Zahl3)) { }

      return Zahl1 + Zahl2 + Zahl3;
    }

    private double CalcAverage()
    {
      double Average = Math.Round(CalcSum() / 3.00, 2);
      return Average;
    }

    private int BigNumber()
    {
      if (int.TryParse(TxtZahl1.Text, out int Zahl1)) { }
      if (int.TryParse(TxtZahl2.Text, out int Zahl2)) { }
      if (int.TryParse(TxtZahl3.Text, out int Zahl3)) { }

      if (Zahl1 >= Zahl2 && Zahl1 >= Zahl3) { return Zahl1; }
      else if(Zahl2 >= Zahl1 && Zahl2 >= Zahl3) { return Zahl2; }
      else { return Zahl3; }
    }

    private int LowNumber()
    {
      if (int.TryParse(TxtZahl1.Text, out int Zahl1)) { }
      if (int.TryParse(TxtZahl2.Text, out int Zahl2)) { }
      if (int.TryParse(TxtZahl3.Text, out int Zahl3)) { }

      if (Zahl1 <= Zahl2 && Zahl1 <= Zahl3) { return Zahl1; }
      else if (Zahl2 <= Zahl1 && Zahl2 <= Zahl3) { return Zahl2; }
      else { return Zahl3; }
    }
    private void EvenOdd()
    {
      int sum = CalcSum();
      if (sum % 2 == 0) { LblGerade.Text = "Summe ist: gerade"; }
      else if(sum % 2 == 1) { LblGerade.Text = "Summe ist: ungerade"; }
    }

    private void CmdAnalysieren_Click(object sender, EventArgs e)
    {
      LblSumme.Text = $"Summe: { Convert.ToString(CalcSum())}";
      LblDurchschnitt.Text = $"Durchschnitt: {Convert.ToString(CalcAverage())}";
      LblGroesste.Text = $"Grösste: {Convert.ToString(BigNumber())}";
      LblKleinste.Text = $"Kleinste: {Convert.ToString(LowNumber())}";
      EvenOdd();
    }
  }
}
