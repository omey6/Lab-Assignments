using System;
using System.Collections.Generic;

namespace Lab5_2
{
    class Program
    {

        public enum Months
        {

            October,
            November,
            December,
            January,
            February,
            March,
            April,
        }
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();


            foreach (Months Months in Enum.GetValues(typeof(Months)))

            {
                Console.WriteLine("Whats the plans for the Month of " + Months);
                string task = Months + " : " + Console.ReadLine();
                taskList.Add(task);

            }
foreach(string task in taskList)
            {
                Console.WriteLine(task);
            }

        }
    }
}
