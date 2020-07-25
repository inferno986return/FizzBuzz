﻿/* FizzBuzz.cs - Assessment for Programming 1 (Part 1) by Hal Motley (Student No. 100230113)
 * 
 * Task: To create a program called FizzBuzz which is split into AT LEAST 3 methods:
 * 
 * IsFizz - Used to detect whether a number is divisible by 9 for a given input using modulo. If it is divisible by 9 with no remainder then turn
 *          the IsFizz boolean flag to true.
 * 
 * IsBuzz - Works similarly but for 13 and sets the flag IsBuzz to true if there is no remainder after the modulo operation.
 * 
 * IsFizzBuzz - Combines Fizz and Buzz together by checking if the number is divisible by both 9 AND 13.
 * 
 * IsPrime - Used to detect if the input is prime or not.
 * 
 */

using System;


public class FizzBuzz
{
    int input; //Used to store the input which all the calculations are based on.
    int countFizz; //These "vampiric variables" count all the Fizzs, Buzzs, FizzBuzzs and Primes respectively.
    int countBuzz;
    int countFizzBuzz;
    int countPrime;

    public int NumGenerate() //Used to generate the input.
    {

        Random rndm = new Random(); //Used to intialise the pseudorandom number generator (PRNG) to control input.
        int rndmoutput = rndm.Next(1, 11); //Used to store the output of the PRNG and declare what needs to be generated (1-10).
        input = rndmoutput;
        return input;

    }

    public bool IsFizz(int input)
    {
        int fizzoutput;

        fizzoutput = (input % 9);

        if (fizzoutput == 0)
        {
            Console.WriteLine(input + " is fizz.");
            return true;
        }
        else
        {
            Console.WriteLine(input + " isn't fizz.");
            return false;
        }
    }

    public bool IsBuzz(int input)
    {
        int buzzoutput;

        buzzoutput = (input % 13);

        if (buzzoutput == 0)
        {
            Console.WriteLine(input + " is buzz.");
            return true;
        }
        else
        {
            Console.WriteLine(input + " isn't buzz.");
            return false;
        }
    }

    public bool IsFizzBuzz(int input)
    {
        if (IsFizz(input) == true && IsBuzz(input) == true)
        {
            Console.WriteLine(input + " is FizzBuzz.");
            return true;
        }
        else
        {
            Console.WriteLine(input + " isn't FizzBuzz.");
            return false;
        }
    }

    public bool IsPrime(int input)
    {
        if (input == 2)
        { //Since 2 is the only even prime number in existence, best to single it out first.
            Console.WriteLine(input + " is prime.");
            return true;
        }
        else if (input == 0 ^ input == 1)
        { //Since both 0 and 1 aren't prime, it's a good idea to single them out using XOR.
            Console.WriteLine(input + " isn't prime.");
            return false;
        }
        else if (input % 2 == 0)
        { //Checks that the input is even by dividing it by 2. All even numbers (except 2) aren't prime.
            Console.WriteLine(input + " isn't prime.");
            return false;
        }
        else if (input == 3 && input == 5 && input == 7 && input == 11)
        { //Checks the input matches the times table numbers which infact are prime.
            Console.WriteLine(input + " is prime.");
            return true;
        }
        else if (input % 3 >= 1 && input % 5 >= 1 && input % 7 >= 1 && input % 9 >= 1 && input % 11 >= 1)
        { //Checks the input against the 3, 5, 7, 9 and 11 times tables. If the result of the modulo is greater than/equal to 1 it's prime.
            Console.WriteLine(input + " is prime.");
            return true;
        }
        else
        {
            Console.WriteLine(input + " isn't prime."); //My If statements should pick them up by now.
            return false;
        }
    }

    public void BeginTesting() //Used to set all the counting variables to 0 and commence testing of the program.
    {
        countFizz = 0;
        countBuzz = 0;
        countFizzBuzz = 0;
        countPrime = 0;
    }

    /*public int TotalFizz() //Used to find the total of the numbers checked that returned Fizz.
    {

    }

    public int TotalBuzz()
    {
    }

    public int TotalFizzBuzz()
    {
    }

    public int TotalPrime()
    {

    }*/



    public void Program()
    {
        NumGenerate();
        IsFizz(input);
        IsBuzz(input);
        IsFizzBuzz(input);
        IsPrime(input);


    }

    public static void Main()
    {
        FizzBuzz vari; //The best variable name I could think up at the time of coding.
        vari = new FizzBuzz();
        vari.Program();
    }

}

