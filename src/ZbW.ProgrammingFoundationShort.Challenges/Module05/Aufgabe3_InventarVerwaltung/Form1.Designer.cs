using System.ComponentModel;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe3_InventarVerwaltung;

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
    LblArtikel = new Label(); TxtArtikel = new TextBox();
    LblMenge = new Label(); TxtMenge = new TextBox();
    CmdHinzufuegen = new Button(); CmdEntfernen = new Button();
    CmdSuchen = new Button(); CmdAlleAnzeigen = new Button();
    LstInventar = new ListBox(); LblGesamt = new Label(); LblAusverkauft = new Label();
    SuspendLayout();

    LblArtikel.AutoSize = true; LblArtikel.Location = new Point(12, 20); LblArtikel.Text = "Artikel:";
    TxtArtikel.Location = new Point(80, 17); TxtArtikel.Name = "TxtArtikel"; TxtArtikel.Size = new Size(150, 23);
    LblMenge.AutoSize = true; LblMenge.Location = new Point(240, 20); LblMenge.Text = "Menge:";
    TxtMenge.Location = new Point(290, 17); TxtMenge.Name = "TxtMenge"; TxtMenge.Size = new Size(70, 23);

    CmdHinzufuegen.Location = new Point(12, 50); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(85, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    CmdEntfernen.Location = new Point(105, 50); CmdEntfernen.Name = "CmdEntfernen"; CmdEntfernen.Size = new Size(85, 25); CmdEntfernen.Text = "Entfernen"; CmdEntfernen.Click += CmdEntfernen_Click;
    CmdSuchen.Location = new Point(198, 50); CmdSuchen.Name = "CmdSuchen"; CmdSuchen.Size = new Size(75, 25); CmdSuchen.Text = "Suchen"; CmdSuchen.Click += CmdSuchen_Click;
    CmdAlleAnzeigen.Location = new Point(281, 50); CmdAlleAnzeigen.Name = "CmdAlleAnzeigen"; CmdAlleAnzeigen.Size = new Size(80, 25); CmdAlleAnzeigen.Text = "Alle zeigen"; CmdAlleAnzeigen.Click += CmdAlleAnzeigen_Click;

    LstInventar.Font = new Font("Courier New", 9F);
    LstInventar.Location = new Point(12, 85); LstInventar.Name = "LstInventar"; LstInventar.Size = new Size(360, 160);

    LblGesamt.AutoSize = true; LblGesamt.Location = new Point(12, 258); LblGesamt.Name = "LblGesamt"; LblGesamt.Text = "";
    LblAusverkauft.AutoSize = true; LblAusverkauft.ForeColor = Color.Red; LblAusverkauft.Location = new Point(12, 282); LblAusverkauft.Name = "LblAusverkauft"; LblAusverkauft.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(390, 315);
    Controls.Add(LblArtikel); Controls.Add(TxtArtikel); Controls.Add(LblMenge); Controls.Add(TxtMenge);
    Controls.Add(CmdHinzufuegen); Controls.Add(CmdEntfernen); Controls.Add(CmdSuchen); Controls.Add(CmdAlleAnzeigen);
    Controls.Add(LstInventar); Controls.Add(LblGesamt); Controls.Add(LblAusverkauft);
    Name = "InventarVerwaltungForm"; Text = "Inventar-Verwaltung – Aufgabe 3";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblArtikel; private TextBox TxtArtikel;
  private Label LblMenge; private TextBox TxtMenge;
  private Button CmdHinzufuegen; private Button CmdEntfernen;
  private Button CmdSuchen; private Button CmdAlleAnzeigen;
  private ListBox LstInventar; private Label LblGesamt; private Label LblAusverkauft;

  #endregion
}

