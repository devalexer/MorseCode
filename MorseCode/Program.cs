using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {

        static void Main(string[] args)
        {

            //define dictionary
            var morseCodeDictionary = new Dictionary<char, string>();

            //save morse.csv file path
            var morseCodeCSV = "morse.csv";

            // access .csv file and read into program with streamreader
            using (var reader = new StreamReader(morseCodeCSV))
            {
                //while peeking at each line by reading the first character
                while (reader.Peek() > -1)
                {
                    //break csv file into char & string parts, splitting by the comma
                    var line = reader.ReadLine().Split(','); // ["S","..."]

                    //add the split string into the dictionary
                    morseCodeDictionary.Add(char.Parse(line[0]), line[1]);
                }
            }

            //request user input
            Console.WriteLine("What would you like translated to morse code?");
            string toBeTranslated = Console.ReadLine().ToUpper();

            //for each letter in user input, return equivalent character from dictionary
            //You need to display that string back to the user in Morse Code
            var translatedString = "";
            foreach (var letter in toBeTranslated)
            {
                Console.WriteLine(morseCodeDictionary[letter]);
                translatedString += (morseCodeDictionary[letter]);
            }

            //Save the users input to a CSV as both the original string and encoded.

            var storedmorseCodeCSV = "storedmorse.csv";

            using (StreamWriter sw = File.AppendText(storedmorseCodeCSV))
            {
                sw.WriteLine(toBeTranslated);
                sw.WriteLine(translatedString);
            }

            //Ask the user if they have any more messages that they want to encode
            //repeat steps 2 - 6 until the user elects to step

            Console.WriteLine("Do you have any more messages to encode - Y or N? ");
            var repeat = Console.ReadLine();

            if (repeat == "Y")
            {

            }
            else
            {
                Console.WriteLine("Thank you, come again.");
            }
            


        }

    }
    
}
