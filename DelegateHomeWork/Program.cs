using System;

namespace DelegateHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button
            {
                Length = 15,
                Height = 6,
                Text = "Welcome",
                Exec = new RunAnyPara(Console.WriteLine)
            };

            button.PrintButton();

            button.Exec(2);
            button.Exec("Name");
        }
    }
}
