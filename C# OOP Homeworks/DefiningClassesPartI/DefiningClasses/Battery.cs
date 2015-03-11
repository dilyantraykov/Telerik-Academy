namespace DefiningClasses
{
    using System;

    public class Battery
    {
        private string _model;
        private double _hoursIdle;
        private double _hoursTalk;

        public Battery(BatteryType batteryType, string model)
        {
            this.BatteryType = batteryType;
            this.Model = model;
        }

        public Battery(BatteryType batteryType, string model, double hoursIdle)
                : this(batteryType, model)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(BatteryType batteryType, string model, double hoursIdle, double hoursTalk)
                : this(batteryType, model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public override string ToString()
        {
            return BatteryType.ToString() + " " + Model.ToString();
        }

        public BatteryType BatteryType { get; private set; }

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

        public double HoursIdle 
        {
            get { return this._hoursIdle; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Idle should be positive!");
                }
                this._hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return this._hoursTalk; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Talk should be positive!");
                }
                this._hoursTalk = value;
            }
        }
    }
}
