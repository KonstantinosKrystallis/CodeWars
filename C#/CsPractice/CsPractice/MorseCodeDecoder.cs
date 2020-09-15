using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
	class MorseCodeDecoder
	{
		//https://www.codewars.com/kata/54b724efac3d5402db00065e/train/csharp
		public static string Decode(string morseCode)
		{
			string[] morseAlphabet = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "...---...", ".-.-.-", "-.-.--" };

			string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "SOS", ".", "!"};

			string[] temp = morseCode.Split(' ');

			morseCode = "";

            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < morseAlphabet.Length; j++)
                {
					if (temp[i] == morseAlphabet[j])
					{
						morseCode = morseCode + alphabet[j];
						break;
					}
                }
				morseCode = morseCode + " ";
			}
			morseCode = morseCode.Replace("   ", "|");
			morseCode = morseCode.Replace(" ", "");
			morseCode = morseCode.Replace("|", " ");
			return morseCode.Trim();
			throw new System.NotImplementedException("Please provide some code.");
		}

		public static string Decode2(string morseCode)
		{
			var words = morseCode.Trim().Split(new[] { "   " }, StringSplitOptions.None);
			var translatedWords = words.Select(word => word.Split(' ')).Select(letters => string.Join("", letters.Select(MorseCode.Get))).ToList();
			return string.Join(" ", translatedWords);
		}
	}
}