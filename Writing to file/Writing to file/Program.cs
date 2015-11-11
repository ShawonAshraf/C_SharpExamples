using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for StreamWriter 
using System.IO;

namespace Writing_to_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello! If you're reading this inside a file, this program has done it's job successfully!";
            StreamWriter writer;
            FileStream file;

            // let's use exception handling
            // it's a good practice in handling files since
            // this will make error tracking easier

            try
            {
                file = new FileStream("Data.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(file);
                writer.WriteLine(data);

                // a good practice to close all the 
                // resources
                writer.Close();
                file.Close(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nData successfully written to file Data.txt");
            }

            Console.ReadLine();
        }
    }
}
