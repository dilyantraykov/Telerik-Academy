namespace IfStatements
{
    using System;

    public class LongStatement
    {
        public const long MinX = 0;
        public const long MinY = 0;
        public const long MaxX = 100;
        public const long MaxY = 100;

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static void SomeMethod()
        {
            var x = 5;
            var y = 20;
            var shouldVisitCell = true;

            bool xIsValid = (x >= MinX) && (x <= MaxX);
            bool yIsValid = (y >= MinY) && (y <= MaxY);

            if (xIsValid && yIsValid && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}
