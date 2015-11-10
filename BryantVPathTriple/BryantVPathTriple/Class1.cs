using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryantVPathTriple
{
    class PythagoreanTripCounter
    {
        public int TripleCounter;
        protected int maxNumber;

        public PythagoreanTripCounter()
        {
            maxNumber = 500;
        }

        public PythagoreanTripCounter(string maxNum)
        {
            int input;
            try
            {
                input = int.Parse(maxNum);
                maxNumber = input;
            }
            catch
            {
                Exception message = new Exception();
                //message = "Please enter a valid Integer to evaluate the Pythagorean Triples";

            }
        }

        public int MaxNumber
        {
            get
            {
                return maxNumber;
            }
            set
            {
                if (value >= 0)
                {
                    maxNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("MaxNumber", value, "Figure must be greater than Zero");

                }
            }
        }

        public int PythagoreanTripleCalculator()
        {


            for (int a = 1; a <= maxNumber; a++)
            {
                for (int b = 1; b <= maxNumber; b++)
                {
                    for (int c = 1; c <= maxNumber; c++)
                    {
                        int abSum;
                        abSum = (a ^ 2 + b ^ 2);

                        //bool Pythagorean Triple If statement
                        if (abSum == (c ^ 2))
                            TripleCounter += 1;

                        else
                        {
                            break;
                        }

                    }
                }
            }
            return TripleCounter;
        }

        public static string MessageInputMax()
        {
            string input;
            Console.WriteLine("Find how many Pythagorean Triples there are, up to: (Pick an integer) \n");
            input = Console.ReadLine();

            if (input == "")
            {
                return "";
                //No input, use first constructor. Default value
            }
            else
            {
                return input;
                //input, pass on to constructor to evaluate with given figure
            }


        }

        public static string MessageIntro()
        {
            string intro;
            intro = "Welcome to the Pythagorean Triple Calculator! \n Where you can see how many triples are found when each side of the triangle is incremented to the number you choose.";
            return intro;
        }
    }
}
