using System.Collections.Generic;

namespace MtGDB.Models
{
    public class MockCardRepository : ICardRepository
    {
        public IEnumerable<Card> GetAllCards => new List<Card> 
        {
            new Card{Name = "Shivan Dragon", Quantity = 1, Rarity = Rarity.Rare, Edition = "M15"},
            new Card{Name = "Storm Crow", Quantity = 4, Rarity = Rarity.Common, Edition = "Sixth Edition"},
            new Card{Name = "Rampaging Baloths", Quantity = 1, Rarity = Rarity.Mythic, Edition = "Zendikar"},
            new Card{Name = "Avenger of Zendikar", Quantity = 1, Rarity = Rarity.Mythic, Edition = "Zendikar"},
            new Card{Name = "Counterspell", Quantity = 2, Rarity = Rarity.Common, Edition = "Commander Legends"}
        };

        public Card GetCardByName(string cardName)
        {
            throw new System.NotImplementedException();
        }
    }
}