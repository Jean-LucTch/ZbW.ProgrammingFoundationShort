using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe3_Versicherungspraemie
{
  public partial class Form1 : Form
  {
    public enum InsuranceType { Basis, Standard, Premium }

    public Form1()
    {
      InitializeComponent();
    }

    private void CmdBerechnen_Click(object sender, EventArgs e)
    {
      decimal basispraemie;

      if (int.TryParse(TxtAlter.Text, out int alter) && !(alter < 0 || alter > 100)) { }
      else { MessageBox.Show("Ungültige eingabe"); return; }

      if(alter > 65) { basispraemie = 350m; }
      else if (alter <= 65 && alter >= 46) { basispraemie = 280m; }
      else if (alter <= 45 && alter >= 25) { basispraemie = 200m; }
      else { basispraemie = 150m; }

      InsuranceType typErmitteln;
      if (RadBasis.Checked) { typErmitteln = InsuranceType.Basis; }
      else if (RadStandard.Checked) { typErmitteln = InsuranceType.Standard; }
      else { typErmitteln = InsuranceType.Premium; }

      double praemie = (typErmitteln) switch
      {
        InsuranceType.Basis => 1.0,
        InsuranceType.Standard => 1.4,
        InsuranceType.Premium => 1.8
      };

      decimal unfall = ChkUnfall.Checked
        ? 20
        : 0;

      decimal sumpraemie = basispraemie * (decimal)praemie + unfall;

      LblErgebnis.Text = $"Gesamtprämie: {sumpraemie:F2} CHF";
    }
  }
}
