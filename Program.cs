using System;

namespace girl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            // Console.WriteLine("Enter your number");
            // int firstNumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter second number");
            // int secondNumber = int.Parse(Console.ReadLine());
            // int greaterNumber = firstNumber;
            // if(secondNumber > firstNumber)
            // {
            //     greaterNumber = secondNumber;
            // }
            // Console.WriteLine($"The greater number is: {greaterNumber}");

            // Console.WriteLine("Enter your number");
            // int firstNumber = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter second number");
            // int secondNumber = int.Parse(Console.ReadLine());
            
            // if(secondNumber > firstNumber)
            // {
            //     Console.WriteLine($"The greater number is: {secondNumber} "); 
            // }
                        
                // Console.WriteLine("Input number");
                // int numOne = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Input number");
                // int numTwo = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Input number");
                // int numThree = Convert.ToInt32(Console.ReadLine());
                // if(numOne > numTwo && numOne > numThree)
                // {
                //     Console.WriteLine(numOne);
                // }
                // else if(numTwo > numOne && numTwo > numThree)
                // {
                //     Console.WriteLine(numTwo);
                // }
                // else if(numThree >  numOne && numThree > numTwo)
                // {
                //     Console.WriteLine(numThree);
                // }
                // else
                // {
                //     Console.WriteLine("they are equal");
                // }
                        question3
            //     Console.WriteLine("Input number");
            //     int numOne = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Input number");
            //     int numTwo = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Input number");
            //     int numThree = Convert.ToInt32(Console.ReadLine());
                
            //     if(numOne == numTwo && numOne == numThree)
            //     {
            //         Console.WriteLine("They all are equal");
            //     }
            //     else
            //     {
            //         if(numOne > numTwo && numOne > numThree)
            //         {
            //             Console.WriteLine($"The greatest number is: {numOne}");
            //         }
            //         else
            //         {
            //             if(numTwo > numOne && numTwo >numThree)
            //             {
            //                 Console.WriteLine($"The greatest number is: {numTwo}");
            //             }
            //             else
            //             {
            //                 if(numThree > numTwo && numThree > numOne)
            //                 {
            //                    Console.WriteLine($"The biggest number is {numThree}");
            //                 }
            //                 else
            // }                {

            //                  }
                               
            //     Console.WriteLine("Input number");
            //     int numOne = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Input second number");
            //     int numTwo = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Input third number");
            //     int numThree = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Input fourth number");
            //     int numFour = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Input fifth number");
            //     int numFive = Convert.ToInt32(Console.ReadLine());

            //     if(numOne == numTwo && numTwo == numThree && numThree == numFour && numFour == numFive)
            //     {
            //         Console.WriteLine("They are all equal");
            //     }
            //    else
            //     {
            //         if(numOne > numTwo && numOne > numThree && numOne > numFour && numOne > numFive)
            //         {
            //             Console.WriteLine($"The greatest is: {numOne}");
            //         }
            //         else
            //         {
            //             if(numTwo > numOne && numTwo > numThree && numTwo > numFour && numTwo > numFive)
            //             {
            //                Console.WriteLine($"The greatest is: {numTwo}"); 
            //             }
            //             else
            //             {
            //                if(numThree > numOne && numThree > numTwo && numThree > numFour && numThree > numFive)
            //                {
            //                     Console.WriteLine($"The greatest is: {numThree}");
            //                }
            //                else
            //                {
            //                 if(numFour > numOne && numFour > numTwo && numFour > numThree && numFour > numFive)
            //                 {
            //                     Console.WriteLine($"The greatest is: {numFour}");
            //                 }
            //                 else
            //                 {
            //                     if(numFive > numOne && numFive > numTwo && numFive > numThree && numFive > numFour)
            //                     {
            //                          Console.WriteLine($"The greatest is: {numFive}");
            //                     }
            //                 }
                          
                           
                           
                         
            //             }  
            //         }
            //     }
                        
            // }
                     question10   
                // Console.WriteLine("Enter your score");
                // int score = int.Parse(Console.ReadLine());

                // if(score <= 3 && score >= 1 )
                // {
                //     int a = score * 10;
                //     Console.Write(a);
                // }
                // else if( score <= 6 && score >= 4 )
                // {
                //     int b = score * 100;
                //     Console.Write(b);
                // }
                // else if(score <= 9 && score >=7)
                // {
                //     int c = score * 1000;
                //     Console.Write(c);
                // }
                // else if(score <= 0  || score >= 9)
                // {
                //     Console.Write("Error");
                // }
                        question1
                Console.WriteLine("Enter the number");
                int number = int.Parse(Console.ReadLine());
                int Hundred=(number/100)*100;
                int tense=((number/10)%10)*10;
                int unit=(number%10);
                string words="";
               switch(number)
                {
                     case 0:
                     words +="Zero";
                     break;
                     case 11:
                     words +="Eleven";
                     break;
                     case 12:
                     words +="Twelve";
                     break;
                     case 13:
                     words +="Thirteen";
                     break;
                     case 14:
                     words +="Fourtheen";
                     break;
                     case 15:
                     words +="Fifteen";
                     break;
                     case 16:
                     words +="Sixteen";
                     break;
                     case 17:
                     words +="Seventeen";
                     break;
                     case 18:
                     words +="Eighteen";
                     break;
                     case 19:
                     words +="Nineteen";
                     break;

                     default:

                    switch (Hundred)
                    {
                        case 100:
                    words+="One Hundred";
                    break;
                    case 200:
                    words+="Two Hundred";
                    break;
                    case 300:
                    words+="Three Hundred";
                    break;
                    case 400:
                    words+="Four Hundred";
                    break;
                    case 500:
                    words+="Five Hundred";
                    break;
                    case 600:
                    words+="Six Hundred";
                    break;
                    case 700:
                    words+="Seven Hundred ";
                    break;
                    case 800:
                    words="Eight Hundred ";
                    break;
                    case 900:
                    words+="Nine Hundred ";
                    break;
                    }
                    
                    if(words.Length!=0 && tense !=0){
                        words+="  and ";
                    }
                  
                 
                

                  switch(tense)
                  {
                    case 20:
                    words+="Twenty ";
                    break;
                    case 30:
                    words+="Thirty ";
                    break;
                    case 40:
                    words+="Fourty ";
                    break;
                    case 50:
                    words+="Fifty ";
                    break;
                    case 60:
                    words+="Sixty ";
                    break;
                    case 70:
                    words+="Seventy ";
                    break;
                    case 80:
                    words+="Eighty ";
                     break;
                    case 90:
                    words="Ninety ";
                    break;
             }
                    switch(unit)
               {
                    
                     case 1:
                     words+="One ";
                     break;
                     case 2:
                     words+="Two ";
                     break;
                     case 3:
                    words+="Three ";
                    break;
                    case 4:
                    words+="Four ";
                    break;
                    case 5:
                    words+="Five ";
                    break;
                    case 6:
                    words+="Six ";
                    break;
                    case 7:
                    words+="Seven ";
                    break;
                    case 8:
                    words+="Eight ";
                    break;
                    case 9:
                    words+="Nine ";
                    break;
                }  
                break;

            }
            Console.WriteLine(words);
                

        }      

    }
}          
                        
        
           

    
                  
       
    

   
     
                
                    

                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                

                 
                    
                        
                    
                    
                        
                    

                
                

                
                

        
    

