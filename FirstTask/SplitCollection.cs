using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task.FirstTask
{   public class SplitCollection
    {

        public static List<string> SplitCollectionMethod(int groupSize)
        {
            List<string> states = new List<string>
            {
                "Abia", "Adamawa", "Akwa-Ibom", "Anambra", "Bauchi", "Bayelsa",
                "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo",
                "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano",
                "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa",
                "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers",
                "Sokoto", "Taraba", "Yobe", "Zamfara"
            };

            // Split the states into groups of the specified size
            var groups = states
                .Select((state, index) => new { state, index })
                .GroupBy(x => x.index / groupSize)
                .Select(x => string.Join(", ", x.Select(x => x.state)))
                .ToList();

            return groups;
        }


        public static void OutputOfCollection()
        {
            Console.WriteLine("Please input a number");
            int groupSize = int.Parse(Console.ReadLine());
            while (groupSize < 1 || groupSize > 36)
            {
                Console.WriteLine("PLease input a number that is not less than 1 and not higher than 36");
                groupSize = int.Parse(Console.ReadLine());
            }


            List<string> result = SplitCollection.SplitCollectionMethod(groupSize);

            Console.WriteLine($"A Group of states in set of {groupSize}:\n");
            Console.WriteLine("============================\n");

            foreach (var group in result)
            {
                Console.WriteLine($"Group: {group}");
                Console.WriteLine(new string('-', 30));  //makes use of the string class to pqerform an action
                Console.WriteLine(); 
            }

        }

    }
}
