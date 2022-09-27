using System.Reflection.Metadata.Ecma335;

namespace stringsub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = "abcabcabcabc";
            Console.WriteLine("original string" + str);
            Console.WriteLine("length of the longest string");
            Console.WriteLine(without_repeated_chars_longest_substring(str));

        }
        public static int without_repeated_chars_longest_substring(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            var map_str1 = new Dictionary();
            var max_len = 0;
            var last_repeat_pos = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (map_str1.ContainsKey(str[i]) && last_repeat_pos < map_str1[map_str1[i]])
                    last_repeat_pos = map_str1[str[i]];
                if (max_len < i - last_repeat_pos)
                    max_len = i - last_repeat_pos;
                map_str1[str[i]] = i;
            }
            return max_len;


        }
    }
}