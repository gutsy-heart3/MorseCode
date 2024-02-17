using System;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string choice;
            Console.WriteLine("Select an option:\n1.Generate to Morse.\n2.Generate from Morse ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Enter the text to be translated into Morse code:");
                string SimpleToMorse = Console.ReadLine();
                string morseCode = program.GenerateToMorse(SimpleToMorse);
                Console.WriteLine("Text in Morse code:");
                Console.WriteLine(morseCode);
            }
            else
            {
                Console.WriteLine("Enter the text you want to translate into plain text:");
                string MorseToSimple = Console.ReadLine();
                string plainText = program.GenerateFromMorse(MorseToSimple);
                Console.WriteLine("Plain text: ");
                Console.WriteLine(plainText);
            }
        }

        public string GenerateToMorse(string txt)
        {
            txt = txt.ToUpper();
            string morseTxt = "";
            foreach (char s in txt)
            {
                switch (s)
                {
                    case 'A':
                        morseTxt += ".- ";
                        break;
                    case 'B':
                        morseTxt += "-... ";
                        break;
                    case 'C':
                        morseTxt += "-.-. ";
                        break;
                    case 'D':
                        morseTxt += "-.. ";
                        break;
                    case 'E':
                        morseTxt += ". ";
                        break;
                    case 'F':
                        morseTxt += "..-. ";
                        break;
                    case 'G':
                        morseTxt += "--. ";
                        break;
                    case 'H':
                        morseTxt += ".... ";
                        break;
                    case 'I':
                        morseTxt += ".. ";
                        break;
                    case 'J':
                        morseTxt += ".--- ";
                        break;
                    case 'K':
                        morseTxt += "-.- ";
                        break;
                    case 'L':
                        morseTxt += ".-.. ";
                        break;
                    case 'M':
                        morseTxt += "-- ";
                        break;
                    case 'N':
                        morseTxt += "-. ";
                        break;
                    case 'O':
                        morseTxt += "--- ";
                        break;
                    case 'P':
                        morseTxt += ".--. ";
                        break;
                    case 'Q':
                        morseTxt += "--.- ";
                        break;
                    case 'R':
                        morseTxt += ".-. ";
                        break;
                    case 'S':
                        morseTxt += "... ";
                        break;
                    case 'T':
                        morseTxt += "- ";
                        break;
                    case 'U':
                        morseTxt += "..- ";
                        break;
                    case 'V':
                        morseTxt += "...- ";
                        break;
                    case 'W':
                        morseTxt += ".-- ";
                        break;
                    case 'X':
                        morseTxt += "-..- ";
                        break;
                    case 'Y':
                        morseTxt += "-.-- ";
                        break;
                    case 'Z':
                        morseTxt += "--.. ";
                        break;
                    case ' ':
                        morseTxt += "/ ";
                        break;
                    default:
                        morseTxt += s + "/ ";
                        break;
                }
            }
            return morseTxt.Trim();
        }
        public string GenerateFromMorse(string txt)
        {
            string[] morseAlphabet = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." };
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            txt = txt.Trim();

            string[] words = txt.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                string[] letters = word.Split(' ');
                foreach (string letter in letters)
                {
                    int index = Array.IndexOf(morseAlphabet, letter);
                    if (index != -1)
                    {
                        result += alphabet[index];
                    }
                    else
                    {
                        result += letter;
                    }
                }
                result += " ";
            }
            return result.Trim();
        }
    }
}
