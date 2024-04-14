using System.Numerics;

internal class Program
{
    static int[] fields = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    private static void Start(){

    }

    private static void Update(){
        bool hasWon = true;
        DoTurn(1);
        DoTurn(2);
        Console.WriteLine(hasWon);

    }
    private bool lambda1(int x){
        return x != 0;
    }

    private static bool IsDraw()
    {
        if (fields.Any(x => x == 0)){
            //continue game state
            return false;
        } else {
            // Board full
            return true;
        }
    }

    // Returns true if the board is full. If there are still moves to be played, returns false.
    private static bool IsDrawEfficient()
    {
        return !fields.Any(x => x == 0);
    }

    private static bool isEqualTo(int a, int b){
        if (a == b){
            return true;
        }else{
            return false;
        }
    }

    private static bool isEqualToEfficient(int a, int b){
        return a == b;
    }



    private static void DoTurn(int playerNumber){
        string boardTemplate;
        string answer;
        int intAnswer;

        boardTemplate = $@"|{fields[0]}|{fields[1]}|{fields[2]}|
|{fields[3]}|{fields[4]}|{fields[5]}|
|{fields[6]}|{fields[7]}|{fields[8]}|";

        Console.WriteLine(boardTemplate);

        Console.WriteLine($"Player {playerNumber}, Where would you like to place your player (1-9)");
        answer = Console.ReadLine();
        intAnswer = int.Parse(answer);
        // fields[intAnswer] = 1;

        if ( fields[intAnswer] == 0 ){
            fields[intAnswer] = playerNumber;
        }
        if(IsDraw() == true){
            Console.WriteLine("The Game has ended in a draw");
            Console.Read();
            Environment.Exit(0);
        }
        
       // if sign has 2 connection points, in the same direction, display Win screen(gigachad.png) (Math = seeing better)
    }

private static void Gamer()
{
        string boardTemplate;
        string answer;
        int intAnswer;

        boardTemplate = $@"|{fields[0]}|{fields[1]}|{fields[2]}|
|{fields[3]}|{fields[4]}|{fields[5]}|
|{fields[6]}|{fields[7]}|{fields[8]}|";

        Console.WriteLine(boardTemplate);

        Console.WriteLine("Player 1, Where would you like to place your player (1-9)");
        answer = Console.ReadLine();
        intAnswer = int.Parse(answer);
        // fields[intAnswer] = 1;

        if ( fields[intAnswer] == 0 ){
            fields[intAnswer] = 1;
        }


        boardTemplate = $@"|{fields[0]}|{fields[1]}|{fields[2]}|
|{fields[3]}|{fields[4]}|{fields[5]}|
|{fields[6]}|{fields[7]}|{fields[8]}|";
        Console.WriteLine(boardTemplate);
        Console.WriteLine("Player 2, Where would you like to place your player (1-9)");
        answer = Console.ReadLine();
        intAnswer = int.Parse(answer);
        // fields[intAnswer2] = 2;

        if ( fields[intAnswer] == 0 ){
            fields[intAnswer] = 2;}
}
    private static void Main(string[] args)
    {
        Start();
        while ( true )
        {
            Update();
        }
        Console.Read();
    }
}