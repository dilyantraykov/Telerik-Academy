namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class GSM
    {
        private string _model;
        private string _manufacturer;
        private double _price;
        private string _owner;
        private static readonly GSM _IPhone4S = new GSM("IPhone 4S", "Apple", 1200);

        public GSM(string model, string manufacturer, double price = 0, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public string Model
        {
            get { return this._model; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model should not be empty!");
                }
                this._model = value;
            }
        }

        public string Manufacturer
        {
            get { return this._manufacturer; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer should not be empty!");
                }
                this._manufacturer = value;
            }
        }

        public double Price
        {
            get { return this._price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                this._price = value;
            }
        }

        private bool IsValidName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]) && name[i] != ' ' && name[i] != '-')
                {
                    return false;
                }
            }
            return true;
        }

        public string Owner
        {
            get { return this._owner; }
            private set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (!IsValidName(value))
                    {
                        throw new ArgumentException("Owner name can contain only letters, spaces and hyphens!");
                    }
                }
                this._owner = value;
            }
        }

        public Battery Battery { get; private set; }

        public Display Display { get; private set; }

        public List<Call> CallHistory { get; private set; }

        public static GSM IPhone4S
        {
            get { return GSM._IPhone4S; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Model: {0,-10}", this.Model);
            Console.WriteLine("Manufacturer: {0,-10}", this.Manufacturer);
            Console.WriteLine("Price: {0,-10:C}", this.Price);
            Console.WriteLine("Owner: {0,-10}", this.Owner);
            Console.WriteLine("Battery: {0,-10}", this.Battery);
            Console.WriteLine("Display: {0,-10}", this.Display);
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendLine(String.Format("Model: {0,-10}", this.Model));
            info.AppendLine(String.Format("Manufacturer: {0,-10}", this.Manufacturer));
            info.AppendLine(String.Format("Price: {0,-10:C}", this.Price));
            info.AppendLine(String.Format("Owner: {0,-10}", this.Owner));
            info.AppendLine(String.Format("Battery: {0,-10}", this.Battery));
            info.AppendLine(String.Format("Display: {0,-10}", this.Display));
            return info.ToString().Trim();
        }

        public void AddCallToHistory(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCallFromHistory(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void RemoveLongestCallFromHistory()
        {
            if (this.CallHistory.Count > 0)
            {
                this.CallHistory = this.CallHistory.OrderByDescending(x => x.Duration).ToList();
                this.CallHistory.RemoveAt(0);
            }
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal GetTotalPriceOfCalls(decimal pricePerMinute)
        {
            var totalPrice = 0M;
            foreach (var call in CallHistory)
            {
                totalPrice += (call.Duration/60 + 1) * pricePerMinute;
            }
            return totalPrice;
        }

        public void PrintCallHistory()
        {
            if (this.CallHistory.Count > 0)
            {
                Console.WriteLine("{0, -10} | {1, -8} | {2, 10} | {3, 5}", "Date", "Time", "Dialed number", "Duration");
                foreach (var call in this.CallHistory.OrderBy(x => x.DateAndTime))
                {
                    Console.WriteLine(call.ToString());
                }
            }
            else
            {
                Console.WriteLine("No calls to display!");
            }
        }
    }
}
