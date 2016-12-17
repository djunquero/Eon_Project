class CardType{
    public const string HERO = "HERO";
    public const string UNIT = "UNIT";
    public const string ABILITY = "ABILITY";

    private string type;

    public CardType(string s)
    {
        if (s != HERO && s != UNIT && s != ABILITY) throw new System.Exception("Unknown CardType");
        else this.type = s;
    }

    public string getType() { return this.type; }
}
