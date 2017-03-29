using System;
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
            var morseCodeCSV = "morse.cvs";

            // access .csv file and read into program with streamreader
            using (var reader = new StreamReader(morseCodeCSV))
            {
                //while peeking at each line by reading the first character
                while (reader.Peek() > -1)
                {
                    //break csv file into char & string parts, splitting by the comma
                    var line = reader.ReadLine().Split(','); // ["S","..."]

                    //add the split string into the dictionary
                    morseCodeDictionary.Add(line[0].ToString(), line[1]);
                }
            }

            //split strings in dictionary to char and strings??

            //request user input
            Console.WriteLine("What would you like translated to morse code?");
            string toBeTranslated = Console.ReadLine();

            //  *  Using the dictionary created, translate the inputed string into morse code
            //break apart user input to chars
            
            //for each letter in user input, return equivalent character from dictionary
            foreach (var line in morseCodeDictionary)
            {

            }




            //You need to display that string back to the user in Morse Code



        }

    }
    
}
