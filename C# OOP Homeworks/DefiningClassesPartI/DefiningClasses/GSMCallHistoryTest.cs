using System.Collections.Generic;

namespace DefiningClasses
{
    using System;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM myGSM = new GSM("Xperia S", "Sony", 700, "Slim Shady",
                new Battery(BatteryType.LiIon, "1750", 48, 24), new Display(4.3, 16000000));

            var calls = new List<Call>();
            calls.Add(new Call(DateTime.Now.AddDays(-2), "+359892412424", 99));
            calls.Add(new Call(DateTime.Now.AddDays(-3).AddHours(3.5), "+359884631253", 123));
            calls.Add(new Call(DateTime.Now.AddDays(-4), "+359874123173", 44));

            foreach (var call in calls)
            {
                myGSM.AddCallToHistory(call);
            }

            Console.WriteLine();
            myGSM.PrintCallHistory();

            Console.WriteLine();
            Console.WriteLine("Total price is: {0:C}", myGSM.GetTotalPriceOfCalls(0.37M));

            myGSM.RemoveLongestCallFromHistory();

            Console.WriteLine();
            Console.WriteLine("Total price without the longest call is: {0:C}", myGSM.GetTotalPriceOfCalls(0.37M));

            myGSM.ClearCallHistory();

            Console.WriteLine();
            myGSM.PrintCallHistory();
        }
    }
}
