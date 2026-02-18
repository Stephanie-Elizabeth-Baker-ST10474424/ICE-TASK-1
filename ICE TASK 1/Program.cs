using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//refrence:Gemini
//ST10474424 Steph
namespace ICE_TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's name: "); //prompts the user to enter the name

           //---------------------------------------- start of setup and input  ----------------------------------------//

            var StudentName = Console.ReadLine();
            
            
            var scores = new int[3]; //creates an array list  that has excatly 3 slots (for the 3 scores the user enters)
            int total = 0; //collects all the scores to store later (this is later used in the calculation of the averages)
            //---------------------------------------- end of setup and input  ----------------------------------------//


            //---------------------------------------- start of the input loop ----------------------------------------//
            for (var i = 0; i < 3; i++)
            {
                Console.Write("Enter score (out of 100) " + (i + 1) + ": "); // i starts at 0 and counts up to 2 (zero based lang so it starts counting from 0)

                var input = Console.ReadLine(); //saves whatever the user typed and saves it as text
                var currentScore = int.Parse(input); //takes the user input and turns it into a number (for calculation purposes in this sceaniro)

                scores[i] = currentScore; //saves the number into the array at the postition of i. (ensures that all 3 scores is remebered)

                total = total + currentScore; //updates the running total by adding the newest score to what was already there
            }
            //---------------------------------------- end of the input loop ----------------------------------------//

            //---------------------------------------- start of calculations and logic  ----------------------------------------//

            var average = Math.Round(total / 3.0, 2); // .0 is used to ensure we get a double decimal (without it it would be rounded to a whole number) (2 ensures it doesnt go past 2 decimal places).
                    

            var finalLetterGrade = "C"; //fall back on letter grade and to ref to later (aka default)


            //-------- Start of declaring average letter grade --------//
            if (average >= 90)
            { finalLetterGrade = "A"; } //starts at A
            else  if (average >= 80)
            { finalLetterGrade = "B"; }
            else if (average >= 70)
            { finalLetterGrade = "C"; }

            else if (average >= 60)
            { finalLetterGrade = "D"; }

            else
            {
                finalLetterGrade = "F"; //anything less than 60 will be F
            }
            //---------------------------------------- end of calculations and logic  ----------------------------------------//


            //---------------------------------------- start of displaying results  ----------------------------------------//

            //-------- End of declaring average letter grade -------//
            Console.WriteLine("** Student Grade Calculator **");
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("Scores: " + scores[0] + ", " + scores[1] + ", " + scores[2] +
                "%"); //shows what the user has entered 

            Console.WriteLine("Average Score: " + average.ToString("0.00") + "%"); //"0.00" ensures that two deciaml places is enforced/shown
            Console.WriteLine("Final Grade: "  + finalLetterGrade);

            Console.ReadKey();   //waits for you to press a key
            //---------------------------------------- end of displaying results  ----------------------------------------//

        }
    }
}
