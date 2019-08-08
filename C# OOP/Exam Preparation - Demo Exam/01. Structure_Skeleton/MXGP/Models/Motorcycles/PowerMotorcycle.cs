using MXGP.Utilities.Messages;
using System;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double INITIAL_CUBIC_CANTIMETERS = 450;
        private const int maxRange = 100;
        private const int minRange = 70;

        private int horsePower;

        public PowerMotorcycle(string model, int horsePower) 
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
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                horsePower = value;
            }
        }
    }
}
