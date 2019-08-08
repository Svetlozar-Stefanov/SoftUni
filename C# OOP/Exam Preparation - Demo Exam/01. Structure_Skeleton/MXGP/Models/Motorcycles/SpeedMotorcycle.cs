using MXGP.Utilities.Messages;
using System;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const double INITIAL_CUBIC_CANTIMETERS = 125;
        private const int maxRange = 69;
        private const int minRange = 50;

        private int horsePower;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, INITIAL_CUBIC_CANTIMETERS)
        {
        }

        public override int HorsePower
        {
            get
            {
                return horsePower;
            }
            protected set
            {
                if (value < minRange || maxRange < value)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }

                horsePower = value;
            }
        }
    }
}
