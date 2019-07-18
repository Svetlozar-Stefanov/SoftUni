using System;
using System.Collections.Generic;
using System.Text;

namespace P04.Recharge
{
    public class Robot : Worker, IRechargeable
    {
        public Robot(string id, int capacity) 
            : base(id)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; }

        public int CurrentPower { get; set; }

        public override void Work(int hours)
        {
            if (hours > this.CurrentPower)
            {
                hours = CurrentPower;
            }

            base.Work(hours);
            CurrentPower -= hours;
        }

        public void Recharge()
        {
            CurrentPower = Capacity;
        }
    }
}