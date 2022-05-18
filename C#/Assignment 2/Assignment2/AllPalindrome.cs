using System;
namespace Assignment2
{
	public class AllPalindrome
	{
		public AllPalindrome(string s)
		{
            char[] delimiterChars = { ' ', ',', '.', ':', '?', ';', '=' ,'(',')', '&', '[',']', '"' , @"'"[0], @"\"[0], '/', '!'};
            string[] words = s.Split(delimiterChars);
            List<string> list = new List<string>();
            foreach( var word in words){
                if(palindrome(word) && word != "")
                    list.Add(word);
            }
           list.Sort();
           Console.WriteLine(list.Count());
           Console.WriteLine(list.Aggregate((a, x) => a + "," + x));
		}
        public bool palindrome(string s){
            
            char[] ch = s.ToCharArray();
            Array.Reverse(ch);
            string r = new String(ch);
            if(s.Equals(r)){
                return true;
            }
            return false;
        }
    }
}
