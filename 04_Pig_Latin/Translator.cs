using System;

namespace _04_Pig_Latin
{
    internal class Translator
    {
        /*internal string Translate(string v)
        {
            /* switch(v)
             {
                 case "apple":
                     return "apple" + "ay";
                     break;
                 case "banana":
                     return "ananab" + "ay";
                     break;
                 case "cherry":
                     return "errych" + "ay";
                     break;
                 case "eat pie":
                     return "eat" + "ay " + "iep" + "ay";
                     break;
                 case "three":
                     return "eethr" + "ay";
                     break;
                 case "school":
                     return "oolsch" + "ay";
                     break;
                 case "quiet":
                     return "ietqu" + "ay";
                     break;
                 case "square":
                     return "aresqu" + "ay";
                     break;
                 case "the quick brown fox":
                     return "eth" + "ay" + " ickqu" + "ay" + " ownbr" + "ay" + " oxf" + "ay";
                     break;
                 default:
                     return "";
             }


             return "";




        }*/


        internal string Translate(string v)
        {
            string result = "";
            string[] words = v.Split();

            foreach(string word in words)
            {
                char firstChar = word[0];
                if (IsVowel(firstChar))
                {
                    result += word + "ay ";
                }
                else
                {
                    
                    int position = GetPositionLastConsoantBeforeVowel(word);
                    string consoants = word.Substring(0, position);
                    result += word.Substring(position) + consoants + "ay ";
                    
                }
            }
            return result.Trim();

        }

        private int GetPositionLastConsoantBeforeVowel(string wordToFind)
        {
            int i = 0;
            bool foundVowel = false;
            foreach(char character in wordToFind)
            {
                if(!IsVowel(character) && !foundVowel)
                {
                    i++;
                }
                else
                {
                    foundVowel = true;
                }
            }

            return i;
        }

        private bool IsVowel(char firstL)
        {
            char[] vowels = { 'a', 'e', 'i', 'o'};
            bool isVowel = false;
            foreach(char vowel in vowels)
            {
                if(vowel == firstL)
                {
                    isVowel = true;
                }
            }

            return isVowel;
        }
    }
}