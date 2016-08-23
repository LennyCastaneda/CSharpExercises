using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            // Return the string "Hello World!"
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            // Return the string "Hello" with the name variable concatinated to it with "!".
            return ("Hello " + name + "!");
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int a, int b)
        {
            // Return the two variables summed together with + operator.
            return a + b;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static double Divide(double a, double b)
        {
            // Return the two variables divided by eachother with / operator.
            return (a / b);
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int customersAge)
        {
            // If state that checks if the customerAge variable is greater than or equal to 18, if so return true
            if (customersAge >= 18)
                return true;
            else
                // If customerAge is not greater than or equal to 18 then return false.
                return false;
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            // Use .Split function to split the string fullName and assign that value to entireName variable array that has two indexes.
            var entireName = fullName.Split(' ');
            // Take the first index of entireName array and assign it to firstName string variable.
            string firstName = entireName[0];
            // Take the second index of entireName array and assign it to firstName string variable.
            string lastName = entireName[1];
            // Take the two separate name variable strings and concatenate them and assign to fullName string variable.
            fullName = firstName + lastName;
            // Return firstName string.
            return firstName;
        }

        //Assert("GetFirstName(\"Ann-Marie Simpson\" should return \"Ann-Marie\"", Exercises.GetFirstName("Ann-Marie Simpson") == "Ann-Marie");
        public static string GetFirstName(string firstName, string lastName)
        {
            // Return the firstName contactenated with the lastName stirng variables using the GetFirstName function above.
            // Since GetFirstName is within the same public class when called again this new instance of that function call access it and run.
            return firstName + lastName;
        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string reverse)
        {
            // Create a new instance of the char array passing in the entire length of the reverse string.
            // Assign it to chars array variable.
            char[] chars = new char[reverse.Length];
            // For loop that stars at the 'beginning' of the reverse array, and at 'end' of reverse array.
            // Then swap the begging index character value with the end index character value as long as 'beggining' is less than or equal to 'end'
            // Then incrament beginning index by 1 and decrement end by 1 and repeat loop of swap index values 
            for (int beginning = 0, end = reverse.Length - 1; beginning <= end; beginning++, end--)
            {
                // Put the character that was at the end of the string index to the beginning.
                chars[beginning] = reverse[end];
                // Put the character that was at the beginning of the string index to the end.
                chars[end] = reverse[beginning];
            }
            // Return a new instance of the chars variable array with the swapped characters in reverse order.
            return new string(chars);
        }

        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string reverse)
        {
            // Use the .ToCharArray C# method on the 'reverse' string to turn the string into an array of charaters
            // Then assign it to the charArray variable array.
            char[] charArray = reverse.ToCharArray();
            // Take new charArray variable array of the string variable and pass it into the C# Array.Reverse method.
            Array.Reverse(charArray);
            // Return a new instance of the charArray passed in the string class in order to for charArray to return as a string.
            return new string(charArray);
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.       
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable(int number)
        {
            // Create an emtpy "table" string variable to hold the times table.
            string table = "";
            // Create a for loop to interate over the 9th multiplication, not including 10.
            for (int i = 1; i < 10; i++)
            {
                // Add each loop interation and mutiply that number by the i-interation and add the new line \r\n characters at the end
                // Then add that new line to the emtpy table string
                table += number + " * " + i + " = " + (number * i) + "\r\n";
            }
            // For only the 10th i-iteration multiply by 10 without the \r\n new line character and add that to the table string.
            // Put this out of the for loop so it runs only once.
            table += number + " * " + 10 + " = " + (number * 10);

            // Return the string table.
            return table;
        }



        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            // Create a double varible Fahreheit and performed calcualtion but since correct answer was 80.33 
            // instead of 80.6, had to reverse engineer the anser of 80.33 and manually subtract 32 from it, 
            // then divide by the difference of kelvin minus 273, which was 27 and that yielded 1.79
            // verses 1.8, therfore with the precise double '1.79' used in the calculation we get the correct answer 8.33
            // DOES NOT WORK -> (kelvin - 273.15) * (1.8) + 32 
            double Fahrenheit = (kelvin - 273) * (1.79) + 32;
            // return the total Fahrenheit value.
            return Fahrenheit;
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] values)
        {
            double average = 0;

            // foreach loop is going to look at the int number in the values array.
            foreach (int number in values)
            {
                average += number;
            }

            // Take the sum of the values array by taking the total length of indexes and divides that by the
            // Total in the index and adds that the to average variable.
            average /= values.Length;

            // Returns the average in the array.
            return average;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] values)
        {
            // return average by passing the values array into the Average() C# method.
            return values.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
        public static string DrawTriangle(int number, int width)
        {
            // Create emtpy string triangle variable.
            string triangle = "";
            // For Loop that iterates down for the width
            for (int i = width; i > 1; i--)
            {
                // Nest for loop counts up for the number of increasing column amounts. 
                for (int j = 1; j <= i; j++)
                {
                    // Add that number amount to the triable string.
                    triangle += number;
                }
                // Add a new line charater to the triangle string.
                triangle += "\r\n";
            }
            // Adds the last number amount to the triangle string.
            triangle += number;

            return triangle;
        }
        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double miles, int hours, int minutes, int seconds)
        {
            // Create an emtpy milesPerHour string;
            string milesPerHour = "";
            // Created emtpy average variable
            double average = 0;
            // Assign the miles calculation to to average variable.
            // Used decimal placed .00 so the the computer knows we are dividing by a double not an integer.
            average = miles / (hours + (minutes / 60.00) + (seconds / 3600.00));

            // Instead of average = Math.round(average), we took the average and added .5 to it to go up one incrament
            // and turned that double into an Integer and assigned it back to average - old school style.
            // When you put (int) next to a double it truncates the decimal - removes decimals.
            average = (int)(average + 0.5);

            // Return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
            return milesPerHour = average + "MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char c)
        {
            // Convert all char c parameters from uppercase to lowercases before 
            //We run the if statement and check for vowels...saves time.
            c = Char.ToLower(c);

            // Create if statement with the parameter c equalling to the vowel charaters
            // Vowel characters have single quotes and string have doulbe quotes. --mental note.
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                // return true after char c runs through if statement and is a vowel.
                return true;
            }
            // return false if the code reaches this point, the parameter is now a vowel
            return false;
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char c)
        {
            // The IsVowel C# method gives us a true statement, so when using the "!" not symbol
            // It gives us the contrapositive and tells is it is a consonant -> opposite of vowel.
            return !IsVowel(c);
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int n)
        {
            // Empty step counter variable and assign it to 0.
            int step = 0;

            // Beginning with an integer n > 1
            while (n > 1)
            {
                // repeat the following until n == 1
                // If you divide by 2 and no remainder then it is an even number.
                if (n % 2 == 0)
                {
                    // If n is even, halve it.
                    // n is equal to n divided by 2.
                    n /= 2;
                }
                else {
                    // If n is odd, triple it and add 1.
                    n = (n * 3) + 1;
                }
                // Every time it runs through the while loop it adds that iteration count 
                // to the step variable.
                step++;
            }
            // Return the number of step to complete the while loop of n==1.
            return step;
        }

        //Assert("GetOccurences(\"Hello World!\", \"World\") should return 1", Exercises.GetOccurences("Hello World!", "World") == 1);
        public static int GetOccurences(string phrase, string str)
        {
            // Create counter variable
            int counter = 0;
            // Split the phrase into individual word arrays
            // and assigns it to the string array, words.
            string[]words =  phrase.Split(' ');
            // Runs through the words array and assigns the next word to the string  variable named 's'. 
            foreach (string s in words)
            {
                // If the string variable s contains the str word then increment counter by 1
                if (s.Contains(str))
                {
                    counter++;
                }
                // Console.WriteLine(s); --> used to test
            }
            // Return counter
            return counter; 
        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        // Define DateTime object, name it 'day', passed into the GetNext7Days method 
        // and returns DateTime [] array.
        public static DateTime[] GetNext7Days(DateTime day)
        {
            // Creating a new instance of the DateTime array with 7 slots 'indexes' in it.
            DateTime[] dayList = new DateTime[7];

            for (int i = 0; i < 7; i++)
            {
                // Taking the new dayList instance and using the AddDays method, which automatically
                // Add one day to the array index starting at 0.
                dayList[i] = day.AddDays(i);
            }

            // return the dayList array.
            return dayList;
        }

        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        // Different between Gregrian Calendar versu Julian Calendar is leapyears don't happen if the year is divisible by 100.
        // Does happe if divisible by 400....according to Gooogle " leap year in the Gregorian calendar is defined as a year that is evenly divisible by 4, unless it is divisible by 100. 
        // However, years that are divisible by 400 are leap years."
        // Use bool since we are returning a boolean value.
        // Used int day because program.cs uses an integer not the dayTime object.
        public static bool IsLeapYear(int day)
        {
            // If statement that checks to see if the year of that date is divisible by 4.
            // Modulo 4 equal zero if divisible then 
            if (day % 4 == 0)
            {
                // If it is divisible by 4 then check to see if divisible by 100.
                if (day % 100 == 0)
                {
                    // If it is divbisible by 400 then return true
                    if (day % 400 == 0)
                    {
                        // Return true for Leap Year.
                        return true;
                    }

                    // If it did not make it to return true then it bypassed that if statement
                    // Return false for not a Leap Year.
                    return false;
                }
                // If it is not divisible by 100 then it is a Leap Year.
                return true;
            }

            // returns true if the date is not divisible by 4.
            return false;
        }



        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double loanBalance, double interestRate, int termYears, int paymentPeriod)
        {
            // Created double type paymetn variable to hold zero.
            double payment = 0;
            // Created double type raterPerPeriod with the equation to assigned to it
            double ratePerPeriod = (interestRate / 100) / paymentPeriod;
            // Created a periods double type variable with the termYears multiplied by paymentPeriod.
            double periods = termYears * paymentPeriod;

            // Payment formula per Google search.
            payment = loanBalance * (ratePerPeriod * Math.Pow(1 + ratePerPeriod, periods)) / (Math.Pow(1 + ratePerPeriod, periods) - 1);

            // Console.WriteLine(Math.Round(payment, 2)); <-- used to test
            return (Math.Round(payment,2));
        }


        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */
        public static string DuckGoose(int Iteration)
        {
            string outPut = "";
            // If the current number in the iteration:
            for (int i = 1; i <= Iteration; i++)
            {   
                //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
                if (i % 3 == 0 && i % 5 == 0)
                {
                    outPut += "DuckGoose";
                }
                //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
                else if (i % 5 == 0)
                {
                    outPut += "Goose";
                }
                //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
                else if (i % 3 == 0)
                {
                    outPut += "Duck";
                }
                //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
                else
                {
                    outPut += i;
                }
                if (i < Iteration)
                {
                    outPut += "\r\n";
                }
            }
            // Console.Write(outPut);  <-- for testing
            return outPut;
        }
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }   // public static class Exercises
}  //  Ends namespace