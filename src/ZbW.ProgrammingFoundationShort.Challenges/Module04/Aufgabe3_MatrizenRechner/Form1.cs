namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe3_MatrizenRechner;

public partial class Form1 : Form
{


  public Form1()
  {
    InitializeComponent();

    // Matrix A Label
    LblA.AutoSize = true;
    LblA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblA.Location = new Point(12, 12);
    LblA.Text = "Matrix A:";

    // Matrix A TextBoxen (3×3, Grösse 45×23)
    int baseX = 12, baseY = 35, sz = 45, gap = 50;
    TextBox[,] a = { { TxtA00, TxtA01, TxtA02 }, { TxtA10, TxtA11, TxtA12 }, { TxtA20, TxtA21, TxtA22 } };
    string[,] nA = { { "TxtA00", "TxtA01", "TxtA02" }, { "TxtA10", "TxtA11", "TxtA12" }, { "TxtA20", "TxtA21", "TxtA22" } };
    for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
    {
      a[i, j].Location = new Point(baseX + j * gap, baseY + i * 30);
      a[i, j].Name = nA[i, j];
      a[i, j].Size = new Size(sz, 23);
      a[i, j].Text = "0";
      Controls.Add(a[i, j]);
    }

    // Matrix B Label
    LblB.AutoSize = true;
    LblB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblB.Location = new Point(200, 12);
    LblB.Text = "Matrix B:";

    // Matrix B TextBoxen
    TextBox[,] b = { { TxtB00, TxtB01, TxtB02 }, { TxtB10, TxtB11, TxtB12 }, { TxtB20, TxtB21, TxtB22 } };
    string[,] nB = { { "TxtB00", "TxtB01", "TxtB02" }, { "TxtB10", "TxtB11", "TxtB12" }, { "TxtB20", "TxtB21", "TxtB22" } };
    int bX = 200;
    for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
    {
      b[i, j].Location = new Point(bX + j * gap, baseY + i * 30);
      b[i, j].Name = nB[i, j];
      b[i, j].Size = new Size(sz, 23);
      b[i, j].Text = "0";
      Controls.Add(b[i, j]);
    }
  }
  private void CmdAddieren_Click(object sender, EventArgs e)
  {
    if (!vailidateInput())
    {
      return;
    }

    TextBox[,] aFields = {
      { TxtA00, TxtA01, TxtA02 },
      { TxtA10, TxtA11, TxtA12 },
      { TxtA20, TxtA21, TxtA22 }
    };
    TextBox[,] bFields = {
      { TxtB00, TxtB01, TxtB02 },
      { TxtB10, TxtB11, TxtB12 },
      { TxtB20, TxtB21, TxtB22 }
    };
    int[,] a = new int[3, 3];
    int[,] b = new int[3, 3];

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        a[i, j] = int.Parse(aFields[i, j].Text);
        b[i, j] = int.Parse(bFields[i, j].Text);
      }
    }

    int[,] result = AddMatrices(a, b);
    LblErgebnis.Text = "A + B =\r\n";
    ShowMatrix(result, LblErgebnis);
  }

  private void CmdTransponieren_Click(object sender, EventArgs e)
  {
    if (!vailidateInput())
    {
      return;
    }

    TextBox[,] aFields = {
      { TxtA00, TxtA01, TxtA02 },
      { TxtA10, TxtA11, TxtA12 },
      { TxtA20, TxtA21, TxtA22 }
    };

    int[,] a = new int[3, 3];

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        a[i, j] = int.Parse(aFields[i, j].Text);
      }
    }

    int[,] result = Transpose(a);

    LblErgebnis.Text = "A transponiert =\r\n";
    ShowMatrix(result, LblErgebnis);
  }

  int[,] AddMatrices(int[,] a, int[,] b)
  {
    int[,] finalMatrices =
    {
      { 0, 0, 0 },
      { 0, 0, 0 },
      { 0, 0, 0 }
    };

    int avar = 0;
    int bvar = 0;

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        avar = a[i, j];
        bvar = b[i, j];
        finalMatrices[i, j] = avar + bvar;
      }
    }

    return finalMatrices;
  }

  int[,] Transpose(int[,] matrix)
  {
    int a = matrix[0,0], b = matrix[0,1], c = matrix[0,2], d = matrix[1,0], e = matrix[1,1], f = matrix[1,2], g = matrix[2,0], h = matrix[2,1], i = matrix[2,2];

    int[,] finalMatrices =
    {
      { a, d, g },
      { b, e, h },
      { c, f, i }
    };

    return finalMatrices;
  }

  void ShowMatrix(int[,] matrix, Label label)
  {
    for (int i = 0; i < 3; i++)
    {
      string row = "| ";
      for (int j = 0; j < 3; j++)
      {
        row += $"{matrix[i, j],4} ";
      }

      label.Text += row + "|" + Environment.NewLine;
    }
  }

  private bool vailidateInput()
  {
    TextBox[,] a = { { TxtA00, TxtA01, TxtA02 }, { TxtA10, TxtA11, TxtA12 }, { TxtA20, TxtA21, TxtA22 } };
    TextBox[,] b = { { TxtB00, TxtB01, TxtB02 }, { TxtB10, TxtB11, TxtB12 }, { TxtB20, TxtB21, TxtB22 } };

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if(int.TryParse(a[i, j].Text, out int valA)){}
        else { MessageBox.Show("Ungültigen Wert ausgegeben bei Matrix A."); return false; }
      }
    }

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if(int.TryParse(b[i, j].Text, out int valB)){}
        else { MessageBox.Show("Ungültigen Wert ausgegeben bei Matrix B."); return false;}
      }
    }
    return true;
  }
}
