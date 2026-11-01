namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe2_Notenrechner
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
      LblNote = new Label();
      TxtNote = new TextBox();
      ChkDetails = new CheckBox();
      CmdBewerten = new Button();
      LblErgebnis = new Label();
      SuspendLayout();
      // 
      // LblNote
      // 
      LblNote.AutoSize = true;
      LblNote.Location = new Point(12, 20);
      LblNote.Name = "LblNote";
      LblNote.Size = new Size(83, 15);
      LblNote.TabIndex = 0;
      LblNote.Text = "Note (1.0–6.0):";
      // 
      // TxtNote
      // 
      TxtNote.Location = new Point(140, 17);
      TxtNote.Name = "TxtNote";
      TxtNote.Size = new Size(80, 23);
      TxtNote.TabIndex = 1;
      // 
      // ChkDetails
      // 
      ChkDetails.AutoSize = true;
      ChkDetails.Location = new Point(12, 50);
      ChkDetails.Name = "ChkDetails";
      ChkDetails.Size = new Size(185, 19);
      ChkDetails.TabIndex = 2;
      ChkDetails.Text = "Details anzeigen (Prozentwert)";
      // 
      // CmdBewerten
      // 
      CmdBewerten.Location = new Point(12, 80);
      CmdBewerten.Name = "CmdBewerten";
      CmdBewerten.Size = new Size(120, 28);
      CmdBewerten.TabIndex = 3;
      CmdBewerten.Text = "Bewerten";
      CmdBewerten.Click += CmdBewerten_Click;
      // 
      // LblErgebnis
      // 
      LblErgebnis.AutoSize = true;
      LblErgebnis.Location = new Point(12, 120);
      LblErgebnis.Name = "LblErgebnis";
      LblErgebnis.Size = new Size(0, 15);
      LblErgebnis.TabIndex = 4;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(320, 170);
      Controls.Add(LblNote);
      Controls.Add(TxtNote);
      Controls.Add(ChkDetails);
      Controls.Add(CmdBewerten);
      Controls.Add(LblErgebnis);
      Name = "Form1";
      Text = "Notenrechner – Aufgabe 2";
      ResumeLayout(false);
      PerformLayout();
    }

    private Label LblNote;
    private TextBox TxtNote;
    private CheckBox ChkDetails;
    private Button CmdBewerten;
    private Label LblErgebnis;

    #endregion
  }
}
