using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;

namespace BattleOfStalingrad
{
    internal class GameOverScene
    {
        public static int sceneId = 2;                       // czy gracz wpisał już swoje imię
        public static List<string> greatestSoldiersNames = new List<string>();  // nazwy najlepszych graczy
        public static List<int> greatestSoldiersScores = new List<int>();       // wyniki najlepszych graczy
        public static Dictionary<string, int> ranking = new Dictionary<string, int>();
        private static string contents = System.IO.File.ReadAllText(System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\Results.txt"));
        public static string Contents { get { return contents; } }
        public static void Start(int playerScore)
        {
            while (Console.KeyAvailable) Console.ReadKey(true);  // czyszczenie wejścia konsoli
            GameManager.ActiveSceneId = 2;
            GraphicMiscellaneous.EraseRectangle(1, 1, 195, 48);
            Console.SetCursorPosition(80, 20);
            Console.Write("State your name, soldier: ");            
            string playerName = Console.ReadLine();
            
            while (HasComma(playerName))
            {
                Console.SetCursorPosition(80, 20);
                Console.WriteLine("Player's name cannot contain comma");
                Console.SetCursorPosition(80, 21);
                Console.Write("                                                                       ");
                Console.SetCursorPosition(80, 21);
                Console.Write("State your name, soldier: ");
                playerName = Console.ReadLine();                
            }

            greatestSoldiersNames.Add(playerName);
            greatestSoldiersScores.Add(playerScore);
            File2Dictionary();         

            SaveToFile();
            int playerRanking = greatestSoldiersNames.IndexOf(playerName) + 1;  // przypisać zmiennej playerRanking pozycję gracza na liście
            
            GameOverSceneGraphic.DrawScoreTable(greatestSoldiersNames, greatestSoldiersScores, playerRanking);
        }

        private static bool HasComma(string word)
        {
            if (word.Contains(',')) return true;
            return false;
        }

        private static void Sort()  //insertion sort list z nazwami i wynikami graczy
        {
            int n = greatestSoldiersScores.Count;
            int key, j;
            string temp;
            for (int i = 1; i < n; i++)
            {
                key = greatestSoldiersScores[i];
                temp = greatestSoldiersNames[i];
                j = i - 1;
                while (j >= 0 && greatestSoldiersScores[j] < key)
                {
                    greatestSoldiersScores[j + 1] = greatestSoldiersScores[j];
                    greatestSoldiersNames[j + 1] = greatestSoldiersNames[j];
                    j--;
                }
                greatestSoldiersScores[j + 1] = key;
                greatestSoldiersNames[j + 1] = temp;
            }
        }
        private static void File2Dictionary()  //zamiana list na słownik
        {
            String[] splitContents = Contents.Split(',');
            for (int i = 0; i < splitContents.Length; i++)
            {
                if (i % 2 == 0) greatestSoldiersNames.Add(splitContents[i]);
                else greatestSoldiersScores.Add(Int32.Parse(splitContents[i]));
            }

            Sort();

            //for (int i = 0; i < greatestSoldiersNames.Count; i++) ranking.Add(greatestSoldiersNames[i], greatestSoldiersScores[i]);

        }
        private static void SaveToFile()  //zapisywanie do pliku
        {
            StreamWriter sw = new StreamWriter(System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\Results.txt"));
            for (int i = 0; i < greatestSoldiersScores.Count; i++)
            {
                if (i != 0) sw.Write(",");
                sw.Write(greatestSoldiersNames[i] + "," + greatestSoldiersScores[i]);
            }
            sw.Close();
        }
        public static void KeyPressed(Key key)
        {
            if (key == Key.Space) MenuScene.Start();  // spacja zamyka okno z wynikami
        }
    }
}
