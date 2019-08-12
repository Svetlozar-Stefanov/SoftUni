using System.Collections.Generic;
using System.Linq;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            IGun currentGun = mainPlayer.GunRepository.Models.FirstOrDefault();
            IPlayer civilPlayer = civilPlayers.FirstOrDefault();

            while (mainPlayer.GunRepository.Models.Count > 0 && civilPlayers.Count > 0)
            {
                civilPlayer.TakeLifePoints(currentGun.Fire());

                if (!currentGun.CanFire)
                {
                    mainPlayer.GunRepository.Remove(currentGun);

                    currentGun = mainPlayer.GunRepository.Models.FirstOrDefault();
                }
                if (!civilPlayer.IsAlive)
                {
                    civilPlayers.Remove(civilPlayer);

                    civilPlayer = civilPlayers.FirstOrDefault();
                }
            }

            if (civilPlayers.Count > 0)
            {
                IPlayer attackingCivilPlayer = civilPlayers.FirstOrDefault();

                IGun currentCivilianGun = attackingCivilPlayer.GunRepository.Models.FirstOrDefault();

                while (mainPlayer.IsAlive && civilPlayers.Any(c => c.GunRepository.Models.Count > 0))
                {
                    mainPlayer.TakeLifePoints(currentCivilianGun.Fire());

                    if (currentCivilianGun.TotalBullets <= 0)
                    {
                        attackingCivilPlayer.GunRepository.Remove(currentCivilianGun);

                        currentCivilianGun = attackingCivilPlayer.GunRepository.Models.FirstOrDefault();
                    }
                }
            }
        }
    }
}
