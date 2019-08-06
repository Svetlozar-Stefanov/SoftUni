using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;

        public Player()
        {
            IsDead = false;
        }

        public Player(ICardRepository cardRepository, string username, int health)
            : this()
        {
            CardRepository = cardRepository;
            Username = username;
            Health = health;
        }

        public ICardRepository CardRepository { get; private set; }

        public string Username
        {
            get
            {
                return username;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string. ");
                }

                username = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero. ");
                }

                health = value;
            }
        }

        public bool IsDead { get; private set; }

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }
            else if (damagePoints > Health)
            {
                Health = 0;
                IsDead = true;
            }
            else
            {
                Health -= damagePoints;
            }
        }
    }
}
