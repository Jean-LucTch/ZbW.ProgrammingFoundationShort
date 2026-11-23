namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe3_MatrizenRechner;

/// <summary>
///   Aufgabe 3 – Matrizen-Rechner (⭐⭐⭐ Schwer)
///   3×3-Matrix-Addition und Transposition.
/// </summary>
public partial class MatrizenRechnerForm : Form
{
  // Eine 3×3-Matrix hat 3 Zeilen und 3 Spalten.
  private const int RowCount = 3;
  private const int ColumnCount = 3;

  public MatrizenRechnerForm()
  {
    InitializeComponent();
  }

  // Eine Methode für beide Matrizen – die TextBoxen werden als Parameter übergeben
  private static int[,] ReadMatrix(TextBox[,] inputFields, string matrixName)
  {
    int[,] matrix = new int[RowCount, ColumnCount];
    for (int row = 0; row < RowCount; row++)
    {
      for (int column = 0; column < ColumnCount; column++)
      {
        string input = inputFields[row, column].Text;
        if (!int.TryParse(input, out int number))
        {
          // +1, damit die Meldung bei 1 zu zählen beginnt (Zeile 1 statt Zeile 0)
          throw new FormatException(
            $"Ungültiger Wert «{input}» in Matrix {matrixName}, Zeile {row + 1}, Spalte {column + 1}.");
        }

        matrix[row, column] = number;
      }
    }

    return matrix;
  }

  private int[,] ReadMatrixA()
  {
    // Namensschema: Txt<Matrix>_R<Row>C<Column>
    TextBox[,] inputFields =
    {
      //  Spalte 1    Spalte 2    Spalte 3
      { TxtA_R1C1, TxtA_R1C2, TxtA_R1C3 }, // Zeile 1
      { TxtA_R2C1, TxtA_R2C2, TxtA_R2C3 }, // Zeile 2
      { TxtA_R3C1, TxtA_R3C2, TxtA_R3C3 }  // Zeile 3
    };
    return ReadMatrix(inputFields, "A");
  }

  private int[,] ReadMatrixB()
  {
    TextBox[,] inputFields =
    {
      { TxtB_R1C1, TxtB_R1C2, TxtB_R1C3 },
      { TxtB_R2C1, TxtB_R2C2, TxtB_R2C3 },
      { TxtB_R3C1, TxtB_R3C2, TxtB_R3C3 }
    };
    return ReadMatrix(inputFields, "B");
  }

  private void CmdAddieren_Click(object sender, EventArgs e)
  {
    try
    {
      int[,] matrixA = ReadMatrixA();
      int[,] matrixB = ReadMatrixB();
      int[,] sumMatrix = AddMatrices(matrixA, matrixB);
      LblErgebnis.Text = "A + B =" + Environment.NewLine + MatrixToText(sumMatrix);
    }
    catch (FormatException ex)
    {
      MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  private void CmdTransponieren_Click(object sender, EventArgs e)
  {
    try
    {
      int[,] matrixA = ReadMatrixA();
      int[,] transposedMatrix = Transpose(matrixA);
      LblErgebnis.Text = "A^T =" + Environment.NewLine + MatrixToText(transposedMatrix);
    }
    catch (FormatException ex)
    {
      MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  // Addition: Jedes Element wird mit dem Element an derselben Position addiert.
  private static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
  {
    int[,] sumMatrix = new int[RowCount, ColumnCount];
    for (int row = 0; row < RowCount; row++)
    {
      for (int column = 0; column < ColumnCount; column++)
      {
        sumMatrix[row, column] = matrixA[row, column] + matrixB[row, column];
      }
    }

    return sumMatrix;
  }

  // Transposition: Zeilen werden zu Spalten (Spiegelung an der Diagonale).
  private static int[,] Transpose(int[,] matrix)
  {
    int[,] transposedMatrix = new int[ColumnCount, RowCount];
    for (int row = 0; row < RowCount; row++)
    {
      for (int column = 0; column < ColumnCount; column++)
      {
        transposedMatrix[column, row] = matrix[row, column];
      }
    }

    return transposedMatrix;
  }

  // Gibt die Matrix als mehrzeiligen Text zurück, z.B. "|    1    2    3 |"
  private static string MatrixToText(int[,] matrix)
  {
    string text = "";
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
      text += "| ";
      for (int column = 0; column < matrix.GetLength(1); column++)
      {
        text += $"{matrix[row, column],4} ";
      }

      text += "|" + Environment.NewLine;
    }

    return text;
  }
}
