public class Action0 : Action
{

    public Action0()
    {
        this.cardID = 0;
    }

    public override void active() { }

    public override void trigger() {
        Action.berserker();
    }
}
