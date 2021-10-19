using System;

namespace CL2_Data_Types_and_Variables_Exercises
{
    class program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTest c# assignments...\n");
            //practiceIntegerNumbers(); //Exercise #1
            //practiceFloatingPointNumbers(); // Exercise #2
            //practiceCharactersAndStrings(); // Exercise #3
            //VariableInHexadecimalFormat(); //Exercise #4
            //booleanVariable(); // Exercise #5
            //stringsAndObjects(); // Exerfise #6
            //exchangeVariableValues(); // Exercise #7
            //employeeData(); //Exercise #8


            
        }

        static void practiceIntegerNumbers()
        {
            sbyte num1 = -100;
            byte num2 = 128;
            short num3 = -3540;
            ushort num4 = 64876;
            uint num5 = 2147483648;
            int num6 = -1141583228;
            long num7 = -1223372036854775808;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }

        static void practiceFloatingPointNumbers()
        {
            double num1 = 3.141592653589793238;
            double num2 = 1.60217657;
            double num3 = 7.8184261974584555216535342341;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }

        static void practiceCharactersAndStrings()
        {
            string word1 = "Software University";
            char letter1 = 'B';
            char letter2 = 'y';
            char letter3 = 'e';
            string word2 = "I love programming";

            Console.WriteLine(word1);
            Console.WriteLine(letter1);
            Console.WriteLine(letter2);
            Console.WriteLine(letter3);
            Console.WriteLine(word2);
        }

        static void VariableInHexadecimalFormat()
        {
            string hexValue;
            Console.WriteLine("Enter hexadecimal number: \n");
            hexValue = (Console.ReadLine());

            int decimalValue = Convert.ToInt32(hexValue, 16);

            Console.WriteLine("Decimal value: " + decimalValue);
        }

        static void booleanVariable()
        {
            Console.WriteLine("Enter a  bool type (True Or False): ");
            string boolType = Console.ReadLine();

            Console.WriteLine("\nInput value: " + boolType);

            bool boolValue = Convert.ToBoolean(boolType);
            Console.Write("\nConverted value: " + boolValue);


            Console.Write("\nIs the converted boolean value is True?\nOutput: ");
            if (boolValue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
        }


        static void stringsAndObjects()
        {
            string myValue1 = "Hello";
            string myValue2 = "World";
            Console.WriteLine("Input Value:" + "\n\n" + myValue1 + "\n" + myValue2);
            object concatenateValue = myValue1 + " " + myValue2;
            string myFinalValue = (string)concatenateValue;

            Console.WriteLine("\nOutput:\n"+ myFinalValue);
        }


        static void exchangeVariableValues()
        {
            int number1, number2, temp;
            Console.WriteLine("Input the number for swap");
            Console.WriteLine("Input the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            number2 = int.Parse(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("Number after swap are: ");
            Console.WriteLine("First number: " + number1);
            Console.WriteLine("Second number: " + number2);
        }

        static void employeeData()
        {
            string firstName, lastName;
            byte age;
            char gender;
            int personalId, uniqueEmployeeNumber;

            Console.WriteLine("Input employee details: \n");
            Console.WriteLine("Enter first name: ");
            firstName = (Console.ReadLine());

            Console.WriteLine("Enter last name: ");
            lastName = (Console.ReadLine());

            Console.WriteLine("Enter Age: ");
            age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gender (M/F: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Personal ID: ");
            personalId = int.Parse(Console.ReadLine());

            Console.WriteLine("Unique Employee Number: ");
            uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name:\t" + firstName);
            Console.WriteLine("Last name:\t" + lastName);
            Console.WriteLine("Age:\t" + age);
            Console.WriteLine("Gender:\t" + gender);
            Console.WriteLine("Personal ID:\t" + personalId);
            Console.WriteLine("Unique Employee Number:\t" + uniqueEmployeeNumber);


        }

    }
    
}
