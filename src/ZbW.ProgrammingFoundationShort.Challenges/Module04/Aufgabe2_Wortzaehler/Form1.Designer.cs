using System.ComponentModel;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe2_Wortzaehler;

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
    LblEingabe = new System.Windows.Forms.Label();
    TxtEingabe = new System.Windows.Forms.TextBox();
    CmdAnalysieren = new System.Windows.Forms.Button();
    LblErgebnis = new System.Windows.Forms.Label();
    SuspendLayout();
    // 
    // LblEingabe
    // 
    LblEingabe.AutoSize = true;
    LblEingabe.Location = new System.Drawing.Point(12, 12);
    LblEingabe.Name = "LblEingabe";
    LblEingabe.Size = new System.Drawing.Size(105, 20);
    LblEingabe.TabIndex = 0;
    LblEingabe.Text = "Text eingeben:";
    // 
    // TxtEingabe
    // 
    TxtEingabe.Location = new System.Drawing.Point(12, 30);
    TxtEingabe.Multiline = true;
    TxtEingabe.Name = "TxtEingabe";
    TxtEingabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
    TxtEingabe.Size = new System.Drawing.Size(420, 120);
    TxtEingabe.TabIndex = 1;
    // 
    // CmdAnalysieren
    // 
    CmdAnalysieren.Location = new System.Drawing.Point(12, 160);
    CmdAnalysieren.Name = "CmdAnalysieren";
    CmdAnalysieren.Size = new System.Drawing.Size(130, 28);
    CmdAnalysieren.TabIndex = 2;
    CmdAnalysieren.Text = "Analysieren";
    CmdAnalysieren.Click += CmdAnalysieren_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new System.Drawing.Point(12, 200);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new System.Drawing.Size(0, 20);
    LblErgebnis.TabIndex = 3;
    // 
    // Form1
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(450, 280);
    Controls.Add(LblEingabe);
    Controls.Add(TxtEingabe);
    Controls.Add(CmdAnalysieren);
    Controls.Add(LblErgebnis);
    Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    Text = "Wortzähler – Aufgabe 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblEingabe;
  private TextBox TxtEingabe;
  private System.Windows.Forms.Button CmdAnalysieren;
  private Label LblErgebnis;

  #endregion
}

