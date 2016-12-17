class CardData {

    private int ID;
    private string cardName;
    private CardType cardType;
    private int cost;
    private int attack;
    private int range;
    private int life;
    private int movement;
    private MoveClass moveClass;
    private bool active;
    private CardGraphic graphic;
    private int xMov;
    private int xAtk;

    public CardData (int ID){

        // TODO: Load Card Data



        }

    public string getCardName() { return this.cardName; }
    public CardType getCardType() { return this.cardType; }
    public int getCost() { return this.cost; }
    public int getAttack() { return this.attack; }
    public int getRange() { return this.range; }
    public int getLife() { return this.life; }
    public int getMovement() { return this.movement; }
    public MoveClass getMoveClass() { return this.moveClass; }
    public bool getActive() { return this.active; }
    public CardGraphic getGraphic() { return this.graphic; }
    public int getXMove() { return this.xMov; }
    public int getXAtk() { return this.xAtk; }
}
