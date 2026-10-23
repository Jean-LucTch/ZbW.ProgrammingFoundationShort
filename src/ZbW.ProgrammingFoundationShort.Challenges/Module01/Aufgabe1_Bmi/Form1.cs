using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private double Calc(double gewicht, double groesse)
    {
      double bmi = gewicht / (groesse * groesse);
      return bmi;
    }

    private void CmdBerechnen_Click(object sender, EventArgs e)
    {
      if (double.TryParse(TxtGewicht.Text, out double gewicht))
      {
        if (double.TryParse(TxtGroesse.Text, out double groesse))
        {
          double bmi = Calc(gewicht, groesse);
          MessageBox.Show($"Dein BMI ist: {bmi:F2}");
        }
        else
        {
          MessageBox.Show("Unglütige Eingabe");
        }
        
      }
      else
      {
        MessageBox.Show("Unglütige Eingabe");
      }

    }
  }
}
