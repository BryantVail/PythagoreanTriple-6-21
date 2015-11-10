using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryantVPathTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum;
            int triples;
             
            PythagoreanTripCounter.MessageIntro();
            bool blnRestart = false;

            while(blnRestart == false)
            {
                
                string userInput;
               userInput =  PythagoreanTripCounter.MessageInputMax();
                PythagoreanTripCounter PythTripCalculator = new PythagoreanTripCounter(userInput);
                maxNum = PythTripCalculator.MaxNumber;
               PythTripCalculator.TripleCounter = PythTripCalculator.PythagoreanTripleCalculator();
               Console.WriteLine("There are {0} Pythagorean Triples when sides are cycled each through {1} times", PythTripCalculator.TripleCounter, PythTripCalculator.MaxNumber);


                //if (userInput == "")
                //{
                //    PythTripCalculator.PythagoreanTripCounter();

                //}
                //else
                //{
                //    PythTripCalculator.pythagoreanTripCounter(userInput);
                //}

            }
        }
    }
}
