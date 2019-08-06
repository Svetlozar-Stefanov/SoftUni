using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer is Beginner)
            {
                attackPlayer.Health += 40;
                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            if (enemyPlayer is Beginner)
            {
                enemyPlayer.Health += 40;
                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            foreach (var card in attackPlayer.CardRepository.Cards)
            {
                attackPlayer.Health += card.HealthPoints;
            }

            foreach (var card in enemyPlayer.CardRepository.Cards)
            {
                enemyPlayer.Health += card.HealthPoints;
            }

            while (!attackPlayer.IsDead && !enemyPlayer.IsDead)
            {
                if (!attackPlayer.IsDead)
                {
                    foreach (var card in attackPlayer.CardRepository.Cards)
                    {
                        enemyPlayer.TakeDamage(card.DamagePoints);
                    }
                }
                if (!enemyPlayer.IsDead)
                {
                    foreach (var card in enemyPlayer.CardRepository.Cards)
                    {
                        attackPlayer.TakeDamage(card.DamagePoints);

                        if (attackPlayer.IsDead)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
