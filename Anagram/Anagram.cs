using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) 
        {
            int LengthOfWord1 = word1.Length; 
            int LengthOfWord2 = word2.Length;
            
            if (LengthOfWord1 != LengthOfWord2) 
            { 
                Console.WriteLine("The two words {0} and {1} are Anagrams", word1, word2);
                return false; 
            }
            
            char[] ArrayOfWord1 = word1.ToLower().ToCharArray();
            char[] ArrayOfWord2 = word2.ToLower().ToCharArray();
            
            Array.Sort(ArrayOfWord1);
            Array.Sort(ArrayOfWord2);          
            
            string new_SortedWord1 = new string(char_word1);
            string new_SortedWord2 = new string(char_word2);
            
            if(new_SortedWord1 == new_SortedWord2)
            {
                Console.WriteLine("The two words {0} and {1} are Anagrams", word1, word2);
                return true;
            }
            else
            {
                Console.WriteLine("The two words {0} and {1} are not Anagrams", word1, word2);
                return false;
            }
                
            
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            
            for(int iterator=0; iterator<candidates.Count; iterator++)
            {
                if (WordPairIsAnagram(word , candidates[iterator]) == false)
                {
                    candidates.RemoveAt(iterator);
                    iterator--;
                }
            }
            
            return candidates;
        }
    }
}
