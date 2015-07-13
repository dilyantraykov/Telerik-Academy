using System;

namespace IfStatements
{
    class Cooking
    {
        static void Main(string[] args)
        {
            Potato potato = GetPotato();
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
            else
            {
                throw new Exception("Potato should not be null!");
            }
        }

        private static Potato GetPotato()
        {
            throw new NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            throw new System.NotImplementedException();
        }
    }
}
