using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Number of substutions
            string initial = "abc";  // xyz 
            string goal = "abcbc";  // bc + b + ac  // acdbc     // xzyxz
            string tmpString = "";

            int num=minimumConcat(initial, goal);

        }

        /// <summary>
        /// Find max word substitions 
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="goal"></param>
        /// <returns></returns>
        static int minimumConcat(string initial, string goal)
        {
            string tmpString = "";
            string str = goal;
            int v = 0;
            string tmpGoal = goal;
            int goalIndex = 0;
            int outputNum = 0;
            while (true)
            {
                for (int g = 0, i = 0; g < goal.Length;)
                {
                    if (goal[g] == initial[i])
                    {
                        tmpString += initial[i];
                        i++;
                        g++;


                    }
                    else if(!initial.Contains( goal[g]))
                    {
                        return -1;
                    }
                    else
                    {
                        i++;
                    }

                    if (i == initial.Length)
                    {
                        i = 0;
                        outputNum++;

                    }

                    if (goal == tmpString)
                    {
                        Console.WriteLine("{0}", outputNum);
                        return outputNum ;

                    }
                    //else if(g==goal.Length )
                    //{
                    //    Console.WriteLine("{0}", -1);
                    //}
                }

            }
            return 0;
        }
        static int GetNumOfOffices(char[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int numOfOnes = 0;
            int countOfOffices = 0;
            int t = 0;

            List<string> str;

            for (int i = 0; i < rows; i++)
            {

                for (int k = 0; k < cols; k++)
                {
                    if (arr[i, k] == '1' && i == 0 && k == 0)
                    {
                        numOfOnes++;
                    }
                    else if (arr[i, k] == '1' && (arr[i, k + 1] != '1' || arr[i, k - 1] != '1'))
                    {
                        numOfOnes++;
                    }
                }


            }

            return 0;
        }

        static bool checkChar(char[] initial, char[] goal)
        {
            bool started = false;
            int foundIndex = 0;
            for (int i = 0; i < initial.Length; i++)
            {
                if (initial[i] == goal[foundIndex])
                {
                    started = true;
                    foundIndex++;
                }
            }
            if (started)
            {
                //return goal.(foundIndex);
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}