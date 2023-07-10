using System;
using System.IO;
using System.Collections.Generic;


namespace ActivitiesOnFiles
{
    internal class ActivitiesOnFiles
    {
        static void Main()
        {
            string[] array;
            StreamReader reader = new StreamReader(@"../../Words.txt");
            string snumber = reader.ReadLine();
            int n = int.Parse(snumber);

            array = new string[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = reader.ReadLine();
            } 
            reader.Close();

            
            

            StreamWriter writer = new StreamWriter(@"../../Output.txt");
            writer.WriteLine("");
            writer.Close();
            Console.ReadKey();
        }
    }
}
