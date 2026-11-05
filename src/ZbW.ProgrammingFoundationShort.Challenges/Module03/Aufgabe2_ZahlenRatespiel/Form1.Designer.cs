namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe2_ZahlenRatespiel
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
      LblTitel = new Label();
      TxtVermutung = new TextBox();
      CmdRaten = new Button();
      CmdNeuSpiel = new Button();
      LblHinweis = new Label();
      LblVersuche = new Label();
      SuspendLayout();
      // 
      // LblTitel
      // 
      LblTitel.AutoSize = true;
      LblTitel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      LblTitel.Location = new Point(12, 12);
      LblTitel.Name = "LblTitel";
      LblTitel.Size = new Size(199, 21);
      LblTitel.TabIndex = 0;
      LblTitel.Text = "Zahlen-Ratespiel (1–100)";
      // 
      // TxtVermutung
      // 
      TxtVermutung.Location = new Point(12, 50);
      TxtVermutung.Name = "TxtVermutung";
      TxtVermutung.Size = new Size(100, 23);
      TxtVermutung.TabIndex = 1;
      // 
      // CmdRaten
      // 
      CmdRaten.Enabled = false;
      CmdRaten.Location = new Point(122, 49);
      CmdRaten.Name = "CmdRaten";
      CmdRaten.Size = new Size(80, 25);
      CmdRaten.TabIndex = 2;
      CmdRaten.Text = "Raten";
      CmdRaten.Click += CmdRaten_Click;
      // 
      // CmdNeuSpiel
      // 
      CmdNeuSpiel.Location = new Point(212, 49);
      CmdNeuSpiel.Name = "CmdNeuSpiel";
      CmdNeuSpiel.Size = new Size(100, 25);
      CmdNeuSpiel.TabIndex = 3;
      CmdNeuSpiel.Text = "Neues Spiel";
      CmdNeuSpiel.Click += CmdNeuSpiel_Click;
      // 
      // LblHinweis
      // 
      LblHinweis.AutoSize = true;
      LblHinweis.Location = new Point(12, 85);
      LblHinweis.Name = "LblHinweis";
      LblHinweis.Size = new Size(0, 15);
      LblHinweis.TabIndex = 4;
      // 
      // LblVersuche
      // 
      LblVersuche.AutoSize = true;
      LblVersuche.Location = new Point(12, 110);
      LblVersuche.Name = "LblVersuche";
      LblVersuche.Size = new Size(66, 15);
      LblVersuche.TabIndex = 5;
      LblVersuche.Text = "Versuche: 0";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(340, 150);
      Controls.Add(LblTitel);
      Controls.Add(TxtVermutung);
      Controls.Add(CmdRaten);
      Controls.Add(CmdNeuSpiel);
      Controls.Add(LblHinweis);
      Controls.Add(LblVersuche);
      Name = "Form1";
      Text = "Zahlen-Ratespiel – Aufgabe 2";
      ResumeLayout(false);
      PerformLayout();
    }

    private Label LblTitel;
    private TextBox TxtVermutung;
    private Button CmdRaten;
    private Button CmdNeuSpiel;
    private Label LblHinweis;
    private Label LblVersuche;

    #endregion
  }
}
