using System;

interface IPlayer
{
    //Properties
    string Name { get; set; }
    int JerseyNumber { get; set; }

    //Method
    void DisplayPlayerInfo();
}

class SoccerPlayer : IPlayer
{
    //Properties
    public string Name { get; set; }
    public int JerseyNumber { get; set; }
    public string Position { get; set; }

    //parameterized Constructor
    public SoccerPlayer(string name, int jerseyNumber, string position)
    {
        Name = name;
        JerseyNumber = jerseyNumber;
        Position = position;
    }
    //default Constructor
    public SoccerPlayer() { 
        
    }

    //Method to display player info
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Jersey Number: {JerseyNumber}");
        Console.WriteLine($"Position: {Position}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Creating a soccer player object parameterized
        SoccerPlayer player1 = new SoccerPlayer("David Beckham", 7, "Midfielder");
        
        //creating soccer player object default
        SoccerPlayer player2 = new SoccerPlayer();
        player2.Name = "Neymar jr";
        player2.JerseyNumber = 10;
        player2.Position = "LeftMid";


        //Displaying player information
        Console.WriteLine("Player Information:");
        player1.DisplayPlayerInfo();
        Console.WriteLine("");
        Console.WriteLine("Player Information:");
        player2.DisplayPlayerInfo();
    }
}
