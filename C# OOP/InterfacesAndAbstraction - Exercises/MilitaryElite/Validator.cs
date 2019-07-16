using System;

namespace MilitaryElite
{
    public static class Validator
    {
        internal static void CheckCrop(string value)
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException("Invalid Crop!");
            }
        }

        internal static void CheckMissionStatus(string value)
        {
            if (value != "inProgress" && value != "Finished")
            {
                throw new ArgumentException("Invalid Status!");
            }
        }
    }
}
