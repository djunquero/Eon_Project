using UnityEngine;

public abstract class Action : MonoBehaviour, ActionClasses{

    protected int cardID;

    public abstract void active();

    public abstract void trigger();


    public static void berserker()
    {
        // Example of a common action. The action of that card will execute this one, and will be common for all [Berserker] cards
    }
}
