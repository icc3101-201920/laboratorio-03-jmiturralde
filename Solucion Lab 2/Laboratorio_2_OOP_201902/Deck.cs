using Laboratorio_2_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2_OOP_201902
{
    public class Deck
    {
        List<Card.Card> cards;

        public Deck()
        {
            cards = new List<Card.Card>();
        }

        public void AddCombatCard(CombatCard combatCard)
        {
            cards.Add(combatCard);
        }
        public void AddSpecialCard(SpecialCard specialCard)
        {
            cards.Add(specialCard);
        }
        public void DestroyCombatCard(int cardId) { throw new NotImplementedException(); }
        public void DestroySpecialCard(int cardId) { throw new NotImplementedException(); }
        public void Shuffle() { 
            throw new NotImplementedException();
        }
    }
}
