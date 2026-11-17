using System.ComponentModel;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe1_Leseliste;

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
    LblTitel = new Label(); TxtTitel = new TextBox();
    CmdHinzufuegen = new Button(); CmdGelesen = new Button(); CmdSortieren = new Button(); CmdAlleLoeschen = new Button();
    LstBuecher = new ListBox(); LblAnzahl = new Label();
    SuspendLayout();

    LblTitel.AutoSize = true; LblTitel.Location = new Point(12, 20); LblTitel.Text = "Buchtitel:";
    TxtTitel.Location = new Point(80, 17); TxtTitel.Name = "TxtTitel"; TxtTitel.Size = new Size(200, 23);
    CmdHinzufuegen.Location = new Point(290, 16); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(100, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    CmdGelesen.Location = new Point(12, 50); CmdGelesen.Name = "CmdGelesen"; CmdGelesen.Size = new Size(120, 25); CmdGelesen.Text = "Als gelesen entfernen"; CmdGelesen.Click += CmdGelesen_Click;
    CmdSortieren.Location = new Point(140, 50); CmdSortieren.Name = "CmdSortieren"; CmdSortieren.Size = new Size(120, 25); CmdSortieren.Text = "Alphabetisch"; CmdSortieren.Click += CmdSortieren_Click;
    CmdAlleLoeschen.Location = new Point(268, 50); CmdAlleLoeschen.Name = "CmdAlleLoeschen"; CmdAlleLoeschen.Size = new Size(120, 25); CmdAlleLoeschen.Text = "Alle löschen"; CmdAlleLoeschen.Click += CmdAlleLoeschen_Click;
    LstBuecher.Location = new Point(12, 85); LstBuecher.Name = "LstBuecher"; LstBuecher.Size = new Size(376, 160);
    LblAnzahl.AutoSize = true; LblAnzahl.Location = new Point(12, 258); LblAnzahl.Name = "LblAnzahl"; LblAnzahl.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(400, 290);
    Controls.Add(LblTitel); Controls.Add(TxtTitel); Controls.Add(CmdHinzufuegen);
    Controls.Add(CmdGelesen); Controls.Add(CmdSortieren); Controls.Add(CmdAlleLoeschen);
    Controls.Add(LstBuecher); Controls.Add(LblAnzahl);
    Name = "LeselisteForm"; Text = "Leseliste – Aufgabe 1";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblTitel; private TextBox TxtTitel;
  private Button CmdHinzufuegen; private Button CmdGelesen; private Button CmdSortieren; private Button CmdAlleLoeschen;
  private ListBox LstBuecher; private Label LblAnzahl;

  #endregion
}

