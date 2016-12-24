using UnityEngine;
using System.Collections.Generic;
public class GameControl : MonoBehaviour {

    private Player p1;
    private Player p2;

	// Use this for initialization
	void Start () {

        p1 = new global::Player(1,manualDeckGeneration());
        p2 = new global::Player(2,manualDeckGeneration());
    }

    private List<CardObject> manualDeckGeneration()
    {
        List<CardObject> deck = new List<CardObject>();
        for(int i = 0; i < 10;i++) deck.Add(new CardObject(i));
        return deck;
    }
}
