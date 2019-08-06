using PlayersAndMonsters.Common;
using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.Core.Factories;
using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.BattleFields;
using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories;
using PlayersAndMonsters.Repositories.Contracts;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class ManagerController : IManagerController
    {
        private IPlayerFactory playerFactory;
        private ICardFactory cardFactory;
        private IPlayerRepository playerRepository;
        private ICardRepository cardRepository;
        private IBattleField battleField;

        public ManagerController()
        {
            playerFactory = new PlayerFactory();
            cardFactory = new CardFactory();
            playerRepository = new PlayerRepository();
            cardRepository = new CardRepository();
            battleField = new BattleField();
        }

        public ManagerController(IPlayerFactory playerFactory, ICardFactory cardFactory, IPlayerRepository playerRepository, ICardRepository cardRepository, IBattleField battleField)
        {
            this.playerFactory = playerFactory;
            this.cardFactory = cardFactory;
            this.playerRepository = playerRepository;
            this.cardRepository = cardRepository;
            this.battleField = battleField;
        }

        public string AddCard(string type, string name)
        {
            cardRepository.Add(cardFactory.CreateCard(type, name));

            return string.Format(ConstantMessages.SuccessfullyAddedCard, type, name);
        }

        public string AddPlayer(string type, string username)
        {
            playerRepository.Add(playerFactory.CreatePlayer(type, username));

            return string.Format(ConstantMessages.SuccessfullyAddedPlayer, type, username);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            playerRepository.Find(username).CardRepository.Add(cardRepository.Find(cardName));

            return string.Format(ConstantMessages.SuccessfullyAddedPlayerWithCards, cardName, username);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            IPlayer attacker = playerRepository.Find(attackUser);
            IPlayer enemy = playerRepository.Find(enemyUser);

            battleField.Fight(attacker, enemy);

            string result = string.Format(ConstantMessages.FightInfo, attacker.Health, enemy.Health);
            return result;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var player in playerRepository.Players)
            {
                sb.AppendLine(string.Format(ConstantMessages.PlayerReportInfo,player.Username, player.Health, player.CardRepository.Count));

                foreach (var card in player.CardRepository.Cards)
                {
                    sb.AppendLine(string.Format(ConstantMessages.CardReportInfo, card.Name, card.DamagePoints));
                }

                sb.AppendLine(ConstantMessages.DefaultReportSeparator);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
