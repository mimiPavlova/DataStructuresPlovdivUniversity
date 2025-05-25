using System.Collections;

namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table=new Hashtable();
            
            char[] puntcuation = { '.', ',','!','?','-'};
            string text = Console.ReadLine().ToLower();

            foreach (char simbol in puntcuation)
            {
                if (text.Contains(simbol))
                {
                    text=text.Replace(simbol, ' ');
                }
            }
            string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
             

            foreach (string word in words)
            {
                if(!table.ContainsKey(word))
                {
                    table[word]=1;
                }
                else
                {
                    int value=(int)table[word];
                    table[word]=value+1;
                }
                
                
            }
            // LINQ към Hashtable работи чрез Cast<DictionaryEntry>()
            var sorted = table.Cast<DictionaryEntry>().OrderBy(w => w.Key);
            foreach (DictionaryEntry w in sorted)
            {
                Console.WriteLine($"{w.Key} - {w.Value}");
            }        
        }


    }
}
