using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Avatar Class
// The Avatar in the main character in Three of Coins
// The Avatar's actions are controlled by everyone in the game
public class Avatar : MonoBehaviour {
    // Attributes
    int health; // Health stat
    int strength; // Strength stat, for attacks in combat
    int defense; // Defense stat, for blocking enemy attacks in combat
    int intelligence; // Intelligence stat, for magic and stuff
    int gold; // Gold, for buying items
    List<FightCard> fightDeck; // The deck of Fight Cards available to the player
    List<int> fightCardPlayed; // Keep a list of what cards were played so they do not get played again
    bool alive;

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
}
