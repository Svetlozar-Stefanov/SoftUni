namespace MilitaryElite.Models
{
    public class Mission
    {
        private string status;

        public Mission(string name, string status)
        {
            Name = name;
            Status = status;
        }

        public string Name { get; set; }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                Validator.CheckMissionStatus(value);
                status = value;
            }
        }

        public override string ToString()
        {
            return $"  Code Name: {Name} State: {Status}";
        }
    }
}
