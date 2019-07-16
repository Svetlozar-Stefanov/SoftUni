namespace MilitaryElite.Models
{
    public class Repair
    {
        public Repair(string part, int hours)
        {
            Part = part;
            Hours = hours;
        }
        public string Part { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
            return $"  Part Name: {Part} Hours Worked: {Hours}";
        }
    }
}
