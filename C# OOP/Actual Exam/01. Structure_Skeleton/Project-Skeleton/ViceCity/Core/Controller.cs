using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private IPlayer mainPlayer;
        private List<IPlayer> civilPlayers;
        private Queue<IGun> guns;
        private INeighbourhood neighbourhood;

        public Controller()
        {
            mainPlayer = new MainPlayer();
            civilPlayers = new List<IPlayer>();
            guns = new Queue<IGun>();
            neighbourhood = new GangNeighbourhood();
        }

        public string AddGun(string type, string name)
        {
            IGun gun = null;

            if (type == "Pistol")
            {
                gun = new Pistol(name);
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name);
            }

            if (gun == null)
            {
                return "Invalid gun type!";
            }

            guns.Enqueue(gun);

            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            if (guns.Count <= 0)
            {
                return "There are no guns in the queue!";
            }

            IGun gun = guns.Peek();

            if (name == "Vercetti")
            {
                mainPlayer.GunRepository.Add(gun);

                guns.Dequeue();

                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }

            if (!civilPlayers.Any(c => c.Name == name))
            {
                return "Civil player with that name doesn't exists!";
            }

            IPlayer player = civilPlayers.FirstOrDefault(c => c.Name == name);

            player.GunRepository.Add(gun);
            guns.Dequeue();

            return $"Successfully added {gun.Name} to the Civil Player: {name}";
        }

        public string AddPlayer(string name)
        {
            IPlayer civilPlayer = new CivilPlayer(name);

            civilPlayers.Add(civilPlayer);

            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            int initialMainPlayerHealth = mainPlayer.LifePoints;
            int initialCivilHealth = 50;
            int initilaCivilPlayersCount = civilPlayers.Count;

            neighbourhood.Action(mainPlayer, civilPlayers);

            if (mainPlayer.LifePoints == initialMainPlayerHealth && civilPlayers.Count == initilaCivilPlayersCount && civilPlayers.All(c => c.LifePoints == initialCivilHealth))
            {
                return "Everything is okay!";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("A fight happened:");
            sb.AppendLine($"Tommy live points: {mainPlayer.LifePoints}!");
            sb.AppendLine($"Tommy has killed: {initilaCivilPlayersCount - civilPlayers.Count} players!");
            sb.AppendLine($"Left Civil Players: {civilPlayers.Count}!");

            return sb.ToString().TrimEnd();
        }
    }
}
