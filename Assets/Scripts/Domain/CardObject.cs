class CardObject
{
    protected int ID;
    protected string cardName;
    protected CardType cardType;
    protected int cost;
    protected int attack;
    protected int range;
    protected int life;
    protected int movement;
    protected MoveClass moveClass;
    protected bool active;
    protected CardGraphic graphics;
    protected int xMov;
    protected int xAtk;

    public static ActionManager actionManager = new ActionManager(10);

    public CardObject(int newID)
    {

        ID = newID;
        CardData cd = new CardData(ID);
        cardName = cd.getCardName();
        cardType = cd.getCardType();
        cost = cd.getCost();
        attack = cd.getAttack();
        range = cd.getRange();
        life = cd.getLife();
        movement = cd.getMovement();
        moveClass = cd.getMoveClass();
        active = cd.getActive();
        graphics = cd.getGraphic();
        xMov = cd.getXMove();
        xAtk = cd.getXAtk();
    }
    public CardObject(CardObject c)
    {
        ID = c.getID();
        cardName = c.getCardName();
        cardType = c.getCardType();
        cost = c.getCost();
        attack = c.getAttack();
        range = c.getRange();
        life = c.getLife();
        movement = c.getMovement();
        moveClass = c.getMoveClass();
        active = c.getActive();
        graphics = c.getGraphic();
        xMov = c.getXMove();
        xAtk = c.getXAtk();
    }

    // Getters. Values will only change for individual Units    

    public int getID() { return ID; }
    public string getCardName() { return cardName; }
    public CardType getCardType() { return cardType; }
    public int getCost() { return cost; }
    public int getAttack() { return attack; }
    public int getRange() { return range; }
    public int getLife() { return life; }
    public int getMovement() { return movement; }
    public MoveClass getMoveClass() { return moveClass; }
    public bool getActive() { return active; }
    public CardGraphic getGraphic() { return graphics; }
    public int getXMove() { return this.xMov; }
    public int getXAtk() { return this.xAtk; }

    // Setters / Modifiers

    public void setCost(int newCost) { cost = newCost; }
    public void increaseCost(int cost) { cost += cost; }

    // WATCH OUT! INCOMING CORE FUNCTION!

    public bool playCard(Box box)
    {
        if (this.cardType.getType() == CardType.UNIT)
        {
            box.addUnit(new Unit(this,box));
        }
        return true;
    }
}
