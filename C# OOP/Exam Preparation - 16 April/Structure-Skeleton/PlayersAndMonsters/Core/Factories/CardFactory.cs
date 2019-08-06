using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.Cards;
using PlayersAndMonsters.Models.Cards.Contracts;
using System;
using System.Reflection;

namespace PlayersAndMonsters.Core.Factories
{
    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            ICard card = null;

            if (type == "Magic")
            {
                card = new MagicCard(name);
            }
            if (type == "Trap")
            {
                card = new TrapCard(name);
            }

            return card;
        }
    }
}
