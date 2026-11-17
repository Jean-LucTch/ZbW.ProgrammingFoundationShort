namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe3_MatrizenRechner;

partial class MatrizenRechnerForm
{
  /// <summary>
  ///   Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///   Clean up any resources being used.
  /// </summary>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  // Namensschema der Eingabefelder: Txt<Matrix>_R<Row>C<Column>
  //   z.B. TxtA_R2C3 = Matrix A, Zeile 2, Spalte 3 (Zählung ab 1)
  private void InitializeComponent()
  {
    LblMatrixA = new Label();
    LblMatrixB = new Label();
    TxtA_R1C1 = new TextBox();
    TxtA_R1C2 = new TextBox();
    TxtA_R1C3 = new TextBox();
    TxtA_R2C1 = new TextBox();
    TxtA_R2C2 = new TextBox();
    TxtA_R2C3 = new TextBox();
    TxtA_R3C1 = new TextBox();
    TxtA_R3C2 = new TextBox();
    TxtA_R3C3 = new TextBox();
    TxtB_R1C1 = new TextBox();
    TxtB_R1C2 = new TextBox();
    TxtB_R1C3 = new TextBox();
    TxtB_R2C1 = new TextBox();
    TxtB_R2C2 = new TextBox();
    TxtB_R2C3 = new TextBox();
    TxtB_R3C1 = new TextBox();
    TxtB_R3C2 = new TextBox();
    TxtB_R3C3 = new TextBox();
    CmdAddieren = new Button();
    CmdTransponieren = new Button();
    LblErgebnis = new Label();
    SuspendLayout();
    // 
    // LblMatrixA
    // 
    LblMatrixA.AutoSize = true;
    LblMatrixA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblMatrixA.Location = new Point(12, 12);
    LblMatrixA.Name = "LblMatrixA";
    LblMatrixA.Size = new Size(72, 19);
    LblMatrixA.TabIndex = 0;
    LblMatrixA.Text = "Matrix A:";
    // 
    // TxtA_R1C1  (Matrix A, Zeile 1, Spalte 1)
    // 
    TxtA_R1C1.Location = new Point(12, 35);
    TxtA_R1C1.Name = "TxtA_R1C1";
    TxtA_R1C1.Size = new Size(45, 23);
    TxtA_R1C1.TabIndex = 1;
    TxtA_R1C1.Text = "0";
    // 
    // TxtA_R1C2  (Matrix A, Zeile 1, Spalte 2)
    // 
    TxtA_R1C2.Location = new Point(62, 35);
    TxtA_R1C2.Name = "TxtA_R1C2";
    TxtA_R1C2.Size = new Size(45, 23);
    TxtA_R1C2.TabIndex = 2;
    TxtA_R1C2.Text = "0";
    // 
    // TxtA_R1C3  (Matrix A, Zeile 1, Spalte 3)
    // 
    TxtA_R1C3.Location = new Point(112, 35);
    TxtA_R1C3.Name = "TxtA_R1C3";
    TxtA_R1C3.Size = new Size(45, 23);
    TxtA_R1C3.TabIndex = 3;
    TxtA_R1C3.Text = "0";
    // 
    // TxtA_R2C1  (Matrix A, Zeile 2, Spalte 1)
    // 
    TxtA_R2C1.Location = new Point(12, 65);
    TxtA_R2C1.Name = "TxtA_R2C1";
    TxtA_R2C1.Size = new Size(45, 23);
    TxtA_R2C1.TabIndex = 4;
    TxtA_R2C1.Text = "0";
    // 
    // TxtA_R2C2  (Matrix A, Zeile 2, Spalte 2)
    // 
    TxtA_R2C2.Location = new Point(62, 65);
    TxtA_R2C2.Name = "TxtA_R2C2";
    TxtA_R2C2.Size = new Size(45, 23);
    TxtA_R2C2.TabIndex = 5;
    TxtA_R2C2.Text = "0";
    // 
    // TxtA_R2C3  (Matrix A, Zeile 2, Spalte 3)
    // 
    TxtA_R2C3.Location = new Point(112, 65);
    TxtA_R2C3.Name = "TxtA_R2C3";
    TxtA_R2C3.Size = new Size(45, 23);
    TxtA_R2C3.TabIndex = 6;
    TxtA_R2C3.Text = "0";
    // 
    // TxtA_R3C1  (Matrix A, Zeile 3, Spalte 1)
    // 
    TxtA_R3C1.Location = new Point(12, 95);
    TxtA_R3C1.Name = "TxtA_R3C1";
    TxtA_R3C1.Size = new Size(45, 23);
    TxtA_R3C1.TabIndex = 7;
    TxtA_R3C1.Text = "0";
    // 
    // TxtA_R3C2  (Matrix A, Zeile 3, Spalte 2)
    // 
    TxtA_R3C2.Location = new Point(62, 95);
    TxtA_R3C2.Name = "TxtA_R3C2";
    TxtA_R3C2.Size = new Size(45, 23);
    TxtA_R3C2.TabIndex = 8;
    TxtA_R3C2.Text = "0";
    // 
    // TxtA_R3C3  (Matrix A, Zeile 3, Spalte 3)
    // 
    TxtA_R3C3.Location = new Point(112, 95);
    TxtA_R3C3.Name = "TxtA_R3C3";
    TxtA_R3C3.Size = new Size(45, 23);
    TxtA_R3C3.TabIndex = 9;
    TxtA_R3C3.Text = "0";
    // 
    // LblMatrixB
    // 
    LblMatrixB.AutoSize = true;
    LblMatrixB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblMatrixB.Location = new Point(200, 12);
    LblMatrixB.Name = "LblMatrixB";
    LblMatrixB.Size = new Size(72, 19);
    LblMatrixB.TabIndex = 10;
    LblMatrixB.Text = "Matrix B:";
    // 
    // TxtB_R1C1  (Matrix B, Zeile 1, Spalte 1)
    // 
    TxtB_R1C1.Location = new Point(200, 35);
    TxtB_R1C1.Name = "TxtB_R1C1";
    TxtB_R1C1.Size = new Size(45, 23);
    TxtB_R1C1.TabIndex = 11;
    TxtB_R1C1.Text = "0";
    // 
    // TxtB_R1C2  (Matrix B, Zeile 1, Spalte 2)
    // 
    TxtB_R1C2.Location = new Point(250, 35);
    TxtB_R1C2.Name = "TxtB_R1C2";
    TxtB_R1C2.Size = new Size(45, 23);
    TxtB_R1C2.TabIndex = 12;
    TxtB_R1C2.Text = "0";
    // 
    // TxtB_R1C3  (Matrix B, Zeile 1, Spalte 3)
    // 
    TxtB_R1C3.Location = new Point(300, 35);
    TxtB_R1C3.Name = "TxtB_R1C3";
    TxtB_R1C3.Size = new Size(45, 23);
    TxtB_R1C3.TabIndex = 13;
    TxtB_R1C3.Text = "0";
    // 
    // TxtB_R2C1  (Matrix B, Zeile 2, Spalte 1)
    // 
    TxtB_R2C1.Location = new Point(200, 65);
    TxtB_R2C1.Name = "TxtB_R2C1";
    TxtB_R2C1.Size = new Size(45, 23);
    TxtB_R2C1.TabIndex = 14;
    TxtB_R2C1.Text = "0";
    // 
    // TxtB_R2C2  (Matrix B, Zeile 2, Spalte 2)
    // 
    TxtB_R2C2.Location = new Point(250, 65);
    TxtB_R2C2.Name = "TxtB_R2C2";
    TxtB_R2C2.Size = new Size(45, 23);
    TxtB_R2C2.TabIndex = 15;
    TxtB_R2C2.Text = "0";
    // 
    // TxtB_R2C3  (Matrix B, Zeile 2, Spalte 3)
    // 
    TxtB_R2C3.Location = new Point(300, 65);
    TxtB_R2C3.Name = "TxtB_R2C3";
    TxtB_R2C3.Size = new Size(45, 23);
    TxtB_R2C3.TabIndex = 16;
    TxtB_R2C3.Text = "0";
    // 
    // TxtB_R3C1  (Matrix B, Zeile 3, Spalte 1)
    // 
    TxtB_R3C1.Location = new Point(200, 95);
    TxtB_R3C1.Name = "TxtB_R3C1";
    TxtB_R3C1.Size = new Size(45, 23);
    TxtB_R3C1.TabIndex = 17;
    TxtB_R3C1.Text = "0";
    // 
    // TxtB_R3C2  (Matrix B, Zeile 3, Spalte 2)
    // 
    TxtB_R3C2.Location = new Point(250, 95);
    TxtB_R3C2.Name = "TxtB_R3C2";
    TxtB_R3C2.Size = new Size(45, 23);
    TxtB_R3C2.TabIndex = 18;
    TxtB_R3C2.Text = "0";
    // 
    // TxtB_R3C3  (Matrix B, Zeile 3, Spalte 3)
    // 
    TxtB_R3C3.Location = new Point(300, 95);
    TxtB_R3C3.Name = "TxtB_R3C3";
    TxtB_R3C3.Size = new Size(45, 23);
    TxtB_R3C3.TabIndex = 19;
    TxtB_R3C3.Text = "0";
    // 
    // CmdAddieren
    // 
    CmdAddieren.Location = new Point(12, 135);
    CmdAddieren.Name = "CmdAddieren";
    CmdAddieren.Size = new Size(130, 28);
    CmdAddieren.TabIndex = 20;
    CmdAddieren.Text = "A + B Addieren";
    CmdAddieren.UseVisualStyleBackColor = true;
    CmdAddieren.Click += CmdAddieren_Click;
    // 
    // CmdTransponieren
    // 
    CmdTransponieren.Location = new Point(155, 135);
    CmdTransponieren.Name = "CmdTransponieren";
    CmdTransponieren.Size = new Size(130, 28);
    CmdTransponieren.TabIndex = 21;
    CmdTransponieren.Text = "A Transponieren";
    CmdTransponieren.UseVisualStyleBackColor = true;
    CmdTransponieren.Click += CmdTransponieren_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Courier New", 10F);
    LblErgebnis.Location = new Point(12, 175);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 16);
    LblErgebnis.TabIndex = 22;
    // 
    // MatrizenRechnerForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(420, 320);
    Controls.Add(LblMatrixA);
    Controls.Add(TxtA_R1C1);
    Controls.Add(TxtA_R1C2);
    Controls.Add(TxtA_R1C3);
    Controls.Add(TxtA_R2C1);
    Controls.Add(TxtA_R2C2);
    Controls.Add(TxtA_R2C3);
    Controls.Add(TxtA_R3C1);
    Controls.Add(TxtA_R3C2);
    Controls.Add(TxtA_R3C3);
    Controls.Add(LblMatrixB);
    Controls.Add(TxtB_R1C1);
    Controls.Add(TxtB_R1C2);
    Controls.Add(TxtB_R1C3);
    Controls.Add(TxtB_R2C1);
    Controls.Add(TxtB_R2C2);
    Controls.Add(TxtB_R2C3);
    Controls.Add(TxtB_R3C1);
    Controls.Add(TxtB_R3C2);
    Controls.Add(TxtB_R3C3);
    Controls.Add(CmdAddieren);
    Controls.Add(CmdTransponieren);
    Controls.Add(LblErgebnis);
    Name = "MatrizenRechnerForm";
    Text = "Matrizen-Rechner – Aufgabe 3";
    ResumeLayout(false);
    PerformLayout();
  }

  #endregion

  private Label LblMatrixA;
  private TextBox TxtA_R1C1;
  private TextBox TxtA_R1C2;
  private TextBox TxtA_R1C3;
  private TextBox TxtA_R2C1;
  private TextBox TxtA_R2C2;
  private TextBox TxtA_R2C3;
  private TextBox TxtA_R3C1;
  private TextBox TxtA_R3C2;
  private TextBox TxtA_R3C3;
  private Label LblMatrixB;
  private TextBox TxtB_R1C1;
  private TextBox TxtB_R1C2;
  private TextBox TxtB_R1C3;
  private TextBox TxtB_R2C1;
  private TextBox TxtB_R2C2;
  private TextBox TxtB_R2C3;
  private TextBox TxtB_R3C1;
  private TextBox TxtB_R3C2;
  private TextBox TxtB_R3C3;
  private Button CmdAddieren;
  private Button CmdTransponieren;
  private Label LblErgebnis;
}
