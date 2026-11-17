namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag3_MatrixMultiplikation;

// ============================================================
// AUFTRAG 3 – MatrixMultiplikation (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Multipliziert zwei 2×2-Matrizen.
//
// Anforderungen:
//   - Methode int[,] Multiply(int[,] matrixA, int[,] matrixB)
//   - Formel: result[row, column] = Summe über step von matrixA[row, step] * matrixB[step, column]
//       → Zeile aus A und Spalte aus B werden Stück für Stück
//         miteinander multipliziert und aufsummiert.
//   - Start() mit zwei Beispielmatrizen und Ausgabe
//
// Beispiel für result[0, 0] (Zeile 1 von A · Spalte 1 von B):
//
//     A = | 1  2 |    B = | 5  6 |
//         | 3  4 |        | 7  8 |
//
//     result[0, 0] = A[0,0]·B[0,0] + A[0,1]·B[1,0] = 1·5 + 2·7 = 19
//                    step = 0        step = 1
// ============================================================

public static class MatrixRechner
{
  public static void Start()
  {
    // TODO 1: Zwei 2×2-Matrizen definieren
    //         int[,] matrixA = { {1, 2}, {3, 4} };
    //         int[,] matrixB = { {5, 6}, {7, 8} };

    // TODO 2: Multiply aufrufen und Ergebnis ausgeben
  }

  public static int[,] Multiply(int[,] matrixA, int[,] matrixB)
  {
    // TODO: 2×2 Matrix-Multiplikation implementieren
    //
    //   int[,] result = new int[2, 2];
    //
    //   für jede row (Zeile, 0..1):
    //     für jede column (Spalte, 0..1):
    //       für jeden step (0..1):    ← step läuft nach rechts durch die Zeile von A
    //                                   und nach unten durch die Spalte von B
    //         result[row, column] += matrixA[row, step] * matrixB[step, column]
    throw new NotImplementedException("TODO: Multiply implementieren");
  }
}
