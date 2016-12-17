using System.Collections;
using System.Collections.Generic;

public class ActionManager {

    private ArrayList actions;
    int cardCollectionSize;

    public ActionManager(int n)
    {
        this.cardCollectionSize = n;
        this.actions = new ArrayList();
        this.loadActions();
    }

    public Action getAction(int ID) {return (Action)actions[ID];}

    private void loadActions()
    {
        for(int i = 0; i < cardCollectionSize; i++)
        {
            Action a = loadActions(i);
            if(a!=null)actions.Add(a);
        }
    }

    private static Action loadActions(int i)
    {
        switch (i)
        {
            case 0: return new Action0();
            case 1: return new Action1();
            default: throw new System.ArgumentException("Couldn't initiate ActionManager: There are not enough Actions defined for all the card collection.");
        }
    }
}
