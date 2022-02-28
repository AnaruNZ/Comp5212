using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Functions group lines of code and makes it reusesable
            // Functions inside classes are called methods
            // Methods can be declared inside a class, struct or an interface
            // Declaration syntax
            // access modifier, return type, function name ( parameters)


            //**Examples****

            // void Menu1()
            //{
            //   Console.WriteLine("Here is my menu");
            //}

            //int AddOne(int num = 0)
            //{
            //    return num++;
            //}

            //** Function Calls **
            //Menu1();
            //Console.WriteLine(AddOne(6));

            //**Function calls with named parameters**

            //void PrintTwoStrings(string firstString, string secondString)
            //{
            //    Console.WriteLine($"First String: {firstString} \n Second String: {secondString}");
            //}

            //string str1 = " Here is the first string";
            //string str2 = "Here is the second string";

            //PrintTwoStrings(str1, str2);

            //PrintTwoStrings(str2, str1);

            //PrintTwoStrings(secondString: "The first string", firstString: " The second one");

            // Return two values from a function using out



            //void AddMultiple(int num1, int num2, out int sum, out int product)
            //{
            //    sum = num1 + num2;
            //    product = num1 * num2;
            //}

            //// Funct
            //int a, b;
            //AddMultiple(4, 5, out a, out b);


            //Console.WriteLine($"sum:{a} product:{b}");







            // Returning multiple values using a tuple
            //** Declaring a Tuple
            //(int a, int b) tup1 = (7, 89);
            //var tup2 = ("Some text", 3.2f);
            //

            //** Using a helper method
            var student1 = Tuple.Create(1, "Bobby", "Charlton");
            var student2 = new Tuple<int, string, string>(2, "Stanley", "Matthews");

            Console.WriteLine($"{student1.Item1}: {student1.Item2} {student1.Item3}");
            Console.WriteLine($"{student2.Item1}: {student2.Item2} {student2.Item3}");
            //first is named elements reference by tup1.a
            // second is unamed referenced by tup2.Item1

            //(int x, string y) tuple3 = (54, "hello");

            //var tuple4 = (67, "hello from tuple4");

            //Console.WriteLine($"tuple3 looks like ( {tuple3.x}, {tuple3.y})");
            //Console.WriteLine($"tuple4 looks like ( {tuple4.Item1}, {tuple4.Item2})");

            ////Tuple function def
            //(int, int) AddMultiply(int c, int d) { return (c + d, c * d); }

            ////Function call
            //(int, int) myResults = AddMultiply(4, 5);

            //.WriteLine($" myResults = ( {myResults.Item1} , {myResults.Item2})");

            //Write a function that returns a tuple and  simulates the roll of three dice. Print the result to screen. 

            //Random dice1 = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"Throw {i}: {dice1.Next(1, 7)}");
            //}



            //***My 3 dice Roll**
            //(int, int, int) threeDice()
            //{
            //    Random rnd = new Random();
            //    return (rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7));
            //}

            //(int, int, int) myDiceRoll = threeDice();

            //Console.WriteLine($"You rolled: {myDiceRoll.Item1}, {myDiceRoll.Item2}, {myDiceRoll.Item3}");

            //(int, int, int) myRoll;

            //(int, int, int) Roll3Dice {

            //    int a, b, c;

            //    

            //    return (a, b, c);
            //}


            //(int id, string fname, string lastname) myStudent = (1, "Andrew", "Chapman");
            //Console.WriteLine($"{myStudent.id} : {myStudent.fname} {myStudent.lastname}");

            //(int, string, string) myOtherStudent = (2, "Jimi", "Hendrix");
            //Console.WriteLine( $"{myOtherStudent.Item1}: {myOtherStudent.Item2} {myOtherStudent.Item3}");

            //var myLastStudent = (3, "Apirana", "Ngatai");

            //Console.WriteLine($"{myLastStudent.Item1}: {myLastStudent.Item2} {myLastStudent.Item3}");

            //** Array of Tuples
            //Console.WriteLine("\n \n Here is an array of tuples \n \n ");
            //var tupleArray = new (int, string, string)[] {
            //   (3, "Hone", "Heki" ),
            //   (4, "Rua", "Kenena"),
            //   (5, "Whina", "Cooper")

            //};

            //foreach ((int, string, string) person in tupleArray)
            //{
            //    Console.WriteLine($"{person.Item1} : {person.Item2} {person.Item3}");
            //}

            Console.ReadKey();


        }


}
}
