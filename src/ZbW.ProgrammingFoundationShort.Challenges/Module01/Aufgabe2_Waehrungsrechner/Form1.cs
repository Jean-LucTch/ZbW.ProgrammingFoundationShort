using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Waehrungsrechner
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    const decimal ChfPerEur = 1.05m;

    private decimal Calc(decimal betrag, bool isToChf)
    {
      if (isToChf)
      {
        return betrag * ChfPerEur;
      }
      else
      {
        return betrag / ChfPerEur;
      }
    }


    private void CmdChfToEur_Click(object sender, EventArgs e)
    {
      if (decimal.TryParse(TxtBetrag.Text, out decimal CHF) && CHF > 0.00m)
      {
        decimal betrag = Calc(CHF, false);
        LblErgebnis.Text = $"{betrag:F2}";
      }
      else { MessageBox.Show("Unglütiger Wert"); }
    }

    private void CmdEurToChf_Click(object sender, EventArgs e)
    {
      if (decimal.TryParse(TxtBetrag.Text, out decimal Euro) && Euro > 0.00m)
      {
        decimal betrag = Calc(Euro, true);
        LblErgebnis.Text = $"{betrag:F2}";
      }
      else { MessageBox.Show("Unglütiger Wert"); }
    }
  }
}
