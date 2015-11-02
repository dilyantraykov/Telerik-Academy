namespace JediMeditation
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numberOfJedi = Console.ReadLine();
            var jediAsString = Console.ReadLine();
            var jediAsArray = jediAsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var padawans = new List<string>();
            var knights = new List<string>();
            var masters = new List<string>();

            foreach (var jedi in jediAsArray)
            {
                switch (jedi[0])
                {
                    case 'p':
                        padawans.Add(jedi);
                        break;
                    case 'k':
                        knights.Add(jedi);
                        break;
                    case 'm':
                        masters.Add(jedi);
                        break;
                }
            }

            var mastersAsString = string.Join(" ", masters);
            var knightsAsString = string.Join(" ", knights);
            var padawansAsString = string.Join(" ", padawans);
            Console.WriteLine("{0} {1} {2}", mastersAsString, knightsAsString, padawansAsString);
        }
    }
}
