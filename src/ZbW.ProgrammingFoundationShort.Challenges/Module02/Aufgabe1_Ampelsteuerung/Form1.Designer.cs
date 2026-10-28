namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe1_Ampelsteuerung
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
      GrpFarbe = new GroupBox();
      RadRot = new RadioButton();
      RadGelb = new RadioButton();
      RadGruen = new RadioButton();
      CmdAnzeigen = new Button();
      LblMeldung = new Label();
      LblAmpel = new Label();
      GrpFarbe.SuspendLayout();
      SuspendLayout();
      // 
      // GrpFarbe
      // 
      GrpFarbe.Controls.Add(RadRot);
      GrpFarbe.Controls.Add(RadGelb);
      GrpFarbe.Controls.Add(RadGruen);
      GrpFarbe.Location = new Point(14, 16);
      GrpFarbe.Margin = new Padding(3, 4, 3, 4);
      GrpFarbe.Name = "GrpFarbe";
      GrpFarbe.Padding = new Padding(3, 4, 3, 4);
      GrpFarbe.Size = new Size(229, 133);
      GrpFarbe.TabIndex = 0;
      GrpFarbe.TabStop = false;
      GrpFarbe.Text = "Ampelfarbe";
      // 
      // RadRot
      // 
      RadRot.AutoSize = true;
      RadRot.Checked = true;
      RadRot.Location = new Point(11, 27);
      RadRot.Margin = new Padding(3, 4, 3, 4);
      RadRot.Name = "RadRot";
      RadRot.Size = new Size(53, 24);
      RadRot.TabIndex = 0;
      RadRot.TabStop = true;
      RadRot.Text = "Rot";
      // 
      // RadGelb
      // 
      RadGelb.AutoSize = true;
      RadGelb.Location = new Point(11, 60);
      RadGelb.Margin = new Padding(3, 4, 3, 4);
      RadGelb.Name = "RadGelb";
      RadGelb.Size = new Size(61, 24);
      RadGelb.TabIndex = 1;
      RadGelb.Text = "Gelb";
      // 
      // RadGruen
      // 
      RadGruen.AutoSize = true;
      RadGruen.Location = new Point(11, 91);
      RadGruen.Margin = new Padding(3, 4, 3, 4);
      RadGruen.Name = "RadGruen";
      RadGruen.Size = new Size(61, 24);
      RadGruen.TabIndex = 2;
      RadGruen.Text = "Grün";
      // 
      // CmdAnzeigen
      // 
      CmdAnzeigen.Location = new Point(14, 160);
      CmdAnzeigen.Margin = new Padding(3, 4, 3, 4);
      CmdAnzeigen.Name = "CmdAnzeigen";
      CmdAnzeigen.Size = new Size(137, 37);
      CmdAnzeigen.TabIndex = 1;
      CmdAnzeigen.Text = "Anzeigen";
      CmdAnzeigen.Click += CmdAnzeigen_Click;
      // 
      // LblMeldung
      // 
      LblMeldung.AutoSize = true;
      LblMeldung.Location = new Point(14, 213);
      LblMeldung.Name = "LblMeldung";
      LblMeldung.Size = new Size(0, 20);
      LblMeldung.TabIndex = 2;
      // 
      // LblAmpel
      // 
      LblAmpel.BackColor = Color.Gray;
      LblAmpel.BorderStyle = BorderStyle.FixedSingle;
      LblAmpel.Location = new Point(251, 16);
      LblAmpel.Name = "LblAmpel";
      LblAmpel.Size = new Size(68, 79);
      LblAmpel.TabIndex = 3;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(366, 267);
      Controls.Add(GrpFarbe);
      Controls.Add(CmdAnzeigen);
      Controls.Add(LblMeldung);
      Controls.Add(LblAmpel);
      Margin = new Padding(3, 4, 3, 4);
      Name = "Form1";
      Text = "Ampelsteuerung – Aufgabe 1";
      GrpFarbe.ResumeLayout(false);
      GrpFarbe.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    private GroupBox GrpFarbe;
    private RadioButton RadRot;
    private RadioButton RadGelb;
    private RadioButton RadGruen;
    private Button CmdAnzeigen;
    private Label LblMeldung;
    private Label LblAmpel;
  }

    #endregion
  
}
