class Unit : CardObject
{

    private Box box;

    public Unit(int ID,Box box) : base(ID)
    {
        this.box = box;
    }
    public Unit(CardObject c,Box box) : base(c)
    {
        this.box = box;
    }

    public void setAttack(int atk) { base.attack = atk; }
    public void increaseAttack(int atk) { base.attack += atk; }

    public void setRange(int range) { base.range = range; }
    public void increaseRange(int atk) { base.range += range; }

    public void setLife(int life) { base.life = life; }
    public void increaseLife(int life) { base.life += life; }

    public void setMovement(int mov) { base.movement = mov; }
    public void increaseMovement(int mov) { base.movement += mov; }
}
