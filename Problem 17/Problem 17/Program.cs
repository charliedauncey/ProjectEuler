using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numberLengths = new Dictionary<int, int>();
            Dictionary<int, int> specialLengths = new Dictionary<int, int>();

            numberLengths.Add(0, 0);
            numberLengths.Add(1, 3);
            numberLengths.Add(2, 3);
            numberLengths.Add(3, 5);
            numberLengths.Add(4, 4);
            numberLengths.Add(5, 4);
            numberLengths.Add(6, 3);
            numberLengths.Add(7, 5);
            numberLengths.Add(8, 5);
            numberLengths.Add(9, 4);
            numberLengths.Add(10, 3);
            numberLengths.Add(11, 6);
            numberLengths.Add(12, 6);

            specialLengths.Add(2, 4);
            specialLengths.Add(3, 4);
            specialLengths.Add(4, 3);
            specialLengths.Add(5, 3);
            specialLengths.Add(6, 3);
            specialLengths.Add(7, 5);
            specialLengths.Add(8, 4);
            specialLengths.Add(9, 4);

            int sum = 0;

            for(int i=0 ;i<=1000; i++)
            {
                string x = Convert.ToString(i);

                if(x.Length == 1)
                {
                    int Length = numberLengths[i];
                    sum = sum + Length;
                }
                else if (x.Length == 2)
                {
                    if(i == 10 || i == 11 || i == 12)
                    {
                        int Length = numberLengths[i];
                        sum = sum + Length;
                    }

                    else if (i > 12  && i<20)
                    {
                        int Length = 0;
                        if (i == 14)
                        {
                            Length = 4;
                        }
                        else
                        {
                            Length = specialLengths[Convert.ToInt32(x.Substring(1, 1))];
                        }
                        sum = sum + Length + 4;
                    }
                    else if(i >= 20)
                    {
                        int Length = specialLengths[Convert.ToInt32(x.Substring(0, 1))] + 2;
                        int Length1 = numberLengths[Convert.ToInt32(x.Substring(1, 1))];

                        sum = sum + Length + Length1;
                    }
                }
                else if (x.Length == 3)
                {
                    int Length = numberLengths[Convert.ToInt32(x.Substring(0, 1))] + 7 + 3;


                    int secondNumber = Convert.ToInt32(x.Substring(1, 1));
                    int thirdNumber = Convert.ToInt32(x.Substring(2, 1));
                    int last2 = Convert.ToInt32(x.Substring(1, 2));
                    
                    


                    if(secondNumber == 0)
                    {
                        if (thirdNumber == 0)
                        {
                            sum = sum + Length - 3;
                        }
                        else if(thirdNumber != 0)
                        {
                            int Length1 = numberLengths[thirdNumber];
                            sum = sum + Length1 + Length;
                        }
                    }
                    else if (secondNumber != 0)
                    {
                        

                        if (last2 == 10 || last2 == 11 || last2 == 12)
                        {
                            int Length2 = numberLengths[last2];
                            sum = sum + Length2 + Length;
                        }

                        else if (last2 > 12 && last2 < 20)
                        {
                            int Length2 = 0;
                            if (last2 == 14)
                            {
                                Length2 = 4;
                            }
                            else
                            {
                                Length2 = specialLengths[Convert.ToInt32(x.Substring(2, 1))];
                            }
                            sum = sum + Length2 + 4 + Length;
                        }
                        else if (last2 >= 20)
                        {
                            int Length3 = specialLengths[Convert.ToInt32(x.Substring(1, 1))] + 2;
                            int Length4 = numberLengths[Convert.ToInt32(x.Substring(2, 1))];

                            sum = sum + Length3 + Length4 + Length;
                        }


                    }

                }
                else if (i == 1000)
                {
                    sum = sum + 11;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
