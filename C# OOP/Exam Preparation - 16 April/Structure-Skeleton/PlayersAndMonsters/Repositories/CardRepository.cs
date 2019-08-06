using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        private List<ICard> cards;

        public CardRepository()
        {
            cards = new List<ICard>();
        }

        public int Count => cards.Count;

        public IReadOnlyCollection<ICard> Cards => cards.AsReadOnly();

        public void Add(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }
            if (cards.Any(c => c.Name == card.Name))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }
            
            cards.Add(card);
        }

        public ICard Find(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }

            return cards.FirstOrDefault(c => c.Name == name);
        }

        public bool Remove(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null");
            }

            return cards.Remove(card);
        }
    }
}
