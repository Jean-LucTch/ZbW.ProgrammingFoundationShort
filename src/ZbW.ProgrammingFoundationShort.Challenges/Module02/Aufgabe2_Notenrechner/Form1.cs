using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe2_Notenrechner
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void CmdBewerten_Click(object sender, EventArgs e)
    {
      string bewertung;

      if(double.TryParse(TxtNote.Text, out double note) && !(note < 1 || note > 6)) { }
      else { MessageBox.Show("Ungültige Notenangabe! \nMuss zwischen 1.0 - 6.0 liegen!"); return; }

      if (note <= 6.0 && note >= 5.5) { bewertung = "Sehr gut"; }
      else if(note <= 5.4 && note >= 4.5) { bewertung = "Gut"; }
      else if (note <= 4.4 && note >= 4.0) { bewertung = "Genügend"; }
      else { bewertung = "Ungenügend"; }

      if (!ChkDetails.Checked)
      {
        LblErgebnis.Text = $"Note {note} -> {bewertung}";
      }
      else
      {
        double prozentrechnung = (note - 1) / 5 * 100;
        LblErgebnis.Text = $"Note {note} -> {bewertung} ({prozentrechnung:F2}%)";
      }
    }
  }
}
