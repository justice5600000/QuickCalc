using System;

namespace QuickCalc // Note: actual namespace depends on the project name.
{}
    internal class Program
    {
        static void Main(string[] args)
        {
            // start varibules
            string typeAns;
            double ans;
            double num01;
            double num02;
            double num03;
            double num04;
            double num05;
            //console customization
            Console.Title = "QuickCalc";
           
            //commands start
            Console.WriteLine("Type help to see commands");
            Console.WriteLine("Type what type of problem you want to solve: ");
            
            typeAns = Console.ReadLine();

            if(typeAns == "help")
            {
                Console.WriteLine("the commands right now are add,subtract,multiply and divide.");
                Console.WriteLine("Press Any key to close.");
                Console.ReadLine();
            }
            else
            {
               if(typeAns == "add") 
            {
               Console.WriteLine("Select first number: ");
               num01 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select second number: ");
               num02 = Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Select third number: ");
               num03 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select fourth number: ");
               num04 = Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Select fifth number: ");
               num05 = Convert.ToInt32( Console.ReadLine());




               ans = num01 + num02 + num03 + num04 + num05;

               Console.WriteLine("The anwser is " + ans);
            

            }
            else
            {
                
            }


            if(typeAns == "subtract") 
            {
               Console.WriteLine("Select first number: ");
               num01 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select second number: ");
               num02 = Convert.ToInt32( Console.ReadLine());

                 Console.WriteLine("Select third number: ");
               num03 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select fourth number: ");
               num04 = Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Select fifth number: ");
               num05 = Convert.ToInt32( Console.ReadLine());


               ans = num01 - num02 - num03 - num04 - num05;

               Console.WriteLine("The anwser is " + ans);

            }
            else
            {

            }

              if(typeAns == "multiply") 
            {
               Console.WriteLine("Select first number: ");
               num01 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select second number: ");
               num02 = Convert.ToInt32( Console.ReadLine());

                 Console.WriteLine("Select third number: ");
               num03 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select fourth number: ");
               num04 = Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Select fifth number: ");
               num05 = Convert.ToInt32( Console.ReadLine());


               ans = num01 * num02 * num03 * num04 * num05;

               Console.WriteLine("The anwser is " + ans);

            }
            else
            {

            }

              if(typeAns == "divide") 
            {
               Console.WriteLine("Select first number: ");
               num01 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select second number: ");
               num02 = Convert.ToInt32( Console.ReadLine());

                 Console.WriteLine("Select third number: ");
               num03 = Convert.ToInt32( Console.ReadLine());

               Console.WriteLine("Select fourth number: ");
               num04 = Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Select fifth number: ");
               num05 = Convert.ToInt32( Console.ReadLine());


               ans = num01 / num02 / num03 / num04 / num05;

               Console.WriteLine("The anwser is " + ans);

            }
            else
            {

            }

            
            

            
            
            
               


            
            



            
            

            


            // waits for button input to close 
            Console.ReadKey();
        }
    }
}