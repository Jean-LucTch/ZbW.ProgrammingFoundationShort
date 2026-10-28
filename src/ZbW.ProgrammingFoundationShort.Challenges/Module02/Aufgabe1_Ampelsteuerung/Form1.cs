using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe1_Ampelsteuerung
{
  public partial class Form1 : Form
  {
    public enum TrafficLightColor { Red, Yellow, Green }

    public Form1()
    {
      InitializeComponent();
    }

    private void CmdAnzeigen_Click(object sender, EventArgs e)
    {
      TrafficLightColor farbe;
      if(RadRot.Checked)
      {
        farbe = TrafficLightColor.Red;
      }
      else if (RadGelb.Checked)
      {
        farbe = TrafficLightColor.Yellow;
      }
      else
      {
        farbe = TrafficLightColor.Green;
      }
      string meldung;
      Color ampelFarbe;

      switch (farbe)
      {
        case TrafficLightColor.Red:
          meldung = "Anhalten!";
          ampelFarbe = Color.Red;
          break;
        case TrafficLightColor.Yellow:
          meldung = "Vorsicht, bremsen!";
          ampelFarbe= Color.Yellow;
          break;
        case TrafficLightColor.Green:
          meldung = "Fahren!";
          ampelFarbe = Color.Green;
          break;
        default:
          meldung = "Unbekannt";
          ampelFarbe = Color.Gray;
          break;
      }

      LblMeldung.Text = meldung;
      LblAmpel.BackColor = ampelFarbe;
      
    }
  }
}
