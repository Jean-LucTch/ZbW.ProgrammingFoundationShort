namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe3_Versicherungspraemie
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
      LblAlter = new Label();
      TxtAlter = new TextBox();
      GrpTyp = new GroupBox();
      RadBasis = new RadioButton();
      RadStandard = new RadioButton();
      RadPremium = new RadioButton();
      ChkUnfall = new CheckBox();
      CmdBerechnen = new Button();
      LblErgebnis = new Label();
      GrpTyp.SuspendLayout();
      SuspendLayout();
      // 
      // LblAlter
      // 
      LblAlter.AutoSize = true;
      LblAlter.Location = new Point(12, 20);
      LblAlter.Name = "LblAlter";
      LblAlter.Size = new Size(73, 15);
      LblAlter.TabIndex = 0;
      LblAlter.Text = "Alter (Jahre):";
      // 
      // TxtAlter
      // 
      TxtAlter.Location = new Point(130, 17);
      TxtAlter.Name = "TxtAlter";
      TxtAlter.Size = new Size(80, 23);
      TxtAlter.TabIndex = 1;
      // 
      // GrpTyp
      // 
      GrpTyp.Controls.Add(RadBasis);
      GrpTyp.Controls.Add(RadStandard);
      GrpTyp.Controls.Add(RadPremium);
      GrpTyp.Location = new Point(12, 50);
      GrpTyp.Name = "GrpTyp";
      GrpTyp.Size = new Size(220, 95);
      GrpTyp.TabIndex = 2;
      GrpTyp.TabStop = false;
      GrpTyp.Text = "Versicherungstyp";
      // 
      // RadBasis
      // 
      RadBasis.AutoSize = true;
      RadBasis.Checked = true;
      RadBasis.Location = new Point(10, 20);
      RadBasis.Name = "RadBasis";
      RadBasis.Size = new Size(85, 19);
      RadBasis.TabIndex = 0;
      RadBasis.TabStop = true;
      RadBasis.Text = "Basis (×1.0)";
      // 
      // RadStandard
      // 
      RadStandard.AutoSize = true;
      RadStandard.Location = new Point(10, 45);
      RadStandard.Name = "RadStandard";
      RadStandard.Size = new Size(106, 19);
      RadStandard.TabIndex = 1;
      RadStandard.Text = "Standard (×1.4)";
      // 
      // RadPremium
      // 
      RadPremium.AutoSize = true;
      RadPremium.Location = new Point(10, 68);
      RadPremium.Name = "RadPremium";
      RadPremium.Size = new Size(108, 19);
      RadPremium.TabIndex = 2;
      RadPremium.Text = "Premium (×1.8)";
      // 
      // ChkUnfall
      // 
      ChkUnfall.AutoSize = true;
      ChkUnfall.Location = new Point(12, 155);
      ChkUnfall.Name = "ChkUnfall";
      ChkUnfall.Size = new Size(146, 19);
      ChkUnfall.TabIndex = 3;
      ChkUnfall.Text = "Unfallzusatz (+20 CHF)";
      // 
      // CmdBerechnen
      // 
      CmdBerechnen.Location = new Point(12, 185);
      CmdBerechnen.Name = "CmdBerechnen";
      CmdBerechnen.Size = new Size(130, 28);
      CmdBerechnen.TabIndex = 4;
      CmdBerechnen.Text = "Berechnen";
      CmdBerechnen.Click += CmdBerechnen_Click;
      // 
      // LblErgebnis
      // 
      LblErgebnis.AutoSize = true;
      LblErgebnis.Location = new Point(12, 225);
      LblErgebnis.Name = "LblErgebnis";
      LblErgebnis.Size = new Size(0, 15);
      LblErgebnis.TabIndex = 5;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(380, 340);
      Controls.Add(LblAlter);
      Controls.Add(TxtAlter);
      Controls.Add(GrpTyp);
      Controls.Add(ChkUnfall);
      Controls.Add(CmdBerechnen);
      Controls.Add(LblErgebnis);
      Name = "Form1";
      Text = "Versicherungsprämie – Aufgabe 3";
      GrpTyp.ResumeLayout(false);
      GrpTyp.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label LblAlter;
    private TextBox TxtAlter;
    private GroupBox GrpTyp;
    private RadioButton RadBasis;
    private RadioButton RadStandard;
    private RadioButton RadPremium;
    private CheckBox ChkUnfall;
    private Button CmdBerechnen;
    private Label LblErgebnis;

    #endregion
  }
}
