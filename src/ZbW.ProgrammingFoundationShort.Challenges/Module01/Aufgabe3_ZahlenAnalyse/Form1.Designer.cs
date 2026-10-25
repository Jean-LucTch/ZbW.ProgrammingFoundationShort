namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe3_ZahlenAnalyse
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      LblZahl1 = new Label();
      TxtZahl1 = new TextBox();
      LblZahl2 = new Label();
      TxtZahl2 = new TextBox();
      LblZahl3 = new Label();
      TxtZahl3 = new TextBox();
      CmdAnalysieren = new Button();
      LblSumme = new Label();
      LblDurchschnitt = new Label();
      LblGroesste = new Label();
      LblKleinste = new Label();
      LblGerade = new Label();
      SuspendLayout();

      // Eingabe-Labels und TextBoxen
      LblZahl1.AutoSize = true;
      LblZahl1.Location = new Point(12, 18);
      LblZahl1.Text = "Zahl 1:";

      TxtZahl1.Location = new Point(80, 15);
      TxtZahl1.Name = "TxtZahl1";
      TxtZahl1.Size = new Size(80, 23);

      LblZahl2.AutoSize = true;
      LblZahl2.Location = new Point(12, 50);
      LblZahl2.Text = "Zahl 2:";

      TxtZahl2.Location = new Point(80, 47);
      TxtZahl2.Name = "TxtZahl2";
      TxtZahl2.Size = new Size(80, 23);

      LblZahl3.AutoSize = true;
      LblZahl3.Location = new Point(12, 82);
      LblZahl3.Text = "Zahl 3:";

      TxtZahl3.Location = new Point(80, 79);
      TxtZahl3.Name = "TxtZahl3";
      TxtZahl3.Size = new Size(80, 23);

      // Button
      CmdAnalysieren.Location = new Point(80, 115);
      CmdAnalysieren.Name = "CmdAnalysieren";
      CmdAnalysieren.Size = new Size(130, 28);
      CmdAnalysieren.Text = "Analysieren";
      CmdAnalysieren.Click += CmdAnalysieren_Click;

      // Ergebnis-Labels
      int yStart = 160;
      int yStep = 24;

      LblSumme.AutoSize = true;
      LblSumme.Location = new Point(12, yStart);
      LblSumme.Name = "LblSumme";
      LblSumme.Text = "";

      LblDurchschnitt.AutoSize = true;
      LblDurchschnitt.Location = new Point(12, yStart + yStep);
      LblDurchschnitt.Name = "LblDurchschnitt";
      LblDurchschnitt.Text = "";

      LblGroesste.AutoSize = true;
      LblGroesste.Location = new Point(12, yStart + yStep * 2);
      LblGroesste.Name = "LblGroesste";
      LblGroesste.Text = "";

      LblKleinste.AutoSize = true;
      LblKleinste.Location = new Point(12, yStart + yStep * 3);
      LblKleinste.Name = "LblKleinste";
      LblKleinste.Text = "";

      LblGerade.AutoSize = true;
      LblGerade.Location = new Point(12, yStart + yStep * 4);
      LblGerade.Name = "LblGerade";
      LblGerade.Text = "";

      // ZahlenAnalyseForm
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(320, 330);
      Controls.Add(LblZahl1);
      Controls.Add(TxtZahl1);
      Controls.Add(LblZahl2);
      Controls.Add(TxtZahl2);
      Controls.Add(LblZahl3);
      Controls.Add(TxtZahl3);
      Controls.Add(CmdAnalysieren);
      Controls.Add(LblSumme);
      Controls.Add(LblDurchschnitt);
      Controls.Add(LblGroesste);
      Controls.Add(LblKleinste);
      Controls.Add(LblGerade);
      Name = "ZahlenAnalyseForm";
      Text = "Zahlen-Analyse – Aufgabe 3";
      ResumeLayout(false);
      PerformLayout();
    }

    private Label LblZahl1;
    private TextBox TxtZahl1;
    private Label LblZahl2;
    private TextBox TxtZahl2;
    private Label LblZahl3;
    private TextBox TxtZahl3;
    private Button CmdAnalysieren;
    private Label LblSumme;
    private Label LblDurchschnitt;
    private Label LblGroesste;
    private Label LblKleinste;
    private Label LblGerade;

    #endregion
  }
}
