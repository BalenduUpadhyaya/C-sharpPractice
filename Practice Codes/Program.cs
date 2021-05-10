using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Codes
{
    // yeh ak class banyi hamne 2 attributes ke sath
    
    class Player
    {
        //public string name = Console.ReadLine();
        //public int health = Convert.ToInt32(Console.ReadLine());
        //public void age(int a)
        //{
        //   int g = a;
        //    Console.WriteLine("age is " + g);
        //}

        //// get set method usage
        //public int gethealth()
        //{
        //    return health;
        //}
        //public void sethealth(int h)
        //{
        //    health = h;
        //}
    }
    
    
    class Program
    {
        //This is a function or Method


        //static void greet()          //Void ka matlb ki kuch return ni kr rha hai Jis trike ki value return kreneg vo rikhenge static ke agge
        //{
        //    Console.WriteLine("HI");
        //}


        //static int average(int a , int b , int c )
        //{
        //    int sum = a + b + c;
        //    return sum;
        //}
        static void Main(string[] args)
        {
            //int balendu = 10; //integer Variable 
            /* 
             DataTypes in c#
            Integer- int harry; --> 4 bytes
            Long --> long harry; 8 Bytes bde integer ko store krta hai  
            Double-double harry; --> 8 bytes
            Floating point number-float that; --> 4 bytes
            Character - char a='A'; --> 2 Bytes
            Boolean- bool isGreat=true; --> 1 bit
            string-string inp="harry"; --> 2 bytes per character

             */
            //DataTypes Examples
            //int a = 1;
            //float b = 24.4F;
            //double c = 34.4D;
            //bool isGreat = true;
            //char d = 'A';
            //string e = "This is a String";

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(d);
            //Console.WriteLine(e);

            //string inp = Console.ReadLine();

            //Console.WriteLine("Hello World"); 
            //Console.WriteLine("I love C# " + balendu);
            //Console.WriteLine(inp);
            //Console.ReadLine();

            //type Casting
            // There are two types of type Casting
            // Implicit TypeCasting and Explicit Typecasting
            //Implicit casting -->
            // char  to int to long to float to double     ( Char ka promotion apne agge valo mai ho jyega )
            //int q = (int) 113.5;
            //Console.WriteLine(q);

            //int x = 3;
            //double y = x; // int ka promotion ho gya double mai 
            //int z = 'y';
            //Console.WriteLine(z);
            //double f = 3.5;
            //Console.WriteLine(f);
            //float var = Convert.ToInt32(35.5);
            //double variable = var;
            //Console.WriteLine(variable);

            //Console.WriteLine("Hey Enter Your Name ");
            //string abc = Console.ReadLine();
            //Console.WriteLine("Hello Welcome " + abc);


            //Operators in C#

            /* ArithmeticException Operators
             1. Arithmetic Operators 
             2 . Assignment Operators
             3. Logical operator &&--> This is and operator || --> This is or operator  !--> Not Operator
             4. Comparison Operator
             5.
            */

            //int qw = Convert.ToInt32(Console.ReadLine());  // This the way to take integer input --We can simply take a string as a input with console read line
            //Console.WriteLine(qw);


            // There is also a math function ..
            //System.Math.

            //String 
            //string hello = "Hello this is balendu";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.ReadLine();
            //Console.WriteLine(string.Concat(hello, "Hi this is papa"));


            //string name = Console.ReadLine();
            ////String petName = Console.ReadLine();
            ////int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($" Your name is {name}"); // + lga lga ke kitne add krenge sentence mai
            //Console.ReadLine();

            //string hello = "Hello My name is Balendu";
            //Console.WriteLine(hello[0]); //string Indexing
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(5)); //5 index se dega puri string output mai

            //string hi = "Hello i am from \" ghaziabad"; // agar bich mai koi bhi quotes ya kuch dalna hai toh ak backslash ka use ho jyega or new line ka lia \n
            //Console.WriteLine(hi);

            //---------------------If Else Else if ---------------------------->> If else ladder

            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a > 18)
            //{
            //    Console.WriteLine("Above 18");
            //}
            //else
            //{
            //    Console.WriteLine("No u cant drive");
            //}


            //----------Switch-------------//

            //int age =Convert.ToInt32(Console.ReadLine());

            //switch(age)
            //{
            //    case 1:
            //        Console.WriteLine("Hi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy");
            //            break;

            //}
            //Console.ReadLine();

            //--------------Loops in C Sharp--------------->>

            //1- While Loop

            //int i = 0;
            //while(i<5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();

            //2. Do while lopp isme kis hota hai ki ab toh chlta hi hai function 
            //int a = 0;
            //do
            //{
            //    Console.WriteLine(a + 1);
            //    a++;
            //} while (a > 5);
            //Console.ReadLine();

            //3. For Loop

            //for(int a=0; a<5; a++)
            //{
            //    Console.WriteLine(a + 1);
            //    break;
            //}
            //Console.ReadLine();

            //Methods or Function



            // gm("Abhishek");
            //Console.WriteLine(average(1, 2, 3));

            //OOps -Classes and Objects
            //Yeh hamne player class ki ak object banyi abhishek name se
            
            
            //Player abhishek = new Player();
            //Console.WriteLine(abhishek.name);
            //Console.WriteLine(abhishek.gethealth());
            //abhishek.sethealth(15);
            //Console.WriteLine(abhishek.gethealth());
            //abhishek.age(100);
            //Console.ReadLine();













        }
    }
}
