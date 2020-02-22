using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Player
    {
        public string FirstName { get; set; } //first name method
        public string LastName { get; set; } //last name method
        public string Institution { get; set; } //institution method
        public string Position { get; set; } //position method
        public double Salary { get; set; } //salary method
        public bool Availability { get; set; } //Availability method
        public string Best { get; set; } //Best method
                                          //Making a constructor
        public Player(string FirstName, string LastName, string Institution, string Position, double Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Institution = Institution;
            this.Position = Position;
            this.Salary = Salary;
        }

        public void determineBest(int count)
        {
            //Logic
            if (count == 1)
            {
                 Best = "The Best";
            }
            else if (count == 2)
            {
                 Best = "2nd Best";
            }
            else if (count == 3)
            {
                 Best = "3rd Best";
            }
            else if (count == 4)
            {
                 Best = "4th best";
            }
            else if (count == 5)
            {
                 Best = "5th best";
            }
        }
    }
}