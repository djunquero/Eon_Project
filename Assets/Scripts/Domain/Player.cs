using System.Collections.Generic;

class Player{
    private int ID;
    private Deck deck;
    private Hand hand;
    private PlayerResources resources;

    public Player(int newID,List<Card> initialDeck)
    {
        this.ID = newID;
        this.deck = new Deck(initialDeck,this);
        this.hand = new Hand(this);
        this.resources = new PlayerResources();
    }
    public int getID() { return this.ID; }
    public Hand getHand() { return this.hand; }
    public Deck getDeck() { return this.deck; }
}
