using System.Text.RegularExpressions;
namespace регулярные_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader("file.txt");
            string line = Console.ReadLine();
            Regex regex = new Regex(@$"{line}(\w*)");
            string s = rd.ReadToEnd();
            Console.WriteLine(s);
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
                foreach (Match match in matches)
                    Console.WriteLine(match.Value.ToUpper());
            else
                Console.WriteLine("Совпадений нету");
            string pattern = @"\d+";
            Regex regex_1 = new Regex(pattern);
            string line_1 = Console.ReadLine();
            string result = regex_1.Replace(s, line_1);
            Console.WriteLine(result);
        }
    }
}
