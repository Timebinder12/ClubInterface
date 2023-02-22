using System;
interface IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
}
class program
{
    class Gaming : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public string Game { get; set; }
        public int Age { get; set; }
        public int YearsActive { get; set; }

        public Gaming()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Game = string.Empty;
            Age = 0;
            YearsActive = 0;
        }
        public Gaming(int id, string firstName, string lastName, string game, int age, int yearsActive)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Game = game;
            Age = age;
            YearsActive = yearsActive;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Game: {Game}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Years Active: {YearsActive}");
        }
    }

    public static void Main(string[] args)
    {
        Gaming game = new Gaming(1,"Fred", "Flintstone","The Flintstones", 41, 6 );
        game.DisplayInfo();
    }
}
