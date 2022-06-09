namespace BackingFields
{
    internal class TimePeriod
    {
        // backing field
        private double _seconds;

        public double Hours
        {
            get { return _seconds / 3600; }
            set
            {
                if(value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 24.");
                }

                _seconds = value * 3600;
            }
        }

        public double Seconds
        {
            get => _seconds;
            set => _seconds = value;
        }
    }
}
