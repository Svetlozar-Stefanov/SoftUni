using System;

namespace P01._HelloWorld
{
    public class HelloWorld
    {
        private DateTime dateTime;

        public HelloWorld(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string Greeting(string name)
        {
            if (dateTime.Hour < 12)
            {
                return "Good morning, " + name;
            }

            if (dateTime.Hour < 18)
            {
                return "Good afternoon, " + name;
            }

            return "Good evening, " + name;
        }
    }
}
