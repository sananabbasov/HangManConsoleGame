string[] words = { "dog", "cat", "pen", "sos", "bag", "hug", "dig", "leg", "bug", "book" };
var rand = new Random();
int myRand = rand.Next(1, words.Length);
int wordsLenght = words[myRand].Length;
string myWord = words[myRand];
int health = 6;
int count = 0;
string[] userWord = new string[wordsLenght];
List<char> wrongChar = new();

for (int i = 0; i < userWord.Length; i++)
{
    userWord[i] = "_ ";
}

for (int i = 0; i < wordsLenght; i++)
{
    Console.Write("_ ");
}
Console.WriteLine();
Top:
Console.WriteLine("Type letter: ");
char searchedWord = Convert.ToChar(Console.ReadLine());
bool checkWord = CheckChar(searchedWord);

if (checkWord)
{
    goto Top;
}



bool findWord = myWord.Contains(searchedWord);

if (findWord)
{
    for (int i = 0; i < myWord.Length; i++)
    {
        if (myWord[i] == searchedWord)
        {
            userWord[i] = searchedWord.ToString();
            count++;
        }
    }
}
else
{
    wrongChar.Add(searchedWord);
    health -= 1;
}
Console.Clear();
Draw();
Console.WriteLine("\n");
for (int i = 0; i < userWord.Length; i++)
{
    Console.Write(userWord[i]);
}
Console.WriteLine("\n");

if (count == myWord.Length)
{
    Console.WriteLine("You are winner.");
    Console.ReadKey();
}

if (health != 0)
{
    goto Top;
}




void Draw()
{


    switch (health)
    {
        case 0:
            Console.WriteLine("______________");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|            O");
            Console.WriteLine("|            |");
            Console.WriteLine("|           /|\\");
            Console.WriteLine("|            |");
            Console.WriteLine("|           / \\");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|________");
            Console.WriteLine("\n");
            Console.WriteLine("GAME OVER \n");
            Console.WriteLine("Correct answer: " + myWord);
            break;
        case 1:
            Console.WriteLine("______________");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|            O");
            Console.WriteLine("|            |");
            Console.WriteLine("|           /|\\");
            Console.WriteLine("|            |");
            Console.WriteLine("|           / ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|________");
            break;
        case 2:
            Console.WriteLine("______________");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|            O");
            Console.WriteLine("|            |");
            Console.WriteLine("|           /|\\");
            Console.WriteLine("|            |");
            Console.WriteLine("|             ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|________");
            break;
        case 3:
            Console.WriteLine("______________");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|            O");
            Console.WriteLine("|            |");
            Console.WriteLine("|           /|");
            Console.WriteLine("|             ");
            Console.WriteLine("|             ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|________");
            break;
        case 4:
            Console.WriteLine("______________");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|            O");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|             ");
            Console.WriteLine("|             ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|________");
            break;
        case 5:
            Console.WriteLine("______________");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|            O");
            Console.WriteLine("|             ");
            Console.WriteLine("|             ");
            Console.WriteLine("|             ");
            Console.WriteLine("|             ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|________");
            break;
        default:
            Console.WriteLine("______________");
            Console.WriteLine("|            |");
            Console.WriteLine("|            |");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|________");
            break;
    }
    Console.Write("\n");
    foreach (var w in wrongChar)
    {
        Console.Write($"[{w}] ");
    }
    Console.Write("\n");
}



bool CheckChar(char word)
{
    var findChar = wrongChar.Where(x => x == word).ToList();
    if (findChar.Count() > 0)
    {
        Console.WriteLine("This char was already used.");
        return true;
    }
    return false;
}