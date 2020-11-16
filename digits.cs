/*This program calculates how many numbers of 1, 2, 3 or more 
digits are entered by the user until they type "end" */
using System;
class digits
{
    static void Main()
    {
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreDigits = 0;
        Console.Write("Insert a number: ");
        string userInput = Console.ReadLine();
        while(userInput != "end")
        {
            int input = Convert.ToInt32(userInput);
            if(input != 0)
            {
                if(input / 10 == 0)
                    oneDigit ++;  
                else if (input / 100 == 0)
                    twoDigits ++;  
                else if (input / 1000 == 0)
                    threeDigits ++;  
                else
                    moreDigits ++;  
            }
            userInput = Console.ReadLine();
        }
        
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits, threeDigits, moreDigits); 
    }
}

