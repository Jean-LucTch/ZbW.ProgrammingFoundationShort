using System.ComponentModel;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe1_TemperaturAuswertung;

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
      components.Dispose();
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
    LblMo = new System.Windows.Forms.Label();
    TxtMo = new System.Windows.Forms.TextBox();
    LblDi = new System.Windows.Forms.Label();
    TxtDi = new System.Windows.Forms.TextBox();
    LblMi = new System.Windows.Forms.Label();
    TxtMi = new System.Windows.Forms.TextBox();
    LblDo = new System.Windows.Forms.Label();
    TxtDo = new System.Windows.Forms.TextBox();
    LblFr = new System.Windows.Forms.Label();
    TxtFr = new System.Windows.Forms.TextBox();
    LblSa = new System.Windows.Forms.Label();
    TxtSa = new System.Windows.Forms.TextBox();
    LblSo = new System.Windows.Forms.Label();
    TxtSo = new System.Windows.Forms.TextBox();
    CmdAuswerten = new System.Windows.Forms.Button();
    LblDurchschnitt = new System.Windows.Forms.Label();
    LblMax = new System.Windows.Forms.Label();
    LblMin = new System.Windows.Forms.Label();
    SuspendLayout();
    // 
    // LblMo
    // 
    LblMo.Location = new System.Drawing.Point(0, 0);
    LblMo.Name = "LblMo";
    LblMo.Size = new System.Drawing.Size(100, 23);
    LblMo.TabIndex = 0;
    // 
    // TxtMo
    // 
    TxtMo.Location = new System.Drawing.Point(0, 0);
    TxtMo.Name = "TxtMo";
    TxtMo.Size = new System.Drawing.Size(100, 23);
    TxtMo.TabIndex = 0;
    // 
    // LblDi
    // 
    LblDi.Location = new System.Drawing.Point(0, 0);
    LblDi.Name = "LblDi";
    LblDi.Size = new System.Drawing.Size(100, 23);
    LblDi.TabIndex = 0;
    // 
    // TxtDi
    // 
    TxtDi.Location = new System.Drawing.Point(0, 0);
    TxtDi.Name = "TxtDi";
    TxtDi.Size = new System.Drawing.Size(100, 23);
    TxtDi.TabIndex = 0;
    // 
    // LblMi
    // 
    LblMi.Location = new System.Drawing.Point(0, 0);
    LblMi.Name = "LblMi";
    LblMi.Size = new System.Drawing.Size(100, 23);
    LblMi.TabIndex = 0;
    // 
    // TxtMi
    // 
    TxtMi.Location = new System.Drawing.Point(0, 0);
    TxtMi.Name = "TxtMi";
    TxtMi.Size = new System.Drawing.Size(100, 23);
    TxtMi.TabIndex = 0;
    // 
    // LblDo
    // 
    LblDo.Location = new System.Drawing.Point(0, 0);
    LblDo.Name = "LblDo";
    LblDo.Size = new System.Drawing.Size(100, 23);
    LblDo.TabIndex = 0;
    // 
    // TxtDo
    // 
    TxtDo.Location = new System.Drawing.Point(0, 0);
    TxtDo.Name = "TxtDo";
    TxtDo.Size = new System.Drawing.Size(100, 23);
    TxtDo.TabIndex = 0;
    // 
    // LblFr
    // 
    LblFr.Location = new System.Drawing.Point(0, 0);
    LblFr.Name = "LblFr";
    LblFr.Size = new System.Drawing.Size(100, 23);
    LblFr.TabIndex = 0;
    // 
    // TxtFr
    // 
    TxtFr.Location = new System.Drawing.Point(0, 0);
    TxtFr.Name = "TxtFr";
    TxtFr.Size = new System.Drawing.Size(100, 23);
    TxtFr.TabIndex = 0;
    // 
    // LblSa
    // 
    LblSa.Location = new System.Drawing.Point(0, 0);
    LblSa.Name = "LblSa";
    LblSa.Size = new System.Drawing.Size(100, 23);
    LblSa.TabIndex = 0;
    // 
    // TxtSa
    // 
    TxtSa.Location = new System.Drawing.Point(0, 0);
    TxtSa.Name = "TxtSa";
    TxtSa.Size = new System.Drawing.Size(100, 23);
    TxtSa.TabIndex = 0;
    // 
    // LblSo
    // 
    LblSo.Location = new System.Drawing.Point(0, 0);
    LblSo.Name = "LblSo";
    LblSo.Size = new System.Drawing.Size(100, 23);
    LblSo.TabIndex = 0;
    // 
    // TxtSo
    // 
    TxtSo.Location = new System.Drawing.Point(0, 0);
    TxtSo.Name = "TxtSo";
    TxtSo.Size = new System.Drawing.Size(100, 23);
    TxtSo.TabIndex = 0;
    // 
    // CmdAuswerten
    // 
    CmdAuswerten.Location = new System.Drawing.Point(12, 235);
    CmdAuswerten.Name = "CmdAuswerten";
    CmdAuswerten.Size = new System.Drawing.Size(130, 28);
    CmdAuswerten.TabIndex = 0;
    CmdAuswerten.Text = "Auswerten";
    CmdAuswerten.Click += CmdAuswerten_Click;
    // 
    // LblDurchschnitt
    // 
    LblDurchschnitt.AutoSize = true;
    LblDurchschnitt.Location = new System.Drawing.Point(12, 275);
    LblDurchschnitt.Name = "LblDurchschnitt";
    LblDurchschnitt.Size = new System.Drawing.Size(0, 15);
    LblDurchschnitt.TabIndex = 1;
    // 
    // LblMax
    // 
    LblMax.AutoSize = true;
    LblMax.Location = new System.Drawing.Point(12, 295);
    LblMax.Name = "LblMax";
    LblMax.Size = new System.Drawing.Size(0, 15);
    LblMax.TabIndex = 2;
    // 
    // LblMin
    // 
    LblMin.AutoSize = true;
    LblMin.Location = new System.Drawing.Point(12, 315);
    LblMin.Name = "LblMin";
    LblMin.Size = new System.Drawing.Size(0, 15);
    LblMin.TabIndex = 3;
    // 
    // Form1
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(280, 345);
    Controls.Add(CmdAuswerten);
    Controls.Add(LblDurchschnitt);
    Controls.Add(LblMax);
    Controls.Add(LblMin);
    Text = "Temperatur-Auswertung – Aufgabe 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblMo; private TextBox TxtMo;
  private Label LblDi; private TextBox TxtDi;
  private Label LblMi; private TextBox TxtMi;
  private Label LblDo; private TextBox TxtDo;
  private Label LblFr; private TextBox TxtFr;
  private Label LblSa; private TextBox TxtSa;
  private Label LblSo; private TextBox TxtSo;
  private System.Windows.Forms.Button CmdAuswerten;
  private Label LblDurchschnitt;
  private Label LblMax;
  private Label LblMin;

  #endregion
}

