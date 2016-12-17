using System.Collections.Generic;
class Hand{

    private int maxCards=10;
    private List<Card> hand=new List<Card>();
    private Player player;
    private Card extra;

    public Hand(Player p)
    {
        this.player = p;
    }
    public void addCard(Card c)
    {
        if (this.hand.Count == maxCards)
        {
            this.extra = c;
            deckOverload();
        }
        else this.hand.Add(c);
    }
    private void deckOverload()
    {

    }
    public int size() { return this.hand.Count; }
    public int getMaxCards() { return this.maxCards; }
    public Player getPlayer() { return this.player; }
    public Card getExtra() { return this.extra; }
    public List<Card> cardList() { return this.hand; }
}
