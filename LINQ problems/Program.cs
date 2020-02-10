using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1
            //List<string> words =  new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            // var list = from word in words
            //            where word.Contains("th")
            //            select word;
            // foreach (string words1 in list)
            // {
            //     Console.WriteLine(words1);
            // }
            // Console.ReadLine();

            ////2
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var list = names.Distinct();
            //foreach(string name in list)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            ////3
            //List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            //var result = classGrades.Select(
            //    g =>
            //    {
            //        var parsedInt = g.Split(',').Select(x => int.Parse(x));
            //        var avgRemoveMin = parsedInt.Where(x => x != parsedInt.Min()).Average();
            //        return avgRemoveMin;
            //    }
            //    ).Average();
            //Console.WriteLine(result);
            //Console.ReadLine();

            //4
            string name = "Terril";
            var result = name.ToUpper().GroupBy(a => a).Select(b => $"{b.Key}{b.Count()}").OrderBy(b => b).ToList();
            result.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
