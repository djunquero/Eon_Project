class CardData
{
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
    private CardGraphic graphics;
    private int xMov;
    private int xAtk;

    public static CardData[] loadData()
    {
        StreamReader reader = new StreamReader(file);
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<CardData>(json);
    }

    // Given JSON input:
    // {"name":"Dr Charles","lives":3,"health":0.8}
    // this example will return a PlayerInfo object with
    // name == "Dr Charles", lives == 3, and health == 0.8f.

}
