class Box{

    private Unit content;

    public Box()
    {
        this.content = null;
    }
    public bool hasUnit() { return this.content != null; }
    public void addUnit(Unit u)
    {
        if (this.content != null) throw new System.Exception("The box already has an Unit");
        else this.content = u;
    }
    public Unit getContent() { return this.content; }
}
