namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const string DefaultName = "Tommy Vercetti";
        private const int DefaultLifePoints = 100;

        public MainPlayer() 
            : base(DefaultName, DefaultLifePoints)
        {
        }
    }
}
