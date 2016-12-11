class Card
{
    private int ID;
    private string cardName;
    private CardType cardType;
    protected int cost;
    protected int attack;
    protected int range;
    protected int life;
    protected int movement;
    protected MoveClass moveClass;
    protected bool active;
    protected CardGraphic graphics;

    public Card(int ID)
    {
        this.ID = ID;
        CardData cd = new CardData(ID);
        this.cardName = cd.getCardName();
        this.cardType = cd.getCardType();
        this.cost = cd.getCost();
        this.attack = cd.getAttack();
        this.range = cd.getRange();
        this.life = cd.getLife();
        this.movement = cd.getMovement();
        this.moveClass = cd.getMoveClass();
        this.active = cd.getActive();
        this.graphics = cd.getGraphic();
    }

    // Getters. Values will only change for individual Units    

    public int getID() { return this.ID; }
    public string getCardName() { return this.cardName; }
    public CardType getCardType() { return this.cardType; }
    public int getCost() { return this.cost; }
    public int getAttack() { return this.attack; }
    public int getRange() { return this.range; }
    public int getLife() { return this.life; }
    public int getMovement() { return this.movement; }
    public MoveClass getMoveClass() { return this.moveClass; }
    public bool getActive() { return this.active; }
    public CardGraphic getGraphic() { return this.graphics; }

    // Setters / Modifiers

    public void setCost(int cost) { this.cost = cost; }
    public void increaseCost(int cost) { this.cost += cost; }

    // WATCH OUT! INCOMING CORE FUNCTION!

    public bool playCard(Box box)
    {
        // TODO: Implement Action Manager
        return true;
    }
}
