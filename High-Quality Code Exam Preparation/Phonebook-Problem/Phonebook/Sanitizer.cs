namespace Phonebook
{
    using System.Text;

    public class Sanitizer
    {
        private const string CountryCode = "+359";

        public string ConvertToCanonicalPhoneNumberFormat(string phoneNumber)
        {
            StringBuilder canonicalNumber = new StringBuilder();

            foreach (char ch in phoneNumber)
            {
                if (char.IsDigit(ch) || (ch == '+'))
                {
                    canonicalNumber.Append(ch);
                }
            }

            if (canonicalNumber.Length >= 2 &&
                canonicalNumber[0] == '0' &&
                canonicalNumber[1] == '0')
            {
                canonicalNumber.Remove(0, 1);
                canonicalNumber[0] = '+';
            }

            while (canonicalNumber.Length > 0 && canonicalNumber[0] == '0')
            {
                canonicalNumber.Remove(0, 1);
            }

            if (canonicalNumber.Length > 0 && canonicalNumber[0] != '+')
            {
                canonicalNumber.Insert(0, CountryCode);
            }

            return canonicalNumber.ToString();
        }
    }
}
