Console.WriteLine("Welcome to hangman!");
Console.Write("Choose a difficulty (easy, medium or hard): ");
string? userDifficulty = Console.ReadLine();

if (string.Equals(userDifficulty, "easy", StringComparison.OrdinalIgnoreCase))
{  
    string[] easyWords = {"cat", "dog"};
    string easyWord = easyWords[0];

    string guessedWord = "_ _ _";      
    Console.WriteLine(guessedWord);

    for (int attempts = 0; attempts < 3; attempts++)
    {
        Console.Write("Guess a letter: ");
        string? userGuess = Console.ReadLine();

        if (userGuess.Length == 1 && char.IsLetter(userGuess[0])) 
        {
            if (easyWord.ToLower().Contains(char.ToLower(userGuess[0]))) 
            {
                Console.WriteLine($"{easyWord[0]} _ _");
                Console.WriteLine("Correct guess!");
            }
            else
            {
                Console.WriteLine("Incorrect guess.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid single letter.");
        }

        Console.WriteLine(guessedWord);
    }
} 
else if (string.Equals(userDifficulty, "medium", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("_ _ _ _ _");
    Console.Write("Guess a letter: ");
    string? userGuess = Console.ReadLine();
}
