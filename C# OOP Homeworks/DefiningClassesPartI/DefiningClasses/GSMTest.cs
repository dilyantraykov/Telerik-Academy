namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void Test()
        {
            var GSMs = new List<GSM>();

            var myGSM = new GSM("Xperia Z", "Sony", 613, "Slim Shady",
                new Battery(BatteryType.LiIon, "2330", 550, 11), new Display(5.0, 16000000));
            GSMs.Add(myGSM);

            var myGSM2 = new GSM("One", "HTC", 638, "Krali Marko",
    new Battery(BatteryType.LiPo, "2300", 500, 27), new Display(4.7, 16000000));
            GSMs.Add(myGSM2);

            foreach (var phone in GSMs)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
