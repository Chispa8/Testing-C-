// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace MiPrimerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please, enter the student grade:");
            string entryValue = Console.ReadLine();
            bool isNumber = int.TryParse(entryValue, out int qualification);

            if (isNumber && qualification >= 0 && qualification <= 100)
            {

                char finalQualification;
                switch (qualification)
                {

                    case int n when (n >= 90):
                        finalQualification = 'A';
                        break;
                    case int n when (n >= 80):
                        finalQualification = 'B';
                        break;
                    case int n when (n >= 70):
                        finalQualification = 'C';
                        break;
                    case int n when (n >= 60):
                        finalQualification = 'D';
                        break;
                    default:
                        finalQualification = 'F';
                        break;
                }
                Console.WriteLine($"The final grade is: {finalQualification}");

                var messages = new List<string> {

                    "Grade of 90-100: Excellent",
                    "Grade of 80-89: Very good",
                    "Grade of 70-79: Good",
                    "Grade of 60-69: Passed",
                    "Grade of 0-59: Not passed"
                };

                string finalMessage;
                if (qualification >= 90)
                {  // Compare the original integer grade

                    finalMessage = messages[0];
                }
                else if (qualification >= 80)
                {

                    finalMessage = messages[1];
                }
                else if (qualification >= 70)
                {

                    finalMessage = messages[2];
                }
                else if (qualification >= 60)
                {

                    finalMessage = messages[3];
                }
                else
                {
                    finalMessage = messages[4];
                }

                Console.WriteLine(finalMessage);
            }
            else
            {

                Console.WriteLine("The entry is not a valid number. Please, enter a number between 0 and 100.");
            }
        }
    }
}
