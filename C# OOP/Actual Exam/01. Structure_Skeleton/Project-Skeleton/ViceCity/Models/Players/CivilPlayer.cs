namespace ViceCity.Models.Players
{
    public class CivilPlayer : Player
    {
        private const int DefaultLifePoints = 50;

        public CivilPlayer(string name) 
            : base(name, DefaultLifePoints)
        {
        }
    }
}
