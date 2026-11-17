namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag3_MatrixMultiplikation;

/// <summary>
///   Lösung: Auftrag 3 – Matrix-Multiplikation
///   2×2-Matrizen multiplizieren mit geschachtelten Schleifen.
/// </summary>
public static class MatrixRechnerLoesung
{
  private const int Size = 2; // 2×2-Matrix

  public static void Start()
  {
    int[,] matrixA = { { 1, 2 }, { 3, 4 } };
    int[,] matrixB = { { 5, 6 }, { 7, 8 } };

    Console.WriteLine("Matrix A:");
    PrintMatrix(matrixA);
    Console.WriteLine("Matrix B:");
    PrintMatrix(matrixB);

    int[,] product = Multiply(matrixA, matrixB);
    Console.WriteLine("A × B =");
    PrintMatrix(product);
    // Erwartetes Ergebnis: [[19,22],[43,50]]
  }

  public static int[,] Multiply(int[,] matrixA, int[,] matrixB)
  {
    int[,] result = new int[Size, Size];
    for (int row = 0; row < Size; row++)
    {
      for (int column = 0; column < Size; column++)
      {
        // Zeile row von A mit Spalte column von B "verrechnen":
        // step läuft gleichzeitig nach rechts durch die Zeile von A
        // und nach unten durch die Spalte von B.
        //
        // Beispiel result[0, 0]:  A[0,0]·B[0,0] + A[0,1]·B[1,0] = 1·5 + 2·7 = 19
        //                         step = 0        step = 1
        for (int step = 0; step < Size; step++)
        {
          result[row, column] += matrixA[row, step] * matrixB[step, column];
        }
      }
    }

    return result;
  }

  private static void PrintMatrix(int[,] matrix)
  {
    for (int row = 0; row < Size; row++)
    {
      Console.WriteLine($"  | {matrix[row, 0],4} {matrix[row, 1],4} |");
    }
  }
}
