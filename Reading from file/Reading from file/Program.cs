using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Reading_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file;
            StreamReader reader;
            string data = ""; // an empty string

            try
            {
                file = new FileStream("Data.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);

                string x;
                while ((x = reader.ReadLine()) != null)
                {
                    data += x;
                }

                reader.Close();
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Data read from file : \n\n");
                Console.WriteLine(data);
            }

            Console.ReadLine();
        }
    }
}
