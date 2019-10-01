using System;
using System.Linq;
using System.Collections.Generic;


namespace anagram.models
{
    public class Item
    {
        public string Word { get; set; }
        public static List<String> wordsCompare = new List<String> { };

        public char[] WordArray {get; set; }
       

        public Item(string word)
        {
            Word = word;          
            WordArray = Word.ToCharArray();
                       
        }


        public List<string> gatherInput(string newInput)
        {
            string newestWord = newInput;
            wordsCompare.Add(newestWord);
            return Item.wordsCompare;
        }
        public char[] SortArray()
        {
            Array.Sort(WordArray);
            return WordArray;          
        }

        public bool CompareArrays()        
        {
            bool result = false;
            Array.Sort(WordArray);
            List<String> Anagrams = new List<String> {};
            for (int i = 0; i < wordsCompare.Count; i++)
            {              
                char[] newWords = wordsCompare[i].ToCharArray();
                Array.Sort(newWords);

                if (newWords.SequenceEqual(WordArray) == true)
                {
                    
                    Anagrams.Add(wordsCompare[i]);
                    result = true;

                }
                else
                {
                    result = false;
                }
                                                         
            }
            return result;

        }
         public static void ClearAll()
        {
            wordsCompare.Clear();
           
        }
       
    }

}