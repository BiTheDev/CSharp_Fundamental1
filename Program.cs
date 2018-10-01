using System;

namespace Fundamental1
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Create a loop that print all values from 1-255
            int val = 1;
            while(val <256){
                System.Console.WriteLine(val);
                val++;
            }

            // Print all values from 1-100 that are divisible by 3 or 5 
            for (int val2 = 1; val2 <= 100; val2++)
            {
                if(val2 % 3 == 0 || val2 % 5 == 0){
                    System.Console.WriteLine(val2);
                }
            }


            //  Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int val2 = 1; val2 <= 100; val2++)
            {
                if(val2 % 3 == 0){
                    System.Console.WriteLine("Fizz");
                }else if(val2 % 5 == 0){
                    System.Console.WriteLine("Buzz");
                }
            }

            // Optional 1
            for (int i = 3; i <= 100; i+=3){
                System.Console.WriteLine(i);
            }
            for (int i =5; i<=100; i+=5 ){
                System.Console.WriteLine(i);
            }
            // Optional 2
            Random rand = new Random();
            
            for (int i = 0; i < 10 ; i ++){
                // int val = rand.Next(1,10);
                if ( val == 1 ){
                    System.Console.WriteLine("one");
                }else if ( val == 2){
                    System.Console.WriteLine("two");
                }else if ( val == 3){
                    System.Console.WriteLine("three");
                }else if ( val == 4){
                    System.Console.WriteLine("four");
                }else if ( val == 5){
                    System.Console.WriteLine("five");
                }else if ( val == 6){
                    System.Console.WriteLine("six");
                }else if ( val == 7){
                    System.Console.WriteLine("seven");
                }else if ( val == 8){
                    System.Console.WriteLine("eight");
                }else if ( val == 9){
                    System.Console.WriteLine("nine");
                }else if ( val == 10){
                    System.Console.WriteLine("ten");
                }
            }

        }
    }
}
