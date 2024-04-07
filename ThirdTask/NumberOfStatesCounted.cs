using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task.ThirdTask
{
    public class NumberOfStatesCounted
    {

        public static Dictionary<char, List<string>> GetNumberOfStatesCounted(List<string> states)
        {
            var groupedStates = states.GroupBy(s => s[0])  //grouping based on first element or index
                .OrderBy(group => group.Key)  //the key is the first char
                .ToDictionary(group => group.Key, group => group.ToList());  //hence key = first, value = list of states with that first character.

            return groupedStates;
        }

        public static void OutputForNumOfStatesCounted()
        {

            List<string> states = new List<string>
            {
            "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa",
            "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo",
            "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano",
            "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa",
            "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers",
            "Sokoto", "Taraba", "Yobe", "Zamfara"
            };

            Dictionary<char, List<string>> groupedStates = GetNumberOfStatesCounted(states);

            foreach (var group in groupedStates)
            {
                Console.WriteLine($"Group {group.Key} - {group.Value.Count}");  // num of elem in value
                Console.WriteLine(new string('-', 16));

                foreach (var state in group.Value)
                {
                    Console.WriteLine(state);  //elem in value
                }
                Console.WriteLine();
            }

        }

    }
}
