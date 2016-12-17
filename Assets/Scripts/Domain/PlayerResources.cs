class PlayerResources{

    private int gold;

    public PlayerResources()
    {
        this.gold = 1000;
    }

    public int getGold() { return this.gold; }
    public void increaseGold(int amount) { this.gold += amount; }
}
