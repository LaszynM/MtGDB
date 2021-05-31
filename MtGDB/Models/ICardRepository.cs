using System.Collections.Generic;

namespace MtGDB.Models
{
    public interface ICardRepository
    {
        Card GetCardByName(string cardName);
        IEnumerable<Card> GetAllCards {get;}    
    }
}