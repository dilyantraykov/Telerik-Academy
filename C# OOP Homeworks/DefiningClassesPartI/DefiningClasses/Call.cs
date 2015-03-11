namespace DefiningClasses
{
    using System;

    public class Call
    {
        private string _dialedNumber;

        public Call(DateTime dateAndTime, string dialedNumber, uint duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public DateTime DateAndTime { get; set; }

        public string DialedNumber
        {
            get { return _dialedNumber; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dialed number should not be empty!");
                }
                this._dialedNumber = value;
            }
        }

        public uint Duration { get; set; }

        public override string ToString()
        {
            var callInfo = String.Format("{0, -10} | {1, -8} | {2, 10} | {3, 5}s", this.DateAndTime.ToString("dd.MM.yyyy"), this.DateAndTime.ToString("hh:mm:ss"), this.DialedNumber, this.Duration);
            return callInfo;
        }
    }
}
