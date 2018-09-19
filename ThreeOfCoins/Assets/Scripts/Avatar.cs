using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Avatar Class
// The Avatar in the main character in Three of Coins
// The Avatar's actions are controlled by everyone in the game
public class Avatar : MonoBehaviour {
    // Attributes
    public int health; // Health stat
    public int strength; // Strength stat, for attacks in combat
    public int defense; // Defense stat, for blocking enemy attacks in combat
    public int intelligence; // Intelligence stat, for magic and stuff
    public int gold; // Gold, for buying items
    public List<FightCard> fightDeck; // The deck of Fight Cards available to the player
    public List<int> fightCardPlayed; // Keep a list of what cards were played so they do not get played again
    public bool alive; // Keep track of if player is alive

	// Use this for initialization
	void Start () {
		
	}

    // Add card to fight deck based on Event Card, NPC
    void AddToFightDeck(FightCard newFC)
    {
        fightDeck.Add(newFC);
    }

    // Apply fight card effects

    void ApplyFightCardEffect(FightCard votedCard)
    {
        // ...
    }

    // Properties
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }
}
