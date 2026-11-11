namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe1_TemperaturAuswertung;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();

    string[] tage = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
    Label[] labels = { LblMo, LblDi, LblMi, LblDo, LblFr, LblSa, LblSo };
    TextBox[] felder = { TxtMo, TxtDi, TxtMi, TxtDo, TxtFr, TxtSa, TxtSo };

    for (int i = 0; i < 7; i++)
    {
      labels[i].AutoSize = true;
      labels[i].Location = new Point(12, 20 + i * 30);
      labels[i].Text = $"{tage[i]}:";
      felder[i].Location = new Point(60, 17 + i * 30);
      felder[i].Name = $"Txt{tage[i]}";
      felder[i].Size = new Size(80, 23);
      Controls.Add(labels[i]);
      Controls.Add(felder[i]);
    }
  }


  private void CmdAuswerten_Click(object sender, EventArgs e)
  {
    try
    {
      double[] values =
      {
        Convert.ToDouble(TxtMo.Text), Convert.ToDouble(TxtDi.Text), Convert.ToDouble(TxtMi.Text), Convert.ToDouble(TxtDo.Text), Convert.ToDouble(TxtFr.Text),
        Convert.ToDouble(TxtSa.Text), Convert.ToDouble(TxtSo.Text)
      };
      Average(values);
      Maximum(values);
      Minimum(values);
    }
    catch (FormatException)
    {
      MessageBox.Show("Falsche werte eingetragen");
      return;
    }
    catch (NullReferenceException)
    {
      MessageBox.Show("Keine werte eingetragen");
      return;
    }


  }

  private double Average(double[] values)
  {
    double sum = 0.0;

    for (int i = 0; i < 7; i++)
    {
      sum += values[i];
    }

    double newcalc =  sum / 7;
    LblDurchschnitt.Text = $"Durchschnitt: {newcalc:F2}";

    return newcalc;
  }

  private double Maximum(double[] values)
  {
    double max = values[0];
    double akutellnum = 0.0;

    for (int i = 0; i < 7; i++)
    {
      akutellnum = values[i];
      if (akutellnum > max){max = akutellnum;}
    }

    LblMax.Text = $"Max: {max:F2}";
    return max;
  }

  private double Minimum(double[] values)
  {
    double min = values[0];
    double akutellnum = 0.0;

    for (int i = 0; i < 7; i++)
    {
      akutellnum = values[i];
      if (akutellnum < min){min = akutellnum;}
    }

    LblMin.Text = $"Min: {min:F2}";
    return min;
  }
}
