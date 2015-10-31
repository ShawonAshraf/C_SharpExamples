using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Text_To_Speech
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null; // for text input
            SpeechSynthesizer talker = new SpeechSynthesizer(); // the synthesizer to convert text to speech

            Console.WriteLine("Enter the text to convert to speech : ");
            input = Console.ReadLine();

            talker.Speak(input); // Speak() is a built in method in System.Speech.Synthesis namespace
                                 // in .NET framework that converts a string to speech

            Console.WriteLine("\nJob done!, press any key to exit now .....\n");
            Console.Read();
        }
    }
}
