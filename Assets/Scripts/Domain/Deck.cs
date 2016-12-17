using System;
using System.Collections.Generic;
class Deck {

    private List<Card> deck = new List<Card>();
    private Player player;

    public Deck(List<Card> deck, Player p)
    {
        this.deck = deck;
        this.player = p;
    }
    public void insertCard(Card c)
    {
        deck.Insert(deck.Count,c);
    }
    public void shuffle(Card c)
    {
        Random rnd = new Random();
        int position = rnd.Next(0, deck.Count);
        deck.Insert(position, c);
    }
    public Card getCard(Card c)
    {
        c=deck.Find(c.Equals);
        return c;
    }
    public void removeCard(Card c) { deck.Remove(c);}
    public void removeFirst() { deck.RemoveAt(0);}
}
