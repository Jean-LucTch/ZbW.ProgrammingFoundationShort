namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe3_PasswortGenerator
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
      LblLaenge = new Label();
      TxtLaenge = new TextBox();
      ChkGross = new CheckBox();
      ChkKlein = new CheckBox();
      ChkZahlen = new CheckBox();
      ChkSonder = new CheckBox();
      CmdGenerieren = new Button();
      LblPasswortLabel = new Label();
      LblPasswort = new Label();
      CmdKopieren = new Button();
      SuspendLayout();
      // 
      // LblLaenge
      // 
      LblLaenge.AutoSize = true;
      LblLaenge.Location = new Point(12, 20);
      LblLaenge.Name = "LblLaenge";
      LblLaenge.Size = new Size(77, 15);
      LblLaenge.TabIndex = 0;
      LblLaenge.Text = "Länge (8–32):";
      // 
      // TxtLaenge
      // 
      TxtLaenge.Location = new Point(130, 17);
      TxtLaenge.Name = "TxtLaenge";
      TxtLaenge.Size = new Size(60, 23);
      TxtLaenge.TabIndex = 1;
      TxtLaenge.Text = "12";
      // 
      // ChkGross
      // 
      ChkGross.AutoSize = true;
      ChkGross.Checked = true;
      ChkGross.CheckState = CheckState.Checked;
      ChkGross.Location = new Point(12, 50);
      ChkGross.Name = "ChkGross";
      ChkGross.Size = new Size(149, 19);
      ChkGross.TabIndex = 2;
      ChkGross.Text = "Grossbuchstaben (A–Z)";
      // 
      // ChkKlein
      // 
      ChkKlein.AutoSize = true;
      ChkKlein.Checked = true;
      ChkKlein.CheckState = CheckState.Checked;
      ChkKlein.Location = new Point(12, 75);
      ChkKlein.Name = "ChkKlein";
      ChkKlein.Size = new Size(142, 19);
      ChkKlein.TabIndex = 3;
      ChkKlein.Text = "Kleinbuchstaben (a–z)";
      // 
      // ChkZahlen
      // 
      ChkZahlen.AutoSize = true;
      ChkZahlen.Checked = true;
      ChkZahlen.CheckState = CheckState.Checked;
      ChkZahlen.Location = new Point(12, 100);
      ChkZahlen.Name = "ChkZahlen";
      ChkZahlen.Size = new Size(91, 19);
      ChkZahlen.TabIndex = 4;
      ChkZahlen.Text = "Zahlen (0–9)";
      // 
      // ChkSonder
      // 
      ChkSonder.AutoSize = true;
      ChkSonder.Location = new Point(12, 125);
      ChkSonder.Name = "ChkSonder";
      ChkSonder.Size = new Size(144, 19);
      ChkSonder.TabIndex = 5;
      ChkSonder.Text = "Sonderzeichen (!@#...)";
      // 
      // CmdGenerieren
      // 
      CmdGenerieren.Location = new Point(12, 160);
      CmdGenerieren.Name = "CmdGenerieren";
      CmdGenerieren.Size = new Size(130, 28);
      CmdGenerieren.TabIndex = 6;
      CmdGenerieren.Text = "Generieren";
      CmdGenerieren.Click += CmdGenerieren_Click;
      // 
      // LblPasswortLabel
      // 
      LblPasswortLabel.AutoSize = true;
      LblPasswortLabel.Location = new Point(12, 205);
      LblPasswortLabel.Name = "LblPasswortLabel";
      LblPasswortLabel.Size = new Size(57, 15);
      LblPasswortLabel.TabIndex = 7;
      LblPasswortLabel.Text = "Passwort:";
      // 
      // LblPasswort
      // 
      LblPasswort.AutoSize = true;
      LblPasswort.Font = new Font("Courier New", 11F, FontStyle.Bold);
      LblPasswort.Location = new Point(12, 225);
      LblPasswort.Name = "LblPasswort";
      LblPasswort.Size = new Size(0, 17);
      LblPasswort.TabIndex = 8;
      // 
      // CmdKopieren
      // 
      CmdKopieren.Location = new Point(12, 255);
      CmdKopieren.Name = "CmdKopieren";
      CmdKopieren.Size = new Size(130, 28);
      CmdKopieren.TabIndex = 9;
      CmdKopieren.Text = "Kopieren";
      CmdKopieren.Click += CmdKopieren_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(399, 300);
      Controls.Add(LblLaenge);
      Controls.Add(TxtLaenge);
      Controls.Add(ChkGross);
      Controls.Add(ChkKlein);
      Controls.Add(ChkZahlen);
      Controls.Add(ChkSonder);
      Controls.Add(CmdGenerieren);
      Controls.Add(LblPasswortLabel);
      Controls.Add(LblPasswort);
      Controls.Add(CmdKopieren);
      Name = "Form1";
      Text = "Passwort-Generator – Aufgabe 3";
      ResumeLayout(false);
      PerformLayout();
    }

    private Label LblLaenge;
    private TextBox TxtLaenge;
    private CheckBox ChkGross;
    private CheckBox ChkKlein;
    private CheckBox ChkZahlen;
    private CheckBox ChkSonder;
    private Button CmdGenerieren;
    private Label LblPasswortLabel;
    private Label LblPasswort;
    private Button CmdKopieren;

    #endregion
  }
}
