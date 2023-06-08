using System;

namespace Tasks
{
    class Task1
    {

        // this function will ask the user to enter hours and minutes and  will check if the input is correct
        public static void GetInput()
        {
            // isHoursCorrect and isMinutesCorrect are two boolean variables to check if the input is correct or not.
            Boolean isHoursCorrect = false;
            Boolean isMinutesCorrect = false;
            // hours and minutes are two integer variables to store the input from the user
            int hours = 0;
            int minutes = 0;
            // asking the user to enter hours and minutes and  will check if the input is correct
            Console.WriteLine("Please enter hours of the analogue clock:(0-12) ");
            // this while loop will check if the input is correct or not
            while (!isHoursCorrect)
            {
                // reading the input from the user and verifying if the input is correct or not
                if (int.TryParse(Console.ReadLine(), out hours) && hours >= 0 && hours <= 12)
                {
                    isHoursCorrect = true;
                }
                // if the input is not correct the program will ask the user to enter the input again
                else
                {
                    Console.WriteLine("Please enter correct hours:(0-12) ");
                }
            }
            // asking the user to enter minutes and  will check if the input is correct
            Console.WriteLine("Enter minutes of the analogue clock:(0-60) ");
            while (!isMinutesCorrect)
            {
                // reading the input from the user and verifying if the input is correct or not
                if (int.TryParse(Console.ReadLine(), out minutes) && minutes >= 0 && minutes <= 60)
                {
                    isMinutesCorrect = true;
                }
                else
                {
                    // if the input is not correct the program will ask the user to enter the input again
                    Console.WriteLine("Please enter correct minutes: (0-60) ");
                }
                // printing the angle between hours and minutes arrows using GetAngle() function
                Console.WriteLine("Angle between hours and minutes arrows is: " + GetAngle(hours, minutes));

            }

        }
        // GetAngle() function will calculate the angle between the hour and minute hand
        public static int GetAngle(int hours, int minutes)
        {
            // hourHandAngle is an integer variable to store the angle of the hour hand
            // minuteHandAngle is an integer variable to store the angle of the minute hand
            int hourHandAngle = 30 * hours; // 30 degrees for each hour
            int minuteHandAngle = 6 * minutes; // 6 degrees for each minute
            int angle = Math.Abs(hourHandAngle - minuteHandAngle); // calculating the angle between the hour and minute hand
            return angle;
        }
        static void Main(String[] args)
        {
            // breaking the program into functions.
            // the first function except the main function will be GetInput()
            // GetInput() will ask the user to enter hours and minutes and  will check if the input is correct
            // the second function will be GetAngle() which will calculate the angle between the hour and minute hand

            // invoking the GetInput() function to get the input from the user and calculate the angle
            GetInput();
            // this while loop will ask the user if he wants to calculate the angle at another position or not
            // if the user enters "y" the program will ask the user to enter hours and minutes again.
            while (true)
            {
                // asking the user if he wants to calculate the angle at another position or not
                Console.WriteLine("Do you want to calculate angles of the minute and hour hand at another position? (y/n)");
                // reading the answer from the user
                string answer = Console.ReadLine();
                // if the answer is "y" the program will ask the user to enter hours and minutes again.
                if (answer == "y")
                {
                    // invoking the GetInput() function to get the input from the user and calculate the angle
                    GetInput();
                }
                // if the answer is "n" the program will break the loop and end the program
                else if (answer == "n")
                {
                    break;
                }
                else
                {
                    // if the answer is not "y" or "n" the program will ask the user to enter the answer again
                    Console.WriteLine("Please enter correct answer: (y/n)");
                }
            }

        }



    }

}
