using System;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to enter a 5 digit integer
            Console.WriteLine("Please enter a 5 digit integer?");

            //Storing the number into a variable, Converting that 
            int myNumber = int.Parse(Console.ReadLine());

            //Printing out a line state with the stored number
            Console.Write($"The digits in the number {myNumber} are:  ");

            //Method to seperate the digits and add spaces
            separateDigits(myNumber);

            Console.Write("\n\n");

            //Method created to seperate digits.
            static void separateDigits(int n){

                //if the last digit is less this 10 then the method prints it out
                if(n < 10){
                    Console.Write (n);
                    //this exits the method completely
                    return;
                }
                //This is calling the method again to divide the 5 digit number by 10
                separateDigits(n/10);
                //This line is priting space between the first results because the above line prints
                //the first digit
                Console.Write("  ");
                //I believe this is printing remainder of each digit.
                Console.Write(n % 10);
                //This is putting a space after every digit
                Console.Write(" ");
            }

          
        }
    }
}