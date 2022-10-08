using System;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            string result = "";
            for (int i = 0; i < original.Length; i++)
            {
                if (Char.IsLetter(original[i]) || Char.IsDigit(original[i]) || original[i] == '-' || original[i] == ' ' || original[i] == '_')
                {
                    result += original[i];
                }
            }
            return result;
        }
    }
}
