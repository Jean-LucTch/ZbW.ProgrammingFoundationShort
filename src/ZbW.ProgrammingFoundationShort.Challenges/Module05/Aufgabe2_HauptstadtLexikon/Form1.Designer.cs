using System.ComponentModel;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe2_HauptstadtLexikon;

partial class Form1
{
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private IContainer components = null;

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
    LblSuche = new Label(); TxtSuche = new TextBox();
    CmdHauptstadt = new Button(); CmdLand = new Button();
    LblLandNeu = new Label(); TxtLandNeu = new TextBox();
    LblStadtNeu = new Label(); TxtStadtNeu = new TextBox();
    CmdEintragHinzufuegen = new Button(); CmdAlleAnzeigen = new Button();
    LblErgebnis = new Label(); TxtAusgabe = new TextBox();
    SuspendLayout();

    LblSuche.AutoSize = true; LblSuche.Location = new Point(12, 15); LblSuche.Text = "Suche:";
    TxtSuche.Location = new Point(70, 12); TxtSuche.Name = "TxtSuche"; TxtSuche.Size = new Size(150, 23);
    CmdHauptstadt.Location = new Point(230, 11); CmdHauptstadt.Name = "CmdHauptstadt"; CmdHauptstadt.Size = new Size(110, 25); CmdHauptstadt.Text = "Hauptstadt von"; CmdHauptstadt.Click += CmdHauptstadt_Click;
    CmdLand.Location = new Point(345, 11); CmdLand.Name = "CmdLand"; CmdLand.Size = new Size(110, 25); CmdLand.Text = "Land zu Stadt"; CmdLand.Click += CmdLand_Click;

    LblLandNeu.AutoSize = true; LblLandNeu.Location = new Point(12, 50); LblLandNeu.Text = "Land:";
    TxtLandNeu.Location = new Point(70, 47); TxtLandNeu.Name = "TxtLandNeu"; TxtLandNeu.Size = new Size(130, 23);
    LblStadtNeu.AutoSize = true; LblStadtNeu.Location = new Point(210, 50); LblStadtNeu.Text = "Hauptstadt:";
    TxtStadtNeu.Location = new Point(290, 47); TxtStadtNeu.Name = "TxtStadtNeu"; TxtStadtNeu.Size = new Size(130, 23);

    CmdEintragHinzufuegen.Location = new Point(12, 80); CmdEintragHinzufuegen.Name = "CmdEintragHinzufuegen"; CmdEintragHinzufuegen.Size = new Size(135, 25); CmdEintragHinzufuegen.Text = "Eintrag hinzufügen"; CmdEintragHinzufuegen.Click += CmdEintragHinzufuegen_Click;
    CmdAlleAnzeigen.Location = new Point(155, 80); CmdAlleAnzeigen.Name = "CmdAlleAnzeigen"; CmdAlleAnzeigen.Size = new Size(110, 25); CmdAlleAnzeigen.Text = "Alle anzeigen"; CmdAlleAnzeigen.Click += CmdAlleAnzeigen_Click;

    LblErgebnis.AutoSize = true; LblErgebnis.Location = new Point(12, 118); LblErgebnis.Name = "LblErgebnis"; LblErgebnis.Text = "";
    TxtAusgabe.Location = new Point(12, 138); TxtAusgabe.Multiline = true; TxtAusgabe.Name = "TxtAusgabe";
    TxtAusgabe.ReadOnly = true; TxtAusgabe.ScrollBars = ScrollBars.Vertical; TxtAusgabe.Size = new Size(443, 150);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(470, 305);
    Controls.Add(LblSuche); Controls.Add(TxtSuche); Controls.Add(CmdHauptstadt); Controls.Add(CmdLand);
    Controls.Add(LblLandNeu); Controls.Add(TxtLandNeu); Controls.Add(LblStadtNeu); Controls.Add(TxtStadtNeu);
    Controls.Add(CmdEintragHinzufuegen); Controls.Add(CmdAlleAnzeigen); Controls.Add(LblErgebnis); Controls.Add(TxtAusgabe);
    Name = "HauptstadtLexikonForm"; Text = "Hauptstadt-Lexikon – Aufgabe 2";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblSuche; private TextBox TxtSuche;
  private Button CmdHauptstadt; private Button CmdLand;
  private Label LblLandNeu; private TextBox TxtLandNeu;
  private Label LblStadtNeu; private TextBox TxtStadtNeu;
  private Button CmdEintragHinzufuegen; private Button CmdAlleAnzeigen;
  private Label LblErgebnis; private TextBox TxtAusgabe;

  #endregion
}

