namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe2_Wortzaehler;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();
  }

  private void CmdAnalysieren_Click(object sender, EventArgs e)
  {
    string[] wordarray = TextToWords(TxtEingabe.Text);
    int countwords = CountWords(wordarray);
    int countchars = CountCharacters(TxtEingabe.Text);
    string longestWord = LongestWord(wordarray);

    LblErgebnis.Text = $"Wörter: {countwords}, Characters: {countchars}, Längste Word: {longestWord}";
    //throw new System.NotImplementedException();
  }

  string[] TextToWords(string text)
  {
    if (string.IsNullOrWhiteSpace(text))
    {
      return Array.Empty<string>();
    }

    char[] delimiters = new char[]
    {
      ' ', '\r', '\n', '\t', '.', ',', ';', ':', '!', '?',
      '"', '(', ')', '[', ']', '{', '}', '-', '_', '/'
    };

    return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
  }


  int CountWords(string[] words)
  {
    int count = 0;
    foreach (var i in words)
    {
      count++;
    }
    return count;
  }

  int CountCharacters(string text)
  {
    string newtext = text.Replace(" ", "");
    return newtext.Length;
  }

  string LongestWord(string[] words)
  {
    string longestWord = "";

    foreach (var i in words)
    {
      if (i.Length > longestWord.Length)
      {
        longestWord = i;
      }
    }
    return longestWord;
  }
}

