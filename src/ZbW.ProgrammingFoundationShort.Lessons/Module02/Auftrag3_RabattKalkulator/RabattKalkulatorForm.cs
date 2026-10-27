namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

// ============================================================
// AUFTRAG 3 – RabattKalkulator (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Berechne einen Rabatt anhand von Kundentyp und Lehrling-Status.
//
// Anforderungen:
//   - TxtBetrag: Kaufbetrag einlesen
//   - RadioButtons: Normal (0%), Premium (10%), VIP (20%)
//   - CheckBox: Lehrling (+5% extra Rabatt)
//   - Anzeige: Originalbetrag, Rabatt in CHF, Endbetrag (2 Nachkommastellen)
//   - Geld als decimal (Block 01)
// ============================================================

public partial class RabattKalkulatorForm : Form
{
  public RabattKalkulatorForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Betrag aus TxtBetrag lesen (decimal.TryParse), muss grösser als 0 sein
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    if(decimal.TryParse(TxtBetrag.Text, out decimal betrag) && betrag > 0) { }
    else { MessageBox.Show("Ungültige Eingabe oder Wert muss grösser als 0 sein."); return; }

    // TODO 2: Rabatt aus RadioButton ermitteln
    //         RadNormal = 0%, RadPremium = 10%, RadVip = 20%
    int rabatt = Convert.ToString(RadNormal.Checked, RadPremium.Checked, RadVip.Checked) switch { };

    // TODO 3: Wenn ChkLehrling.Checked → Rabatt += 5

    // TODO 4: Rabatt in CHF und Endbetrag berechnen:
    //         rabattBetrag = betrag * rabatt / 100m;  endbetrag = betrag - rabattBetrag

    // TODO 5: LblErgebnis.Text setzen: Originalbetrag, Rabatt in CHF (und %), Endbetrag
  }
}
